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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textServerHost = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textServerPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.textStatus = new System.Windows.Forms.ListBox();
            this.serverMsg = new System.Windows.Forms.Label();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // textServerHost
            // 
            this.textServerHost.Location = new System.Drawing.Point(57, 39);
            this.textServerHost.Name = "textServerHost";
            this.textServerHost.Size = new System.Drawing.Size(228, 22);
            this.textServerHost.TabIndex = 1;
            this.textServerHost.Text = "127.0.0.1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // textServerPort
            // 
            this.textServerPort.Location = new System.Drawing.Point(360, 42);
            this.textServerPort.Name = "textServerPort";
            this.textServerPort.Size = new System.Drawing.Size(129, 22);
            this.textServerPort.TabIndex = 4;
            this.textServerPort.Text = "9686";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(531, 28);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(164, 51);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textStatus
            // 
            this.textStatus.FormattingEnabled = true;
            this.textStatus.ItemHeight = 16;
            this.textStatus.Location = new System.Drawing.Point(13, 85);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(626, 260);
            this.textStatus.TabIndex = 6;
            // 
            // serverMsg
            // 
            this.serverMsg.AutoSize = true;
            this.serverMsg.Location = new System.Drawing.Point(-2, 390);
            this.serverMsg.Name = "serverMsg";
            this.serverMsg.Size = new System.Drawing.Size(0, 17);
            this.serverMsg.TabIndex = 7;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(13, 366);
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(551, 22);
            this.textMsg.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(587, 355);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 45);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 421);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.serverMsg);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textServerPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textServerHost);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textServerHost;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textServerPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox textStatus;
        private System.Windows.Forms.Label serverMsg;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button btnSend;
    }
}

