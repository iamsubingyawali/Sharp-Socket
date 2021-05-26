using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        // Defining boolean value to initialize and stop communication code
        internal bool flag;
        // Defining delegate to perfom thread safe call
        delegate void SetMessageSafeCall(TextBox textBox,string message);
        // Defining thread
        internal Thread clientThread;

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // Defining tasks to be performed when Connect button is clicked
            panelStatus.BackColor = Color.LimeGreen;
            buttonEnd.Enabled = true;
            buttonConnect.Enabled = false;
            textBoxMessage.Enabled = true;
            buttonSend.Enabled = true;
            textBoxIpAddress.Enabled = false;
            textBoxPortNum.Enabled = false;
            comboBoxProtocol.Enabled = false;
            flag = false;

            // Checking which protocol has been selected from the dropdown 
            // and running respective method as a seprate thread
            if (comboBoxProtocol.SelectedItem.Equals("TCP"))
            {
                // Running TCP Connection code if TCP is selected
                clientThread = new Thread(TcpClient);
            }
            else
            {
                // Running UDP Connection code if UDP is selected
                clientThread = new Thread(UdpClient);
            }
            clientThread.Start();
        }

        // Defining tasks to be performed when End button is clicked
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            panelStatus.BackColor = Color.Red;
            buttonEnd.Enabled = false;
            buttonConnect.Enabled = true;
            textBoxMessage.Enabled = false;
            buttonSend.Enabled = false;
            textBoxIpAddress.Enabled = true;
            textBoxPortNum.Enabled = true;
            comboBoxProtocol.Enabled = true;
            textBoxChat.Text = null;
            textBoxMessage.Text = null;
            flag = true;
        }

        // Listening to key Listeners
        private void textBoxMessage_KeyUp(object sender, KeyEventArgs e)
        {
            // getting the key code of the pressed key
            int keyCode = Convert.ToInt32(e.KeyCode);

            // Identifying if 'Enter' key was pressed
            if (keyCode == 13)
            {
                // starting lock block to wake up the thread from the wait state
                // wait method is called inside the thread class
                lock (clientThread)
                {
                    Monitor.PulseAll(clientThread);
                }
            }

        }
        
        // Defining actions when Send button is clicked
        private void buttonSend_Click(object sender, EventArgs e)
        {
            // starting lock block to wake up the thread from the wait state
            // wait method is called inside the thread class
            lock (clientThread) {
                Monitor.PulseAll(clientThread);
            }
        }

        // SetMessage method to implement Thread safe call and to set the text in the defined text box
        // Parameters: textBox to define TextBox in which text is going to be appended
        // and message to define the text
        public void SetMessage(TextBox textBox,string text) {
            // checking whether the textbox component is in the same thread which is trying to use it
            if (textBox.InvokeRequired)
            {
                // Performing thread safe call using delegate when the thread which wanted to use the
                // component is not the same thread which created it
                SetMessageSafeCall setMessage = new SetMessageSafeCall(SetMessage);
                textBox.Invoke(setMessage,new object[] { textBox,text });
            }

            else textBox.Text = text;
        }

        // Method TcpClient to perform TCP Client Communication
        public void TcpClient()
        {
            // Setting greet text
            SetMessage(textBoxChat, textBoxChat.Text + "Attempted TCP Connection..."+ Environment.NewLine + Environment.NewLine);
            try
            {
                //SENDING DATA
                // Defining TCPClient object to create a TCP socket
                TcpClient socket = null;
                // Defining StreamWriter object to write on the socket
                StreamWriter writer;
                // Defining StreamReader object to read from the socket
                StreamReader reader;

                // Starting while loop for continuous connection
                while (!flag)
                {
                    // Initializing socket object with ip address and port 
                    socket = new TcpClient(textBoxIpAddress.Text, Convert.ToInt32(textBoxPortNum.Text));
                    // initialing writer object
                    writer = new StreamWriter(socket.GetStream());
                    // Setting writer to flush automatically
                    writer.AutoFlush = true;

                    // Starting lock block to call wait method to make the thread wait until
                    // it is notified by others
                    lock (clientThread)
                    {
                        Monitor.Wait(clientThread);
                    }

                    // String variable to get the typed text
                    String myMessage = textBoxMessage.Text;

                    // Writing on the socket with the message
                    writer.WriteLine("Client: " + myMessage);
                    // Setting message to own chat text box
                    myMessage = (textBoxChat.Text + Environment.NewLine + "Me: " + myMessage).Trim();
                    SetMessage(textBoxChat, myMessage);

                    // Setting message text box to null after the text has been sent
                    SetMessage(textBoxMessage, null);

                    //RECEIVING DATA
                    // Reading from the socket
                    reader = new StreamReader(socket.GetStream());
                    // String varibale to store the read message
                    string message;

                    // Checking whether the received message is null
                    if ((message = reader.ReadLine()) != null)
                    {
                        // Appending the message to the chat text box
                        message = (textBoxChat.Text + Environment.NewLine + message).Trim();
                        SetMessage(textBoxChat, message);
                    }
                }
                // Closing the socket
                socket.Close();
            }
            // Handling the possible exceptions
            catch (Exception) { }
        }



        // Method UdpClient to perform UDP Communication
        public void UdpClient() 
        {
            // setting greet text
            SetMessage(textBoxChat, textBoxChat.Text + "Attempted UDP Connection..." + Environment.NewLine + Environment.NewLine);
            try
            {
                //SENDING DATA
                // Defining and initializing UdpClient object to create a UDP socket
                UdpClient client = new UdpClient();
                // Defining and Initializing an IPEndPoint object to define ip address and port of the
                // end points of the socket
                IPEndPoint socket = new IPEndPoint(IPAddress.Parse(textBoxIpAddress.Text), Convert.ToInt32(textBoxPortNum.Text));
                
                // Starting while loop for continuous communication
                while (!flag)
                {
                    // Starting lock block to call wait method to make the thread wait until
                    // it is notified by others
                    lock (clientThread)
                    {
                        Monitor.Wait(clientThread);
                    }

                    // String variable to store the typed message
                    String myMessage = textBoxMessage.Text;

                    // Sending the message through the socket
                    client.Send(Encoding.ASCII.GetBytes(myMessage), myMessage.Length, socket);
                    // Setting text to own chat text box
                    myMessage = (textBoxChat.Text + Environment.NewLine + "Me: " + myMessage).Trim();
                    SetMessage(textBoxChat, myMessage);

                    // Setting message text box to null after the text has been sent
                    SetMessage(textBoxMessage, null);

                    //RECEIVING DATA
                    // String varible to store the received message
                    String message = Encoding.ASCII.GetString(client.Receive(ref socket));

                    // Checking whether the received message is null
                    if (message != null)
                    {
                        // Appending the message to the chat text box
                        message = (textBoxChat.Text + Environment.NewLine + "Server: " + message).Trim();
                        SetMessage(textBoxChat, message);
                    }

                }
                // Closing the socket
                client.Close();
            }

            // Catching the possible exceptions
            catch (Exception) { }
        }
    }
}
