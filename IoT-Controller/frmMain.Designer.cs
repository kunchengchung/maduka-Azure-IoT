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
            this.txtCallMethod = new System.Windows.Forms.TextBox();
            this.lblCallMethod = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(841, 320);
            this.btnSend.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(200, 58);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(288, 30);
            this.txtConnectionString.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(753, 43);
            this.txtConnectionString.TabIndex = 1;
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(288, 100);
            this.txtDeviceId.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(753, 43);
            this.txtDeviceId.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(288, 170);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(753, 43);
            this.txtMessage.TabIndex = 3;
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Location = new System.Drawing.Point(32, 38);
            this.lblConnectionString.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(221, 30);
            this.lblConnectionString.TabIndex = 4;
            this.lblConnectionString.Text = "Connection String";
            // 
            // lblMessageId
            // 
            this.lblMessageId.AutoSize = true;
            this.lblMessageId.Location = new System.Drawing.Point(155, 178);
            this.lblMessageId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMessageId.Name = "lblMessageId";
            this.lblMessageId.Size = new System.Drawing.Size(113, 30);
            this.lblMessageId.TabIndex = 5;
            this.lblMessageId.Text = "Message";
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(147, 108);
            this.lblDeviceId.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(117, 30);
            this.lblDeviceId.TabIndex = 6;
            this.lblDeviceId.Text = "DeviceId";
            // 
            // txtCallMethod
            // 
            this.txtCallMethod.Location = new System.Drawing.Point(288, 245);
            this.txtCallMethod.Margin = new System.Windows.Forms.Padding(8);
            this.txtCallMethod.Name = "txtCallMethod";
            this.txtCallMethod.Size = new System.Drawing.Size(392, 43);
            this.txtCallMethod.TabIndex = 3;
            // 
            // lblCallMethod
            // 
            this.lblCallMethod.AutoSize = true;
            this.lblCallMethod.Location = new System.Drawing.Point(111, 248);
            this.lblCallMethod.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCallMethod.Name = "lblCallMethod";
            this.lblCallMethod.Size = new System.Drawing.Size(157, 30);
            this.lblCallMethod.TabIndex = 5;
            this.lblCallMethod.Text = "Call Method";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(829, 245);
            this.txtTimeout.Margin = new System.Windows.Forms.Padding(8);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(212, 43);
            this.txtTimeout.TabIndex = 3;
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(696, 248);
            this.lblTimeOut.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(117, 30);
            this.lblTimeOut.TabIndex = 5;
            this.lblTimeOut.Text = "Time out";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 418);
            this.Controls.Add(this.lblDeviceId);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.lblCallMethod);
            this.Controls.Add(this.lblMessageId);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.txtCallMethod);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.btnSend);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
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
        private System.Windows.Forms.TextBox txtCallMethod;
        private System.Windows.Forms.Label lblCallMethod;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label lblTimeOut;
    }
}

