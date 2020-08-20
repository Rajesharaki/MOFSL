namespace Hello
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
            this.Clients_List = new System.Windows.Forms.CheckedListBox();
            this.textStatus = new System.Windows.Forms.ListBox();
            this.serverMsg = new System.Windows.Forms.Label();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.connectionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clients_List
            // 
            this.Clients_List.FormattingEnabled = true;
            this.Clients_List.Location = new System.Drawing.Point(12, 12);
            this.Clients_List.Name = "Clients_List";
            this.Clients_List.Size = new System.Drawing.Size(263, 310);
            this.Clients_List.TabIndex = 0;
            // 
            // textStatus
            // 
            this.textStatus.FormattingEnabled = true;
            this.textStatus.ItemHeight = 16;
            this.textStatus.Location = new System.Drawing.Point(322, 13);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(328, 308);
            this.textStatus.TabIndex = 1;
            // 
            // serverMsg
            // 
            this.serverMsg.AutoSize = true;
            this.serverMsg.Location = new System.Drawing.Point(1, 421);
            this.serverMsg.Name = "serverMsg";
            this.serverMsg.Size = new System.Drawing.Size(0, 17);
            this.serverMsg.TabIndex = 2;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(13, 365);
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(616, 22);
            this.textMsg.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(647, 353);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(114, 47);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(692, 31);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(149, 68);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // connectionlabel
            // 
            this.connectionlabel.AutoSize = true;
            this.connectionlabel.Location = new System.Drawing.Point(582, 421);
            this.connectionlabel.Name = "connectionlabel";
            this.connectionlabel.Size = new System.Drawing.Size(0, 17);
            this.connectionlabel.TabIndex = 6;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.connectionlabel);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.serverMsg);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.Clients_List);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Clients_List;
        private System.Windows.Forms.ListBox textStatus;
        private System.Windows.Forms.Label serverMsg;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label connectionlabel;
    }
}

