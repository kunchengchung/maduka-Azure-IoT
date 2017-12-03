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
            this.plSplit = new System.Windows.Forms.Panel();
            this.txtCallMethodReturnValue = new System.Windows.Forms.TextBox();
            this.lblCallMethod = new System.Windows.Forms.Label();
            this.btnRegistryMethod = new System.Windows.Forms.Button();
            this.lblMethodName = new System.Windows.Forms.Label();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.lblIoTSendValue = new System.Windows.Forms.Label();
            this.txtIoTSentValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistry
            // 
            this.btnRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistry.Location = new System.Drawing.Point(573, 10);
            this.btnRegistry.Name = "btnRegistry";
            this.btnRegistry.Size = new System.Drawing.Size(86, 23);
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
            this.txtDeviceId.Size = new System.Drawing.Size(494, 22);
            this.txtDeviceId.TabIndex = 1;
            this.txtDeviceId.Text = "DemoDevice";
            // 
            // txtDeviceKey
            // 
            this.txtDeviceKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceKey.Location = new System.Drawing.Point(77, 40);
            this.txtDeviceKey.Name = "txtDeviceKey";
            this.txtDeviceKey.ReadOnly = true;
            this.txtDeviceKey.Size = new System.Drawing.Size(494, 22);
            this.txtDeviceKey.TabIndex = 2;
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(21, 15);
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
            this.btnUnregistry.Location = new System.Drawing.Point(573, 40);
            this.btnUnregistry.Name = "btnUnregistry";
            this.btnUnregistry.Size = new System.Drawing.Size(86, 23);
            this.btnUnregistry.TabIndex = 0;
            this.btnUnregistry.Text = "Unregistry";
            this.btnUnregistry.UseVisualStyleBackColor = true;
            this.btnUnregistry.Click += new System.EventHandler(this.btnUnregistry_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(27, 102);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(44, 12);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMessage.Location = new System.Drawing.Point(77, 102);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(494, 191);
            this.txtMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(573, 170);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReceiveMessage
            // 
            this.btnReceiveMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceiveMessage.Location = new System.Drawing.Point(573, 142);
            this.btnReceiveMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReceiveMessage.Name = "btnReceiveMessage";
            this.btnReceiveMessage.Size = new System.Drawing.Size(86, 23);
            this.btnReceiveMessage.TabIndex = 5;
            this.btnReceiveMessage.Text = "Receive MSG";
            this.btnReceiveMessage.UseVisualStyleBackColor = true;
            this.btnReceiveMessage.Click += new System.EventHandler(this.btnReceiveMessage_Click);
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(12, 75);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(59, 12);
            this.lblUpload.TabIndex = 3;
            this.lblUpload.Text = "Upload File";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(77, 71);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(141, 22);
            this.txtFileName.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(223, 70);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(31, 23);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "(F)";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtBlobName
            // 
            this.txtBlobName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBlobName.Location = new System.Drawing.Point(324, 71);
            this.txtBlobName.Name = "txtBlobName";
            this.txtBlobName.Size = new System.Drawing.Size(247, 22);
            this.txtBlobName.TabIndex = 1;
            // 
            // lblBlobName
            // 
            this.lblBlobName.AutoSize = true;
            this.lblBlobName.Location = new System.Drawing.Point(260, 75);
            this.lblBlobName.Name = "lblBlobName";
            this.lblBlobName.Size = new System.Drawing.Size(58, 12);
            this.lblBlobName.TabIndex = 3;
            this.lblBlobName.Text = "Blob Name";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadFile.Location = new System.Drawing.Point(573, 70);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(86, 23);
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
            this.btnSendAndStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendAndStop.Location = new System.Drawing.Point(573, 198);
            this.btnSendAndStop.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSendAndStop.Name = "btnSendAndStop";
            this.btnSendAndStop.Size = new System.Drawing.Size(86, 50);
            this.btnSendAndStop.TabIndex = 6;
            this.btnSendAndStop.Text = "Send with timer";
            this.btnSendAndStop.UseVisualStyleBackColor = true;
            this.btnSendAndStop.Click += new System.EventHandler(this.btnSendAndStop_Click);
            // 
            // rbnIoTHub
            // 
            this.rbnIoTHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnIoTHub.Checked = true;
            this.rbnIoTHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbnIoTHub.Location = new System.Drawing.Point(573, 252);
            this.rbnIoTHub.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.rbnIoTHub.Name = "rbnIoTHub";
            this.rbnIoTHub.Size = new System.Drawing.Size(85, 14);
            this.rbnIoTHub.TabIndex = 7;
            this.rbnIoTHub.TabStop = true;
            this.rbnIoTHub.Text = "To IoT Hub";
            this.rbnIoTHub.UseVisualStyleBackColor = true;
            // 
            // rbnWebGateway
            // 
            this.rbnWebGateway.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnWebGateway.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbnWebGateway.Location = new System.Drawing.Point(573, 269);
            this.rbnWebGateway.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.rbnWebGateway.Name = "rbnWebGateway";
            this.rbnWebGateway.Size = new System.Drawing.Size(85, 18);
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
            this.lblSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSendMessage.AutoSize = true;
            this.lblSendMessage.Location = new System.Drawing.Point(75, 294);
            this.lblSendMessage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSendMessage.Name = "lblSendMessage";
            this.lblSendMessage.Size = new System.Drawing.Size(87, 12);
            this.lblSendMessage.TabIndex = 8;
            this.lblSendMessage.Text = "[lblSendMessage]";
            // 
            // plSplit
            // 
            this.plSplit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plSplit.Location = new System.Drawing.Point(77, 313);
            this.plSplit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.plSplit.Name = "plSplit";
            this.plSplit.Size = new System.Drawing.Size(591, 4);
            this.plSplit.TabIndex = 9;
            // 
            // txtCallMethodReturnValue
            // 
            this.txtCallMethodReturnValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCallMethodReturnValue.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.txtCallMethodReturnValue.Location = new System.Drawing.Point(324, 374);
            this.txtCallMethodReturnValue.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtCallMethodReturnValue.Multiline = true;
            this.txtCallMethodReturnValue.Name = "txtCallMethodReturnValue";
            this.txtCallMethodReturnValue.Size = new System.Drawing.Size(247, 137);
            this.txtCallMethodReturnValue.TabIndex = 10;
            // 
            // lblCallMethod
            // 
            this.lblCallMethod.AutoSize = true;
            this.lblCallMethod.Location = new System.Drawing.Point(322, 350);
            this.lblCallMethod.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCallMethod.Name = "lblCallMethod";
            this.lblCallMethod.Size = new System.Drawing.Size(128, 12);
            this.lblCallMethod.TabIndex = 11;
            this.lblCallMethod.Text = "Call Method Return Value";
            // 
            // btnRegistryMethod
            // 
            this.btnRegistryMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistryMethod.Location = new System.Drawing.Point(573, 324);
            this.btnRegistryMethod.Name = "btnRegistryMethod";
            this.btnRegistryMethod.Size = new System.Drawing.Size(86, 38);
            this.btnRegistryMethod.TabIndex = 12;
            this.btnRegistryMethod.Text = "Registry Method";
            this.btnRegistryMethod.UseVisualStyleBackColor = true;
            this.btnRegistryMethod.Click += new System.EventHandler(this.btnRegistryMethod_Click);
            // 
            // lblMethodName
            // 
            this.lblMethodName.AutoSize = true;
            this.lblMethodName.Location = new System.Drawing.Point(48, 326);
            this.lblMethodName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMethodName.Name = "lblMethodName";
            this.lblMethodName.Size = new System.Drawing.Size(71, 12);
            this.lblMethodName.TabIndex = 13;
            this.lblMethodName.Text = "Method Name";
            // 
            // txtMethodName
            // 
            this.txtMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMethodName.Location = new System.Drawing.Point(123, 324);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(448, 22);
            this.txtMethodName.TabIndex = 14;
            // 
            // lblIoTSendValue
            // 
            this.lblIoTSendValue.AutoSize = true;
            this.lblIoTSendValue.Location = new System.Drawing.Point(121, 350);
            this.lblIoTSendValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblIoTSendValue.Name = "lblIoTSendValue";
            this.lblIoTSendValue.Size = new System.Drawing.Size(75, 12);
            this.lblIoTSendValue.TabIndex = 15;
            this.lblIoTSendValue.Text = "IoT Sent Value";
            // 
            // txtIoTSentValue
            // 
            this.txtIoTSentValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIoTSentValue.Location = new System.Drawing.Point(123, 374);
            this.txtIoTSentValue.Multiline = true;
            this.txtIoTSentValue.Name = "txtIoTSentValue";
            this.txtIoTSentValue.ReadOnly = true;
            this.txtIoTSentValue.Size = new System.Drawing.Size(191, 137);
            this.txtIoTSentValue.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 522);
            this.Controls.Add(this.txtIoTSentValue);
            this.Controls.Add(this.lblIoTSendValue);
            this.Controls.Add(this.txtMethodName);
            this.Controls.Add(this.lblMethodName);
            this.Controls.Add(this.btnRegistryMethod);
            this.Controls.Add(this.lblCallMethod);
            this.Controls.Add(this.txtCallMethodReturnValue);
            this.Controls.Add(this.plSplit);
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
        private System.Windows.Forms.Panel plSplit;
        private System.Windows.Forms.TextBox txtCallMethodReturnValue;
        private System.Windows.Forms.Label lblCallMethod;
        private System.Windows.Forms.Button btnRegistryMethod;
        private System.Windows.Forms.Label lblMethodName;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Label lblIoTSendValue;
        private System.Windows.Forms.TextBox txtIoTSentValue;
    }
}

