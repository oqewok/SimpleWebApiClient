namespace SimpleWebApiClient
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._tbResponse = new System.Windows.Forms.TextBox();
            this._pictureBoxMain = new System.Windows.Forms.PictureBox();
            this._btnPickImg = new System.Windows.Forms.Button();
            this._btnSendRequest = new System.Windows.Forms.Button();
            this._listBoxAllURI = new System.Windows.Forms.ListBox();
            this._tbAccessToken = new System.Windows.Forms.TextBox();
            this._tbUsername = new System.Windows.Forms.TextBox();
            this._tbPassword = new System.Windows.Forms.TextBox();
            this._labelAccessToken = new System.Windows.Forms.Label();
            this._labelUsername = new System.Windows.Forms.Label();
            this._labelPassword = new System.Windows.Forms.Label();
            this._checkBoxUseAccessToken = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxMain)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tbResponse
            // 
            this._tbResponse.Location = new System.Drawing.Point(658, 12);
            this._tbResponse.Multiline = true;
            this._tbResponse.Name = "_tbResponse";
            this._tbResponse.Size = new System.Drawing.Size(360, 280);
            this._tbResponse.TabIndex = 0;
            // 
            // _pictureBoxMain
            // 
            this._pictureBoxMain.Location = new System.Drawing.Point(3, 3);
            this._pictureBoxMain.Name = "_pictureBoxMain";
            this._pictureBoxMain.Size = new System.Drawing.Size(634, 374);
            this._pictureBoxMain.TabIndex = 1;
            this._pictureBoxMain.TabStop = false;
            // 
            // _btnPickImg
            // 
            this._btnPickImg.Location = new System.Drawing.Point(658, 300);
            this._btnPickImg.Name = "_btnPickImg";
            this._btnPickImg.Size = new System.Drawing.Size(90, 23);
            this._btnPickImg.TabIndex = 0;
            this._btnPickImg.Text = "Pick Image";
            this._btnPickImg.UseVisualStyleBackColor = true;
            this._btnPickImg.Click += new System.EventHandler(this.On_btnPickImg_Click);
            // 
            // _btnSendRequest
            // 
            this._btnSendRequest.Location = new System.Drawing.Point(658, 456);
            this._btnSendRequest.Name = "_btnSendRequest";
            this._btnSendRequest.Size = new System.Drawing.Size(90, 23);
            this._btnSendRequest.TabIndex = 2;
            this._btnSendRequest.Text = "Send Request";
            this._btnSendRequest.UseVisualStyleBackColor = true;
            this._btnSendRequest.Click += new System.EventHandler(this.On_btnSendRequest_Click);
            // 
            // _listBoxAllURI
            // 
            this._listBoxAllURI.FormattingEnabled = true;
            this._listBoxAllURI.Location = new System.Drawing.Point(658, 329);
            this._listBoxAllURI.Name = "_listBoxAllURI";
            this._listBoxAllURI.Size = new System.Drawing.Size(360, 121);
            this._listBoxAllURI.TabIndex = 1;
            // 
            // _tbAccessToken
            // 
            this._tbAccessToken.Location = new System.Drawing.Point(12, 456);
            this._tbAccessToken.Name = "_tbAccessToken";
            this._tbAccessToken.Size = new System.Drawing.Size(640, 20);
            this._tbAccessToken.TabIndex = 3;
            this._tbAccessToken.TextChanged += new System.EventHandler(this.On_tbAccessToken_TextChanged);
            // 
            // _tbUsername
            // 
            this._tbUsername.Location = new System.Drawing.Point(12, 414);
            this._tbUsername.Name = "_tbUsername";
            this._tbUsername.Size = new System.Drawing.Size(311, 20);
            this._tbUsername.TabIndex = 4;
            this._tbUsername.TextChanged += new System.EventHandler(this.On_tbUsername_TextChanged);
            // 
            // _tbPassword
            // 
            this._tbPassword.Location = new System.Drawing.Point(341, 414);
            this._tbPassword.Name = "_tbPassword";
            this._tbPassword.Size = new System.Drawing.Size(311, 20);
            this._tbPassword.TabIndex = 5;
            this._tbPassword.TextChanged += new System.EventHandler(this.On_tbPassword_TextChanged);
            // 
            // _labelAccessToken
            // 
            this._labelAccessToken.AutoSize = true;
            this._labelAccessToken.Location = new System.Drawing.Point(12, 437);
            this._labelAccessToken.Name = "_labelAccessToken";
            this._labelAccessToken.Size = new System.Drawing.Size(76, 13);
            this._labelAccessToken.TabIndex = 8;
            this._labelAccessToken.Text = "Access Token";
            // 
            // _labelUsername
            // 
            this._labelUsername.AutoSize = true;
            this._labelUsername.Location = new System.Drawing.Point(12, 395);
            this._labelUsername.Name = "_labelUsername";
            this._labelUsername.Size = new System.Drawing.Size(55, 13);
            this._labelUsername.TabIndex = 9;
            this._labelUsername.Text = "Username";
            // 
            // _labelPassword
            // 
            this._labelPassword.AutoSize = true;
            this._labelPassword.Location = new System.Drawing.Point(338, 395);
            this._labelPassword.Name = "_labelPassword";
            this._labelPassword.Size = new System.Drawing.Size(53, 13);
            this._labelPassword.TabIndex = 10;
            this._labelPassword.Text = "Password";
            // 
            // _checkBoxUseAccessToken
            // 
            this._checkBoxUseAccessToken.AutoSize = true;
            this._checkBoxUseAccessToken.Location = new System.Drawing.Point(754, 460);
            this._checkBoxUseAccessToken.Name = "_checkBoxUseAccessToken";
            this._checkBoxUseAccessToken.Size = new System.Drawing.Size(164, 17);
            this._checkBoxUseAccessToken.TabIndex = 11;
            this._checkBoxUseAccessToken.Text = "Use access token (Checked)";
            this._checkBoxUseAccessToken.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._pictureBoxMain, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 380);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._checkBoxUseAccessToken);
            this.Controls.Add(this._labelPassword);
            this.Controls.Add(this._labelUsername);
            this.Controls.Add(this._labelAccessToken);
            this.Controls.Add(this._tbPassword);
            this.Controls.Add(this._tbUsername);
            this.Controls.Add(this._tbAccessToken);
            this.Controls.Add(this._listBoxAllURI);
            this.Controls.Add(this._btnSendRequest);
            this.Controls.Add(this._btnPickImg);
            this.Controls.Add(this._tbResponse);
            this.Name = "Main";
            this.Text = "Simple API Client";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxMain)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbResponse;
        private System.Windows.Forms.PictureBox _pictureBoxMain;
        private System.Windows.Forms.Button _btnPickImg;
        private System.Windows.Forms.Button _btnSendRequest;
        private System.Windows.Forms.ListBox _listBoxAllURI;
        private System.Windows.Forms.TextBox _tbAccessToken;
        private System.Windows.Forms.TextBox _tbUsername;
        private System.Windows.Forms.TextBox _tbPassword;
        private System.Windows.Forms.Label _labelAccessToken;
        private System.Windows.Forms.Label _labelUsername;
        private System.Windows.Forms.Label _labelPassword;
        private System.Windows.Forms.CheckBox _checkBoxUseAccessToken;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

