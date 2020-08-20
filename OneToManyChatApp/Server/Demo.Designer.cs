namespace Server
{
    partial class Demo
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
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.serverMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clients_List
            // 
            this.Clients_List.FormattingEnabled = true;
            this.Clients_List.Location = new System.Drawing.Point(23, 22);
            this.Clients_List.Name = "Clients_List";
            this.Clients_List.Size = new System.Drawing.Size(290, 310);
            this.Clients_List.TabIndex = 0;
            // 
            // textStatus
            // 
            this.textStatus.FormattingEnabled = true;
            this.textStatus.ItemHeight = 16;
            this.textStatus.Location = new System.Drawing.Point(355, 22);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(376, 308);
            this.textStatus.TabIndex = 1;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(23, 386);
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(582, 22);
            this.textMsg.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(640, 376);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 43);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // serverMsg
            // 
            this.serverMsg.AutoSize = true;
            this.serverMsg.Location = new System.Drawing.Point(23, 428);
            this.serverMsg.Name = "serverMsg";
            this.serverMsg.Size = new System.Drawing.Size(0, 17);
            this.serverMsg.TabIndex = 4;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serverMsg);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.Clients_List);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Clients_List;
        private System.Windows.Forms.ListBox textStatus;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label serverMsg;
    }
}

