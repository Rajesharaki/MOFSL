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
            this.label1 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.Label();
            this.textHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textStatus = new System.Windows.Forms.ListBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.clientMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(77, 22);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(351, 22);
            this.textUserName.TabIndex = 1;
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(16, 87);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(37, 17);
            this.Host.TabIndex = 2;
            this.Host.Text = "Host";
            // 
            // textHost
            // 
            this.textHost.Location = new System.Drawing.Point(77, 87);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(214, 22);
            this.textHost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(385, 86);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(123, 22);
            this.textPort.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(559, 70);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(151, 54);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textStatus
            // 
            this.textStatus.FormattingEnabled = true;
            this.textStatus.ItemHeight = 16;
            this.textStatus.Location = new System.Drawing.Point(19, 143);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(691, 212);
            this.textStatus.TabIndex = 7;
            this.textStatus.SelectedIndexChanged += new System.EventHandler(this.textStatus_SelectedIndexChanged);
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(19, 392);
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(609, 22);
            this.textMsg.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(651, 377);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(119, 52);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // clientMsg
            // 
            this.clientMsg.AutoSize = true;
            this.clientMsg.Location = new System.Drawing.Point(-1, 430);
            this.clientMsg.Name = "clientMsg";
            this.clientMsg.Size = new System.Drawing.Size(0, 17);
            this.clientMsg.TabIndex = 10;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientMsg);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHost);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox textStatus;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label clientMsg;
    }
}

