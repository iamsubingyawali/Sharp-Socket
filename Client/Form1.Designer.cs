using System.Drawing;

namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxProtocol = new System.Windows.Forms.ComboBox();
            this.textBoxPortNum = new System.Windows.Forms.TextBox();
            this.labelColon = new System.Windows.Forms.Label();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.panelSend = new System.Windows.Forms.Panel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.panelChat = new System.Windows.Forms.Panel();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.panelConnection.SuspendLayout();
            this.panelSend.SuspendLayout();
            this.panelChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.Red;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(600, 4);
            this.panelStatus.TabIndex = 0;
            // 
            // panelConnection
            // 
            this.panelConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.panelConnection.Controls.Add(this.buttonEnd);
            this.panelConnection.Controls.Add(this.buttonConnect);
            this.panelConnection.Controls.Add(this.comboBoxProtocol);
            this.panelConnection.Controls.Add(this.textBoxPortNum);
            this.panelConnection.Controls.Add(this.labelColon);
            this.panelConnection.Controls.Add(this.textBoxIpAddress);
            this.panelConnection.Location = new System.Drawing.Point(0, 5);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(582, 45);
            this.panelConnection.TabIndex = 1;
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(5)))), ((int)(((byte)(1)))));
            this.buttonEnd.Enabled = false;
            this.buttonEnd.FlatAppearance.BorderSize = 0;
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.ForeColor = System.Drawing.Color.White;
            this.buttonEnd.Location = new System.Drawing.Point(480, 5);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(90, 35);
            this.buttonEnd.TabIndex = 3;
            this.buttonEnd.Text = "End";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(384, 5);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(90, 35);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxProtocol
            // 
            this.comboBoxProtocol.FormattingEnabled = true;
            this.comboBoxProtocol.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.comboBoxProtocol.Location = new System.Drawing.Point(284, 10);
            this.comboBoxProtocol.Name = "comboBoxProtocol";
            this.comboBoxProtocol.Size = new System.Drawing.Size(75, 24);
            this.comboBoxProtocol.TabIndex = 3;
            this.comboBoxProtocol.SelectedIndex = 0;
            // 
            // textBoxPortNum
            // 
            this.textBoxPortNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPortNum.Location = new System.Drawing.Point(202, 9);
            this.textBoxPortNum.Name = "textBoxPortNum";
            this.textBoxPortNum.Size = new System.Drawing.Size(75, 28);
            this.textBoxPortNum.TabIndex = 2;
            this.textBoxPortNum.Text = "8080";
            this.textBoxPortNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelColon
            // 
            this.labelColon.AutoSize = true;
            this.labelColon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon.Location = new System.Drawing.Point(177, 5);
            this.labelColon.Name = "labelColon";
            this.labelColon.Size = new System.Drawing.Size(23, 32);
            this.labelColon.TabIndex = 2;
            this.labelColon.Text = ":";
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIpAddress.Location = new System.Drawing.Point(21, 9);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(150, 28);
            this.textBoxIpAddress.TabIndex = 0;
            this.textBoxIpAddress.Text = "127.0.0.1";
            this.textBoxIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelSend
            // 
            this.panelSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panelSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSend.Controls.Add(this.buttonSend);
            this.panelSend.Controls.Add(this.textBoxMessage);
            this.panelSend.ForeColor = System.Drawing.Color.Blue;
            this.panelSend.Location = new System.Drawing.Point(-1, 775);
            this.panelSend.Name = "panelSend";
            this.panelSend.Size = new System.Drawing.Size(601, 79);
            this.panelSend.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSend.Enabled = false;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.ForeColor = System.Drawing.Color.Black;
            this.buttonSend.Image = ((System.Drawing.Image)(resources.GetObject("buttonSend.Image")));
            this.buttonSend.Location = new System.Drawing.Point(506, -1);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(76, 79);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessage.Enabled = false;
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.Location = new System.Drawing.Point(10, 10);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(488, 60);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyUp);
            // 
            // panelChat
            // 
            this.panelChat.BackColor = System.Drawing.Color.White;
            this.panelChat.Controls.Add(this.textBoxChat);
            this.panelChat.ForeColor = System.Drawing.Color.Red;
            this.panelChat.Location = new System.Drawing.Point(0, 49);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(582, 726);
            this.panelChat.TabIndex = 3;
            // 
            // textBoxChat
            // 
            this.textBoxChat.BackColor = System.Drawing.Color.White;
            this.textBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChat.Location = new System.Drawing.Point(12, 6);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.ReadOnly = true;
            this.textBoxChat.Size = new System.Drawing.Size(570, 719);
            this.textBoxChat.TabIndex = 0;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 853);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.panelSend);
            this.Controls.Add(this.panelConnection);
            this.Controls.Add(this.panelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 70);
            this.MaximizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "C# Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.panelSend.ResumeLayout(false);
            this.panelSend.PerformLayout();
            this.panelChat.ResumeLayout(false);
            this.panelChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.TextBox textBoxPortNum;
        private System.Windows.Forms.Label labelColon;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        public System.Windows.Forms.ComboBox comboBoxProtocol;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxChat;
    }
}

