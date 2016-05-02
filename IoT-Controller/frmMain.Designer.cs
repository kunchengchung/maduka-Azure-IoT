namespace IoT_Controller
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.lblMessageId = new System.Windows.Forms.Label();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(318, 98);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(108, 12);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(285, 22);
            this.txtConnectionString.TabIndex = 1;
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(108, 40);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(285, 22);
            this.txtDeviceId.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(108, 68);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(285, 22);
            this.txtMessage.TabIndex = 3;
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(12, 15);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(90, 12);
            this.lblConnectionString.TabIndex = 4;
            this.lblConnectionString.Text = "Connection String";
            // 
            // lblMessageId
            // 
            this.lblMessageId.AutoSize = true;
            this.lblMessageId.Location = new System.Drawing.Point(58, 71);
            this.lblMessageId.Name = "lblMessageId";
            this.lblMessageId.Size = new System.Drawing.Size(44, 12);
            this.lblMessageId.TabIndex = 5;
            this.lblMessageId.Text = "Message";
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(55, 43);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(47, 12);
            this.lblDeviceId.TabIndex = 6;
            this.lblDeviceId.Text = "DeviceId";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 132);
            this.Controls.Add(this.lblDeviceId);
            this.Controls.Add(this.lblMessageId);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.btnSend);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.Label lblMessageId;
        private System.Windows.Forms.Label lblDeviceId;
    }
}

