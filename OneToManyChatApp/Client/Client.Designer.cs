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
            this.textName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Textstatus = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblClientmsg = new System.Windows.Forms.Label();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(90, 36);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(329, 22);
            this.textName.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(470, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(188, 56);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Textstatus
            // 
            this.Textstatus.FormattingEnabled = true;
            this.Textstatus.ItemHeight = 16;
            this.Textstatus.Location = new System.Drawing.Point(29, 105);
            this.Textstatus.Name = "Textstatus";
            this.Textstatus.Size = new System.Drawing.Size(629, 228);
            this.Textstatus.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(645, 366);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 49);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblClientmsg
            // 
            this.lblClientmsg.AutoSize = true;
            this.lblClientmsg.Location = new System.Drawing.Point(1, 421);
            this.lblClientmsg.Name = "lblClientmsg";
            this.lblClientmsg.Size = new System.Drawing.Size(0, 17);
            this.lblClientmsg.TabIndex = 6;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(29, 392);
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(572, 22);
            this.textMsg.TabIndex = 7;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.lblClientmsg);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.Textstatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox Textstatus;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblClientmsg;
        private System.Windows.Forms.TextBox textMsg;
    }
}

