using System.Windows.Forms;

namespace SignalRClient
{
    partial class SignalRClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblUser.Location = new System.Drawing.Point(50, 70);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(81, 33);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(153, 70);
            this.txtBoxUser.Multiline = true;
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(340, 33);
            this.txtBoxUser.TabIndex = 5;
            this.txtBoxUser.TextChanged += txtBoxUser_TextChanged;
            // 
            // listBoxChat
            // 
            this.listBoxChat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 15;
            this.listBoxChat.Location = new System.Drawing.Point(153, 197);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(340, 160);
            this.listBoxChat.TabIndex = 6;
            this.listBoxChat.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxChat_DrawItem);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConnect.ForeColor = System.Drawing.Color.Red;
            this.btnConnect.Location = new System.Drawing.Point(533, 70);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(125, 33);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Enabled = false;
            this.btnSendMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSendMessage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSendMessage.Location = new System.Drawing.Point(533, 140);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(125, 34);
            this.btnSendMessage.TabIndex = 8;
            this.btnSendMessage.Text = "SendMessage";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblMessage.Location = new System.Drawing.Point(35, 139);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(96, 33);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.Location = new System.Drawing.Point(153, 140);
            this.txtBoxMessage.Multiline = true;
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(340, 34);
            this.txtBoxMessage.TabIndex = 10;
            this.txtBoxMessage.TextChanged += txtBoxMessage_TextChanged;
            // 
            // SignalRClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.txtBoxMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.lblUser);
            this.Name = "SignalRClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TxtBoxMessage_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void TxtBoxUser_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtBoxMessage;
    }
}

