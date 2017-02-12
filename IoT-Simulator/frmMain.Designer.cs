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
            this.btnReceiveMessage = new System.Windows.Forms.Button();
            this.lblUpload = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtBlobName = new System.Windows.Forms.TextBox();
            this.lblBlobName = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnRegistry
            // 
            this.btnRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistry.Location = new System.Drawing.Point(1141, 25);
            this.btnRegistry.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnRegistry.Name = "btnRegistry";
            this.btnRegistry.Size = new System.Drawing.Size(201, 58);
            this.btnRegistry.TabIndex = 0;
            this.btnRegistry.Text = "Registry";
            this.btnRegistry.UseVisualStyleBackColor = true;
            this.btnRegistry.Click += new System.EventHandler(this.btnRegistry_Click);
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceId.Location = new System.Drawing.Point(206, 30);
            this.txtDeviceId.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(914, 43);
            this.txtDeviceId.TabIndex = 1;
            // 
            // txtDeviceKey
            // 
            this.txtDeviceKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceKey.Location = new System.Drawing.Point(206, 100);
            this.txtDeviceKey.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtDeviceKey.Name = "txtDeviceKey";
            this.txtDeviceKey.ReadOnly = true;
            this.txtDeviceKey.Size = new System.Drawing.Size(914, 43);
            this.txtDeviceKey.TabIndex = 2;
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(32, 38);
            this.lblDeviceId.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(125, 30);
            this.lblDeviceId.TabIndex = 3;
            this.lblDeviceId.Text = "Device Id";
            // 
            // lblDeviceKey
            // 
            this.lblDeviceKey.AutoSize = true;
            this.lblDeviceKey.Location = new System.Drawing.Point(32, 108);
            this.lblDeviceKey.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblDeviceKey.Name = "lblDeviceKey";
            this.lblDeviceKey.Size = new System.Drawing.Size(149, 30);
            this.lblDeviceKey.TabIndex = 3;
            this.lblDeviceKey.Text = "Device Key";
            // 
            // btnUnregistry
            // 
            this.btnUnregistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnregistry.Location = new System.Drawing.Point(1141, 100);
            this.btnUnregistry.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnUnregistry.Name = "btnUnregistry";
            this.btnUnregistry.Size = new System.Drawing.Size(201, 58);
            this.btnUnregistry.TabIndex = 0;
            this.btnUnregistry.Text = "Unregistry";
            this.btnUnregistry.UseVisualStyleBackColor = true;
            this.btnUnregistry.Click += new System.EventHandler(this.btnUnregistry_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(56, 256);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(113, 30);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMessage.Location = new System.Drawing.Point(206, 256);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(914, 593);
            this.txtMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(1141, 725);
            this.btnSend.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(201, 58);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSendToWebAPI
            // 
            this.btnSendToWebAPI.Location = new System.Drawing.Point(1141, 798);
            this.btnSendToWebAPI.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnSendToWebAPI.Name = "btnSendToWebAPI";
            this.btnSendToWebAPI.Size = new System.Drawing.Size(201, 58);
            this.btnSendToWebAPI.TabIndex = 4;
            this.btnSendToWebAPI.Text = "To WebAPI";
            this.btnSendToWebAPI.UseVisualStyleBackColor = true;
            this.btnSendToWebAPI.Click += new System.EventHandler(this.btnSendToWebAPI_Click);
            // 
            // btnReceiveMessage
            // 
            this.btnReceiveMessage.Location = new System.Drawing.Point(1141, 656);
            this.btnReceiveMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReceiveMessage.Name = "btnReceiveMessage";
            this.btnReceiveMessage.Size = new System.Drawing.Size(201, 58);
            this.btnReceiveMessage.TabIndex = 5;
            this.btnReceiveMessage.Text = "Receive MSG";
            this.btnReceiveMessage.UseVisualStyleBackColor = true;
            this.btnReceiveMessage.Click += new System.EventHandler(this.btnReceiveMessage_Click);
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(56, 181);
            this.lblUpload.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(149, 30);
            this.lblUpload.TabIndex = 3;
            this.lblUpload.Text = "Upload File";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(206, 178);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(369, 43);
            this.txtFileName.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Location = new System.Drawing.Point(593, 167);
            this.btnFile.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(83, 58);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "(F)";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtBlobName
            // 
            this.txtBlobName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBlobName.Location = new System.Drawing.Point(841, 178);
            this.txtBlobName.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.txtBlobName.Name = "txtBlobName";
            this.txtBlobName.Size = new System.Drawing.Size(279, 43);
            this.txtBlobName.TabIndex = 1;
            // 
            // lblBlobName
            // 
            this.lblBlobName.AutoSize = true;
            this.lblBlobName.Location = new System.Drawing.Point(694, 181);
            this.lblBlobName.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblBlobName.Name = "lblBlobName";
            this.lblBlobName.Size = new System.Drawing.Size(144, 30);
            this.lblBlobName.TabIndex = 3;
            this.lblBlobName.Text = "Blob Name";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadFile.Location = new System.Drawing.Point(1138, 174);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(201, 58);
            this.btnUploadFile.TabIndex = 0;
            this.btnUploadFile.Text = "Upload";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 885);
            this.Controls.Add(this.btnReceiveMessage);
            this.Controls.Add(this.btnSendToWebAPI);
            this.Controls.Add(this.lblBlobName);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblDeviceKey);
            this.Controls.Add(this.lblDeviceId);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtDeviceKey);
            this.Controls.Add(this.txtBlobName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.btnUnregistry);
            this.Controls.Add(this.btnRegistry);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
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
        private System.Windows.Forms.Button btnReceiveMessage;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtBlobName;
        private System.Windows.Forms.Label lblBlobName;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

