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
            this.components = new System.ComponentModel.Container();
            this.btnRegistry = new System.Windows.Forms.Button();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.txtDeviceKey = new System.Windows.Forms.TextBox();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.lblDeviceKey = new System.Windows.Forms.Label();
            this.btnUnregistry = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReceiveMessage = new System.Windows.Forms.Button();
            this.lblUpload = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtBlobName = new System.Windows.Forms.TextBox();
            this.lblBlobName = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSendAndStop = new System.Windows.Forms.Button();
            this.rbnIoTHub = new System.Windows.Forms.RadioButton();
            this.rbnWebGateway = new System.Windows.Forms.RadioButton();
            this.tiSend = new System.Windows.Forms.Timer(this.components);
            this.lblSendMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistry
            // 
            this.btnRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistry.Location = new System.Drawing.Point(1121, 20);
            this.btnRegistry.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRegistry.Name = "btnRegistry";
            this.btnRegistry.Size = new System.Drawing.Size(187, 46);
            this.btnRegistry.TabIndex = 0;
            this.btnRegistry.Text = "Registry";
            this.btnRegistry.UseVisualStyleBackColor = true;
            this.btnRegistry.Click += new System.EventHandler(this.btnRegistry_Click);
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceId.Location = new System.Drawing.Point(167, 24);
            this.txtDeviceId.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(944, 36);
            this.txtDeviceId.TabIndex = 1;
            // 
            // txtDeviceKey
            // 
            this.txtDeviceKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceKey.Location = new System.Drawing.Point(167, 80);
            this.txtDeviceKey.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDeviceKey.Name = "txtDeviceKey";
            this.txtDeviceKey.ReadOnly = true;
            this.txtDeviceKey.Size = new System.Drawing.Size(944, 36);
            this.txtDeviceKey.TabIndex = 2;
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(46, 30);
            this.lblDeviceId.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(98, 24);
            this.lblDeviceId.TabIndex = 3;
            this.lblDeviceId.Text = "Device Id";
            // 
            // lblDeviceKey
            // 
            this.lblDeviceKey.AutoSize = true;
            this.lblDeviceKey.Location = new System.Drawing.Point(26, 86);
            this.lblDeviceKey.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDeviceKey.Name = "lblDeviceKey";
            this.lblDeviceKey.Size = new System.Drawing.Size(116, 24);
            this.lblDeviceKey.TabIndex = 3;
            this.lblDeviceKey.Text = "Device Key";
            // 
            // btnUnregistry
            // 
            this.btnUnregistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnregistry.Location = new System.Drawing.Point(1121, 80);
            this.btnUnregistry.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnUnregistry.Name = "btnUnregistry";
            this.btnUnregistry.Size = new System.Drawing.Size(187, 46);
            this.btnUnregistry.TabIndex = 0;
            this.btnUnregistry.Text = "Unregistry";
            this.btnUnregistry.UseVisualStyleBackColor = true;
            this.btnUnregistry.Click += new System.EventHandler(this.btnUnregistry_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(59, 204);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(89, 24);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMessage.Location = new System.Drawing.Point(167, 204);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(944, 528);
            this.txtMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(1121, 536);
            this.btnSend.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(189, 46);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceiveMessage
            // 
            this.btnReceiveMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceiveMessage.Location = new System.Drawing.Point(1121, 480);
            this.btnReceiveMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReceiveMessage.Name = "btnReceiveMessage";
            this.btnReceiveMessage.Size = new System.Drawing.Size(189, 46);
            this.btnReceiveMessage.TabIndex = 5;
            this.btnReceiveMessage.Text = "Receive MSG";
            this.btnReceiveMessage.UseVisualStyleBackColor = true;
            this.btnReceiveMessage.Click += new System.EventHandler(this.btnReceiveMessage_Click);
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(26, 150);
            this.lblUpload.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(116, 24);
            this.lblUpload.TabIndex = 3;
            this.lblUpload.Text = "Upload File";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(167, 142);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(301, 36);
            this.txtFileName.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(483, 140);
            this.btnFile.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(67, 46);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "(F)";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtBlobName
            // 
            this.txtBlobName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBlobName.Location = new System.Drawing.Point(702, 142);
            this.txtBlobName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtBlobName.Name = "txtBlobName";
            this.txtBlobName.Size = new System.Drawing.Size(409, 36);
            this.txtBlobName.TabIndex = 1;
            // 
            // lblBlobName
            // 
            this.lblBlobName.AutoSize = true;
            this.lblBlobName.Location = new System.Drawing.Point(563, 150);
            this.lblBlobName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBlobName.Name = "lblBlobName";
            this.lblBlobName.Size = new System.Drawing.Size(113, 24);
            this.lblBlobName.TabIndex = 3;
            this.lblBlobName.Text = "Blob Name";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadFile.Location = new System.Drawing.Point(1121, 140);
            this.btnUploadFile.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(185, 46);
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
            // btnSendAndStop
            // 
            this.btnSendAndStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendAndStop.Location = new System.Drawing.Point(1121, 591);
            this.btnSendAndStop.Name = "btnSendAndStop";
            this.btnSendAndStop.Size = new System.Drawing.Size(189, 102);
            this.btnSendAndStop.TabIndex = 6;
            this.btnSendAndStop.Text = "Send with timer";
            this.btnSendAndStop.UseVisualStyleBackColor = true;
            this.btnSendAndStop.Click += new System.EventHandler(this.btnSendAndStop_Click);
            // 
            // rbnIoTHub
            // 
            this.rbnIoTHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnIoTHub.Checked = true;
            this.rbnIoTHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbnIoTHub.Location = new System.Drawing.Point(1121, 699);
            this.rbnIoTHub.Name = "rbnIoTHub";
            this.rbnIoTHub.Size = new System.Drawing.Size(185, 29);
            this.rbnIoTHub.TabIndex = 7;
            this.rbnIoTHub.TabStop = true;
            this.rbnIoTHub.Text = "To IoT Hub";
            this.rbnIoTHub.UseVisualStyleBackColor = true;
            // 
            // rbnWebGateway
            // 
            this.rbnWebGateway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnWebGateway.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbnWebGateway.Location = new System.Drawing.Point(1121, 734);
            this.rbnWebGateway.Name = "rbnWebGateway";
            this.rbnWebGateway.Size = new System.Drawing.Size(185, 37);
            this.rbnWebGateway.TabIndex = 7;
            this.rbnWebGateway.Text = "To WebAPI";
            this.rbnWebGateway.UseVisualStyleBackColor = true;
            // 
            // tiSend
            // 
            this.tiSend.Interval = 60000;
            this.tiSend.Tick += new System.EventHandler(this.tiSend_Tick);
            // 
            // lblSendMessage
            // 
            this.lblSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSendMessage.AutoSize = true;
            this.lblSendMessage.Location = new System.Drawing.Point(163, 747);
            this.lblSendMessage.Name = "lblSendMessage";
            this.lblSendMessage.Size = new System.Drawing.Size(173, 24);
            this.lblSendMessage.TabIndex = 8;
            this.lblSendMessage.Text = "[lblSendMessage]";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 790);
            this.Controls.Add(this.lblSendMessage);
            this.Controls.Add(this.rbnWebGateway);
            this.Controls.Add(this.rbnIoTHub);
            this.Controls.Add(this.btnSendAndStop);
            this.Controls.Add(this.btnReceiveMessage);
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
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
        private System.Windows.Forms.Button btnReceiveMessage;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtBlobName;
        private System.Windows.Forms.Label lblBlobName;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSendAndStop;
        private System.Windows.Forms.RadioButton rbnIoTHub;
        private System.Windows.Forms.RadioButton rbnWebGateway;
        private System.Windows.Forms.Timer tiSend;
        private System.Windows.Forms.Label lblSendMessage;
    }
}

