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
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessageId = new System.Windows.Forms.Label();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.txtCallMethod = new System.Windows.Forms.TextBox();
            this.lblCallMethod = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.btnCallMethod = new System.Windows.Forms.Button();
            this.lblPayLoad = new System.Windows.Forms.Label();
            this.txtPayLoad = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtResultStatus = new System.Windows.Forms.TextBox();
            this.txtCallMethodResult = new System.Windows.Forms.TextBox();
            this.lblCallMethodResult = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceId.Location = new System.Drawing.Point(113, 12);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(539, 22);
            this.txtDeviceId.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(113, 40);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(456, 22);
            this.txtMessage.TabIndex = 3;
            // 
            // lblMessageId
            // 
            this.lblMessageId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageId.AutoSize = true;
            this.lblMessageId.Location = new System.Drawing.Point(63, 43);
            this.lblMessageId.Name = "lblMessageId";
            this.lblMessageId.Size = new System.Drawing.Size(44, 12);
            this.lblMessageId.TabIndex = 5;
            this.lblMessageId.Text = "Message";
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(60, 15);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(47, 12);
            this.lblDeviceId.TabIndex = 6;
            this.lblDeviceId.Text = "DeviceId";
            // 
            // txtCallMethod
            // 
            this.txtCallMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCallMethod.Location = new System.Drawing.Point(113, 68);
            this.txtCallMethod.Name = "txtCallMethod";
            this.txtCallMethod.Size = new System.Drawing.Size(317, 22);
            this.txtCallMethod.TabIndex = 3;
            // 
            // lblCallMethod
            // 
            this.lblCallMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCallMethod.AutoSize = true;
            this.lblCallMethod.Location = new System.Drawing.Point(44, 71);
            this.lblCallMethod.Name = "lblCallMethod";
            this.lblCallMethod.Size = new System.Drawing.Size(63, 12);
            this.lblCallMethod.TabIndex = 5;
            this.lblCallMethod.Text = "Call Method";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeout.Location = new System.Drawing.Point(487, 68);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(82, 22);
            this.txtTimeout.TabIndex = 3;
            this.txtTimeout.Text = "30";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(436, 71);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(47, 12);
            this.lblTimeOut.TabIndex = 5;
            this.lblTimeOut.Text = "Time out";
            // 
            // btnCallMethod
            // 
            this.btnCallMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCallMethod.Location = new System.Drawing.Point(577, 300);
            this.btnCallMethod.Name = "btnCallMethod";
            this.btnCallMethod.Size = new System.Drawing.Size(75, 23);
            this.btnCallMethod.TabIndex = 0;
            this.btnCallMethod.Text = "Call Method";
            this.btnCallMethod.UseVisualStyleBackColor = true;
            this.btnCallMethod.Click += new System.EventHandler(this.btnCallMethod_Click);
            // 
            // lblPayLoad
            // 
            this.lblPayLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayLoad.AutoSize = true;
            this.lblPayLoad.Location = new System.Drawing.Point(61, 99);
            this.lblPayLoad.Name = "lblPayLoad";
            this.lblPayLoad.Size = new System.Drawing.Size(46, 12);
            this.lblPayLoad.TabIndex = 5;
            this.lblPayLoad.Text = "PayLoad";
            // 
            // txtPayLoad
            // 
            this.txtPayLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayLoad.Location = new System.Drawing.Point(113, 96);
            this.txtPayLoad.Multiline = true;
            this.txtPayLoad.Name = "txtPayLoad";
            this.txtPayLoad.Size = new System.Drawing.Size(458, 46);
            this.txtPayLoad.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(75, 151);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(32, 12);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // txtResultStatus
            // 
            this.txtResultStatus.Location = new System.Drawing.Point(113, 148);
            this.txtResultStatus.Name = "txtResultStatus";
            this.txtResultStatus.Size = new System.Drawing.Size(95, 22);
            this.txtResultStatus.TabIndex = 9;
            // 
            // txtCallMethodResult
            // 
            this.txtCallMethodResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCallMethodResult.Location = new System.Drawing.Point(113, 176);
            this.txtCallMethodResult.Multiline = true;
            this.txtCallMethodResult.Name = "txtCallMethodResult";
            this.txtCallMethodResult.Size = new System.Drawing.Size(458, 147);
            this.txtCallMethodResult.TabIndex = 10;
            // 
            // lblCallMethodResult
            // 
            this.lblCallMethodResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCallMethodResult.AutoSize = true;
            this.lblCallMethodResult.Location = new System.Drawing.Point(12, 282);
            this.lblCallMethodResult.Name = "lblCallMethodResult";
            this.lblCallMethodResult.Size = new System.Drawing.Size(95, 12);
            this.lblCallMethodResult.TabIndex = 11;
            this.lblCallMethodResult.Text = "Call Method Result";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(577, 40);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 337);
            this.Controls.Add(this.lblCallMethodResult);
            this.Controls.Add(this.txtCallMethodResult);
            this.Controls.Add(this.txtResultStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtPayLoad);
            this.Controls.Add(this.lblDeviceId);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.lblPayLoad);
            this.Controls.Add(this.lblCallMethod);
            this.Controls.Add(this.lblMessageId);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.txtCallMethod);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.btnCallMethod);
            this.Controls.Add(this.btnSend);
            this.Name = "frmMain";
            this.Text = "IoT Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessageId;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.TextBox txtCallMethod;
        private System.Windows.Forms.Label lblCallMethod;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.Button btnCallMethod;
        private System.Windows.Forms.Label lblPayLoad;
        private System.Windows.Forms.TextBox txtPayLoad;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtResultStatus;
        private System.Windows.Forms.TextBox txtCallMethodResult;
        private System.Windows.Forms.Label lblCallMethodResult;
        private System.Windows.Forms.Button btnSend;
    }
}

