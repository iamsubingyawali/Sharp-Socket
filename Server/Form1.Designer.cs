using System.Drawing;

namespace Server
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxProtocol = new System.Windows.Forms.ComboBox();
            this.textBoxPortNum = new System.Windows.Forms.TextBox();
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
            this.panelConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.panelConnection.Controls.Add(this.buttonClose);
            this.panelConnection.Controls.Add(this.buttonOpen);
            this.panelConnection.Controls.Add(this.comboBoxProtocol);
            this.panelConnection.Controls.Add(this.textBoxPortNum);
            this.panelConnection.Location = new System.Drawing.Point(0, 5);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(582, 45);
            this.panelConnection.TabIndex = 1;
            this.panelConnection.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(5)))), ((int)(((byte)(1)))));
            this.buttonClose.Enabled = false;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(471, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 35);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.Color.White;
            this.buttonOpen.Location = new System.Drawing.Point(365, 5);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(90, 35);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboBoxProtocol
            // 
            this.comboBoxProtocol.FormattingEnabled = true;
            this.comboBoxProtocol.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.comboBoxProtocol.Location = new System.Drawing.Point(131, 9);
            this.comboBoxProtocol.Name = "comboBoxProtocol";
            this.comboBoxProtocol.Size = new System.Drawing.Size(75, 24);
            this.comboBoxProtocol.TabIndex = 3;
            this.comboBoxProtocol.SelectedIndex = 0;
            // 
            // textBoxPortNum
            // 
            this.textBoxPortNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPortNum.Location = new System.Drawing.Point(27, 8);
            this.textBoxPortNum.Name = "textBoxPortNum";
            this.textBoxPortNum.Size = new System.Drawing.Size(75, 28);
            this.textBoxPortNum.TabIndex = 2;
            this.textBoxPortNum.Text = "8080";
            this.textBoxPortNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panelSend.Size = new System.Drawing.Size(601, 82);
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
            this.buttonSend.Location = new System.Drawing.Point(503, -1);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(79, 78);
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
            // Server
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
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(1020, 70);
            this.MaximizeBox = false;
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "C# Server";
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
        public System.Windows.Forms.ComboBox comboBoxProtocol;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxChat;
    }
}

