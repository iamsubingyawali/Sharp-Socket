using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {        
        // Defining boolean value to initialize and stop communication code
        private bool flag;
        // Defining delegate to perfom thread safe call
        delegate void SetMessageSafeCall(TextBox textBox,string message);
        // Defining thread
        internal Thread serverThread;

        public Server()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Defining tasks to be performed when Open button is clicked
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            panelStatus.BackColor = Color.LimeGreen;
            buttonClose.Enabled = true;
            buttonOpen.Enabled = false;
            textBoxMessage.Enabled = true;
            buttonSend.Enabled = true;
            textBoxPortNum.Enabled = false;
            comboBoxProtocol.Enabled = false;
            flag = false;

            // Checking which protocol has been selected from the dropdown 
            // and running respective method as a seprate thread
            if (comboBoxProtocol.SelectedItem.Equals("TCP"))
            {               
                // Running TCP Connection code if TCP is selected
                serverThread = new Thread(TcpServer);
            }
            else {
                // Running UDP Connection code if UDP is selected
                serverThread = new Thread(UdpServer);
            }
            serverThread.Start();
        }

        // Defining tasks to be performed when Close button is clicked
        private void buttonClose_Click(object sender, EventArgs e)
        {
            panelStatus.BackColor = Color.Red;
            buttonClose.Enabled = false;
            buttonOpen.Enabled = true;
            textBoxMessage.Enabled = false;
            buttonSend.Enabled = false;
            textBoxPortNum.Enabled = true;
            comboBoxProtocol.Enabled = true;
            textBoxMessage.Text = null;
            textBoxChat.Text = null;
            flag = true;
        }

        // Listening to key Listeners
        private void textBoxMessage_KeyUp(object sender, KeyEventArgs e)
        {
            // getting the key code of the pressed key
            int keyCode = Convert.ToInt32(e.KeyCode);

            // Identifying if 'Enter' key was pressed
            if (keyCode == 13) {
                // starting lock block to wake up the thread from the wait state
                // wait method is called inside the thread class
                lock (serverThread)
                {
                    Monitor.PulseAll(serverThread);
                }
            }

        }
        // Defining actions when Send button is clicked
        private void buttonSend_Click(object sender, EventArgs e)
        {
            // starting lock block to wake up the thread from the wait state
            // wait method is called inside the thread class
            lock (serverThread)
            {
                Monitor.PulseAll(serverThread);
            }
        }

        // SetMessage method to implement Thread safe call and to set the text in the defined text box
        // Parameters: textBox to define TextBox in which text is going to be appended
        // and message to define the text
        public void SetMessage(TextBox textBox, string text)
        {
            // checking whether the textbox component is in the same thread which is trying to use it
            if (textBox.InvokeRequired)
            {
                // Performing thread safe call using delegate when the thread which wanted to use the
                // component is not the same thread which created it
                SetMessageSafeCall setMessage = new SetMessageSafeCall(SetMessage);
                textBox.Invoke(setMessage, new object[] { textBox, text });
            }

            else textBox.Text = text;
        }
        // Method TcpServer to perform TCP Server Communication
        public void TcpServer()
        {
            // Setting greet text
            SetMessage(textBoxChat, textBoxChat.Text + "Attempted TCP Connection..."+Environment.NewLine+Environment.NewLine);
            try
            {
                //RECEIVING DATA
                //Defining TcpListener object to open a specified port providing a ip address by server
                TcpListener server = new TcpListener(IPAddress.Any, Convert.ToInt32(textBoxPortNum.Text));
                // Defining TCPClient object to create a TCP socket
                TcpClient socket = null;
                // Defining StreamWriter object to write on the socket
                StreamWriter writer;
                // Defining StreamReader object to read from the socket
                StreamReader reader;
                // Starting the socket by the server
                server.Start();

                // Starting while loop for continuous connection
                while (!flag) {
                    // Accepting connection request sent by the clients
                    socket = server.AcceptTcpClient();
                    // Reading from the socket
                    reader = new StreamReader(socket.GetStream());
                    // String varibale to store the read message
                    string message;

                    // Checking whether the received message is null
                    if ((message = reader.ReadLine()) != null)
                    {
                        // Appending the message to the chat text box
                        message = (textBoxChat.Text + Environment.NewLine + message).Trim();
                        SetMessage(textBoxChat,message);
                    }

                    //SENDING DATA
                    // initialing writer object
                    writer = new StreamWriter(socket.GetStream());
                    // Setting writer to flush automatically
                    writer.AutoFlush = true;

                    // Starting lock block to call wait method to make the thread wait until
                    // it is notified by others
                    lock (serverThread)
                    {
                        Monitor.Wait(serverThread);
                    }

                    // String variable to get the typed text
                    String myMessage = textBoxMessage.Text;

                    // Writing on the socket with the message
                    writer.WriteLine("Server: " + myMessage);
                    // Setting message to own chat text box
                    myMessage = (textBoxChat.Text + Environment.NewLine + "Me: " + myMessage).Trim();
                    SetMessage(textBoxChat, myMessage);

                    // Setting message text box to null after the text has been sent
                    SetMessage(textBoxMessage, null);
                }
                // Closing the used resources
                socket.Close();
                server.Stop();
            }
            // Handling the possible exceptions
            catch (Exception){ }
        }




        // Method UdpServer to perform UDP Communication
        public void UdpServer()
        {
            // setting greet text
            SetMessage(textBoxChat, textBoxChat.Text + "Attempted UDP Connection..." + Environment.NewLine + Environment.NewLine);
            try
            {
                //RECEIVING DATA
                // Defining and initializing UdpClient object with port number to create a UDP socket
                UdpClient server = new UdpClient(Convert.ToInt32(textBoxPortNum.Text));;

                // Starting while loop for continuous communication
                while(!flag) { 
                    // Defining and Initializing an IPEndPoint object to define ip address and port of the
                    // end points of the socket
                    IPEndPoint socket = new IPEndPoint(IPAddress.Any,0);

                    // String varible to store the received message
                    String message = Encoding.ASCII.GetString(server.Receive(ref socket));

                    // Checking whether the received message is null
                    if (message != null)
                    {
                        // Appending the message to the chat text box
                        message = (textBoxChat.Text + Environment.NewLine +"Client: "+ message).Trim();
                        SetMessage(textBoxChat, message);
                    }

                    // Starting lock block to call wait method to make the thread wait until
                    // it is notified by others
                    lock (serverThread)
                    {
                        Monitor.Wait(serverThread);
                    }

                    //SENDING DATA
                    // String variable to store the typed message
                    String myMessage = textBoxMessage.Text;
                   
                    // Sending the message through the socket
                    server.Send(Encoding.ASCII.GetBytes(myMessage),myMessage.Length,socket);
                    // Setting text to own chat text box
                    myMessage = (textBoxChat.Text + Environment.NewLine + "Me: " + myMessage).Trim();
                    SetMessage(textBoxChat, myMessage);

                    // Setting message text box to null after the text has been sent
                    SetMessage(textBoxMessage,null);
                }
                // Closing the socket
                server.Close();
            }
            // Catching the possible exceptions
            catch (Exception){ }
        }
    }
}
