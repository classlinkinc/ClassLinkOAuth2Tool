namespace ClassLink.OAuth2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.redirectUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientSecret = new System.Windows.Forms.TextBox();
            this.getCode = new System.Windows.Forms.Button();
            this.codeWorker = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.getToken = new System.Windows.Forms.Button();
            this.tokenWorker = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endpointBox = new System.Windows.Forms.TextBox();
            this.getTest = new System.Windows.Forms.Button();
            this.userWorker = new System.ComponentModel.BackgroundWorker();
            this.infoGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.infoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // redirectUri
            // 
            this.redirectUri.Location = new System.Drawing.Point(90, 6);
            this.redirectUri.Name = "redirectUri";
            this.redirectUri.Size = new System.Drawing.Size(265, 20);
            this.redirectUri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Redirect URI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client ID:";
            // 
            // clientId
            // 
            this.clientId.Location = new System.Drawing.Point(90, 32);
            this.clientId.Name = "clientId";
            this.clientId.Size = new System.Drawing.Size(265, 20);
            this.clientId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client Secret:";
            // 
            // clientSecret
            // 
            this.clientSecret.Location = new System.Drawing.Point(90, 58);
            this.clientSecret.Name = "clientSecret";
            this.clientSecret.Size = new System.Drawing.Size(265, 20);
            this.clientSecret.TabIndex = 4;
            // 
            // getCode
            // 
            this.getCode.Location = new System.Drawing.Point(361, 82);
            this.getCode.Name = "getCode";
            this.getCode.Size = new System.Drawing.Size(75, 23);
            this.getCode.TabIndex = 6;
            this.getCode.Text = "Get Code";
            this.getCode.UseVisualStyleBackColor = true;
            this.getCode.Click += new System.EventHandler(this.getCode_Click);
            // 
            // codeWorker
            // 
            this.codeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.codeWorker_DoWork);
            this.codeWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.codeWorker_RunComplete);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Code:";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(90, 84);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(265, 20);
            this.code.TabIndex = 7;
            // 
            // getToken
            // 
            this.getToken.Location = new System.Drawing.Point(361, 108);
            this.getToken.Name = "getToken";
            this.getToken.Size = new System.Drawing.Size(75, 23);
            this.getToken.TabIndex = 9;
            this.getToken.Text = "Get Token";
            this.getToken.UseVisualStyleBackColor = true;
            this.getToken.Click += new System.EventHandler(this.getToken_Click);
            // 
            // tokenWorker
            // 
            this.tokenWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.tokenWorker_DoWork);
            this.tokenWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.tokenWorker_RunComplete);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Token:";
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(90, 110);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(265, 20);
            this.tokenBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Endpoint:";
            // 
            // endpointBox
            // 
            this.endpointBox.Location = new System.Drawing.Point(90, 136);
            this.endpointBox.Name = "endpointBox";
            this.endpointBox.Size = new System.Drawing.Size(265, 20);
            this.endpointBox.TabIndex = 12;
            // 
            // getTest
            // 
            this.getTest.Location = new System.Drawing.Point(361, 134);
            this.getTest.Name = "getTest";
            this.getTest.Size = new System.Drawing.Size(75, 23);
            this.getTest.TabIndex = 14;
            this.getTest.Text = "Test Endpoint";
            this.getTest.UseVisualStyleBackColor = true;
            this.getTest.Click += new System.EventHandler(this.getTest_Click);
            // 
            // userWorker
            // 
            this.userWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.userWorker_DoWork);
            this.userWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.userWorker_RunComplete);
            // 
            // infoGridView
            // 
            this.infoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoGridView.Location = new System.Drawing.Point(15, 162);
            this.infoGridView.Name = "infoGridView";
            this.infoGridView.Size = new System.Drawing.Size(415, 259);
            this.infoGridView.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 433);
            this.Controls.Add(this.infoGridView);
            this.Controls.Add(this.getTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endpointBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tokenBox);
            this.Controls.Add(this.getToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.code);
            this.Controls.Add(this.getCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientSecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redirectUri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "ClassLink OAuth 2";
            ((System.ComponentModel.ISupportInitialize)(this.infoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox redirectUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientSecret;
        private System.Windows.Forms.Button getCode;
        private System.ComponentModel.BackgroundWorker codeWorker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Button getToken;
        private System.ComponentModel.BackgroundWorker tokenWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox endpointBox;
        private System.Windows.Forms.Button getTest;
        private System.ComponentModel.BackgroundWorker userWorker;
        private System.Windows.Forms.DataGridView infoGridView;
    }
}

