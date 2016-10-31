namespace IoT_Simulator
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
            this.btnRegistry = new System.Windows.Forms.Button();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.txtDeviceKey = new System.Windows.Forms.TextBox();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.lblDeviceKey = new System.Windows.Forms.Label();
            this.btnUnregistry = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnSendToWebAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistry
            // 
            this.btnRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistry.Location = new System.Drawing.Point(428, 10);
            this.btnRegistry.Name = "btnRegistry";
            this.btnRegistry.Size = new System.Drawing.Size(75, 23);
            this.btnRegistry.TabIndex = 0;
            this.btnRegistry.Text = "Registry";
            this.btnRegistry.UseVisualStyleBackColor = true;
            this.btnRegistry.Click += new System.EventHandler(this.btnRegistry_Click);
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceId.Location = new System.Drawing.Point(77, 12);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(345, 22);
            this.txtDeviceId.TabIndex = 1;
            // 
            // txtDeviceKey
            // 
            this.txtDeviceKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceKey.Location = new System.Drawing.Point(77, 40);
            this.txtDeviceKey.Name = "txtDeviceKey";
            this.txtDeviceKey.ReadOnly = true;
            this.txtDeviceKey.Size = new System.Drawing.Size(345, 22);
            this.txtDeviceKey.TabIndex = 2;
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(12, 15);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(50, 12);
            this.lblDeviceId.TabIndex = 3;
            this.lblDeviceId.Text = "Device Id";
            // 
            // lblDeviceKey
            // 
            this.lblDeviceKey.AutoSize = true;
            this.lblDeviceKey.Location = new System.Drawing.Point(12, 43);
            this.lblDeviceKey.Name = "lblDeviceKey";
            this.lblDeviceKey.Size = new System.Drawing.Size(59, 12);
            this.lblDeviceKey.TabIndex = 3;
            this.lblDeviceKey.Text = "Device Key";
            // 
            // btnUnregistry
            // 
            this.btnUnregistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnregistry.Location = new System.Drawing.Point(428, 40);
            this.btnUnregistry.Name = "btnUnregistry";
            this.btnUnregistry.Size = new System.Drawing.Size(75, 23);
            this.btnUnregistry.TabIndex = 0;
            this.btnUnregistry.Text = "Unregistry";
            this.btnUnregistry.UseVisualStyleBackColor = true;
            this.btnUnregistry.Click += new System.EventHandler(this.btnUnregistry_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 71);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(44, 12);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMessage.Location = new System.Drawing.Point(77, 68);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(345, 274);
            this.txtMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(428, 290);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSendToWebAPI
            // 
            this.btnSendToWebAPI.Location = new System.Drawing.Point(428, 319);
            this.btnSendToWebAPI.Name = "btnSendToWebAPI";
            this.btnSendToWebAPI.Size = new System.Drawing.Size(75, 23);
            this.btnSendToWebAPI.TabIndex = 4;
            this.btnSendToWebAPI.Text = "To WebAPI";
            this.btnSendToWebAPI.UseVisualStyleBackColor = true;
            this.btnSendToWebAPI.Click += new System.EventHandler(this.btnSendToWebAPI_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 354);
            this.Controls.Add(this.btnSendToWebAPI);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblDeviceKey);
            this.Controls.Add(this.lblDeviceId);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtDeviceKey);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnUnregistry);
            this.Controls.Add(this.btnRegistry);
            this.Name = "frmMain";
            this.Text = "IoT Device Simulator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistry;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.TextBox txtDeviceKey;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.Label lblDeviceKey;
        private System.Windows.Forms.Button btnUnregistry;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnSendToWebAPI;
    }
}

