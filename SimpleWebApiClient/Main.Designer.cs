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
            this._pictureBoxMain = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this._btnPickImg = new System.Windows.Forms.Button();
            this._listBoxRequestsURIs = new System.Windows.Forms.ListBox();
            this._tbAccessToken = new System.Windows.Forms.TextBox();
            this._tbUsername = new System.Windows.Forms.TextBox();
            this._tbPassword = new System.Windows.Forms.TextBox();
            this._labelAccessToken = new System.Windows.Forms.Label();
            this._labelUsername = new System.Windows.Forms.Label();
            this._labelPassword = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChechLimitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.токенДоступаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GetTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RCNNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HaarCascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адресToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localhostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._tbCurrentRequestURI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._tbResponse = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxMain)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pictureBoxMain
            // 
            this._pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pictureBoxMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._pictureBoxMain.Location = new System.Drawing.Point(3, 3);
            this._pictureBoxMain.Name = "_pictureBoxMain";
            this._pictureBoxMain.Size = new System.Drawing.Size(634, 374);
            this._pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._pictureBoxMain.TabIndex = 1;
            this._pictureBoxMain.TabStop = false;
            // 
            // _btnPickImg
            // 
            this._btnPickImg.Location = new System.Drawing.Point(15, 477);
            this._btnPickImg.Name = "_btnPickImg";
            this._btnPickImg.Size = new System.Drawing.Size(308, 56);
            this._btnPickImg.TabIndex = 0;
            this._btnPickImg.Text = "Выбрать изображение";
            this._btnPickImg.UseVisualStyleBackColor = true;
            this._btnPickImg.Click += new System.EventHandler(this.On_btnPickImg_Click);
            // 
            // _listBoxRequestsURIs
            // 
            this._listBoxRequestsURIs.FormattingEnabled = true;
            this._listBoxRequestsURIs.Location = new System.Drawing.Point(545, 426);
            this._listBoxRequestsURIs.Name = "_listBoxRequestsURIs";
            this._listBoxRequestsURIs.Size = new System.Drawing.Size(369, 108);
            this._listBoxRequestsURIs.TabIndex = 1;
            // 
            // _tbAccessToken
            // 
            this._tbAccessToken.Location = new System.Drawing.Point(655, 85);
            this._tbAccessToken.Name = "_tbAccessToken";
            this._tbAccessToken.Size = new System.Drawing.Size(259, 20);
            this._tbAccessToken.TabIndex = 3;
            this._tbAccessToken.TextChanged += new System.EventHandler(this.On_tbAccessToken_TextChanged);
            // 
            // _tbUsername
            // 
            this._tbUsername.Location = new System.Drawing.Point(655, 46);
            this._tbUsername.Name = "_tbUsername";
            this._tbUsername.Size = new System.Drawing.Size(121, 20);
            this._tbUsername.TabIndex = 4;
            this._tbUsername.TextChanged += new System.EventHandler(this.On_tbUsername_TextChanged);
            // 
            // _tbPassword
            // 
            this._tbPassword.Location = new System.Drawing.Point(793, 46);
            this._tbPassword.Name = "_tbPassword";
            this._tbPassword.Size = new System.Drawing.Size(121, 20);
            this._tbPassword.TabIndex = 5;
            this._tbPassword.TextChanged += new System.EventHandler(this.On_tbPassword_TextChanged);
            // 
            // _labelAccessToken
            // 
            this._labelAccessToken.AutoSize = true;
            this._labelAccessToken.Location = new System.Drawing.Point(655, 69);
            this._labelAccessToken.Name = "_labelAccessToken";
            this._labelAccessToken.Size = new System.Drawing.Size(81, 13);
            this._labelAccessToken.TabIndex = 8;
            this._labelAccessToken.Text = "Токен доступа";
            // 
            // _labelUsername
            // 
            this._labelUsername.AutoSize = true;
            this._labelUsername.Location = new System.Drawing.Point(655, 30);
            this._labelUsername.Name = "_labelUsername";
            this._labelUsername.Size = new System.Drawing.Size(103, 13);
            this._labelUsername.TabIndex = 9;
            this._labelUsername.Text = "Имя пользователя";
            // 
            // _labelPassword
            // 
            this._labelPassword.AutoSize = true;
            this._labelPassword.Location = new System.Drawing.Point(790, 30);
            this._labelPassword.Name = "_labelPassword";
            this._labelPassword.Size = new System.Drawing.Size(45, 13);
            this._labelPassword.TabIndex = 10;
            this._labelPassword.Text = "Пароль";
            this._labelPassword.Click += new System.EventHandler(this._labelPassword_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._pictureBoxMain, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 380);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.AccountToolStripMenuItem,
            this.LocalizationToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusToolStripMenuItem});
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.SystemToolStripMenuItem.Text = "Система";
            // 
            // StatusToolStripMenuItem
            // 
            this.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem";
            this.StatusToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.StatusToolStripMenuItem.Text = "Статус";
            this.StatusToolStripMenuItem.Click += new System.EventHandler(this.StatusToolStripMenuItem_Click);
            // 
            // AccountToolStripMenuItem
            // 
            this.AccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аккаунтToolStripMenuItem,
            this.токенДоступаToolStripMenuItem});
            this.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem";
            this.AccountToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.AccountToolStripMenuItem.Text = "Пользователь";
            // 
            // аккаунтToolStripMenuItem
            // 
            this.аккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewAccountToolStripMenuItem,
            this.ChechLimitsToolStripMenuItem});
            this.аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            this.аккаунтToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.аккаунтToolStripMenuItem.Text = "Аккаунт";
            // 
            // NewAccountToolStripMenuItem
            // 
            this.NewAccountToolStripMenuItem.Name = "NewAccountToolStripMenuItem";
            this.NewAccountToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.NewAccountToolStripMenuItem.Text = "Создать новый";
            this.NewAccountToolStripMenuItem.Click += new System.EventHandler(this.NewAccountToolStripMenuItem_Click);
            // 
            // ChechLimitsToolStripMenuItem
            // 
            this.ChechLimitsToolStripMenuItem.Name = "ChechLimitsToolStripMenuItem";
            this.ChechLimitsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ChechLimitsToolStripMenuItem.Text = "Проверить ограничения";
            this.ChechLimitsToolStripMenuItem.Click += new System.EventHandler(this.CheckLimitsToolStripMenuItem_Click);
            // 
            // токенДоступаToolStripMenuItem
            // 
            this.токенДоступаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetTokenToolStripMenuItem,
            this.RefreshTokenToolStripMenuItem});
            this.токенДоступаToolStripMenuItem.Name = "токенДоступаToolStripMenuItem";
            this.токенДоступаToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.токенДоступаToolStripMenuItem.Text = "Токен доступа";
            // 
            // GetTokenToolStripMenuItem
            // 
            this.GetTokenToolStripMenuItem.Name = "GetTokenToolStripMenuItem";
            this.GetTokenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.GetTokenToolStripMenuItem.Text = "Получить токен";
            this.GetTokenToolStripMenuItem.Click += new System.EventHandler(this.GetTokenToolStripMenuItem_Click);
            // 
            // RefreshTokenToolStripMenuItem
            // 
            this.RefreshTokenToolStripMenuItem.Name = "RefreshTokenToolStripMenuItem";
            this.RefreshTokenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.RefreshTokenToolStripMenuItem.Text = "Обновить токен";
            this.RefreshTokenToolStripMenuItem.Click += new System.EventHandler(this.RefreshTokenToolStripMenuItem_Click);
            // 
            // LocalizationToolStripMenuItem
            // 
            this.LocalizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RCNNToolStripMenuItem,
            this.HaarCascadeToolStripMenuItem});
            this.LocalizationToolStripMenuItem.Name = "LocalizationToolStripMenuItem";
            this.LocalizationToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.LocalizationToolStripMenuItem.Text = "Локализация";
            // 
            // RCNNToolStripMenuItem
            // 
            this.RCNNToolStripMenuItem.Name = "RCNNToolStripMenuItem";
            this.RCNNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RCNNToolStripMenuItem.Text = "Нейросеть";
            this.RCNNToolStripMenuItem.Click += new System.EventHandler(this.RCNNToolStripMenuItem_Click);
            // 
            // HaarCascadeToolStripMenuItem
            // 
            this.HaarCascadeToolStripMenuItem.Name = "HaarCascadeToolStripMenuItem";
            this.HaarCascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HaarCascadeToolStripMenuItem.Text = "Каскад Хаара";
            this.HaarCascadeToolStripMenuItem.Click += new System.EventHandler(this.HaarCascadeToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.протоколToolStripMenuItem,
            this.адресToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // протоколToolStripMenuItem
            // 
            this.протоколToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTTPToolStripMenuItem});
            this.протоколToolStripMenuItem.Name = "протоколToolStripMenuItem";
            this.протоколToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.протоколToolStripMenuItem.Text = "Протокол";
            // 
            // hTTPToolStripMenuItem
            // 
            this.hTTPToolStripMenuItem.Name = "hTTPToolStripMenuItem";
            this.hTTPToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.hTTPToolStripMenuItem.Text = "HTTP";
            this.hTTPToolStripMenuItem.Click += new System.EventHandler(this.hTTPToolStripMenuItem_Click);
            // 
            // адресToolStripMenuItem
            // 
            this.адресToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localhostToolStripMenuItem,
            this.toolStripMenuItem2});
            this.адресToolStripMenuItem.Name = "адресToolStripMenuItem";
            this.адресToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.адресToolStripMenuItem.Text = "Адрес";
            // 
            // localhostToolStripMenuItem
            // 
            this.localhostToolStripMenuItem.Name = "localhostToolStripMenuItem";
            this.localhostToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.localhostToolStripMenuItem.Text = "localhost:8002";
            this.localhostToolStripMenuItem.Click += new System.EventHandler(this.localhostToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem2.Text = "195.239.209.250:8010";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Список URI отправленных запросов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ответ подсистемы";
            // 
            // _tbCurrentRequestURI
            // 
            this._tbCurrentRequestURI.Location = new System.Drawing.Point(655, 136);
            this._tbCurrentRequestURI.Name = "_tbCurrentRequestURI";
            this._tbCurrentRequestURI.Size = new System.Drawing.Size(259, 20);
            this._tbCurrentRequestURI.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "URI совершенного запроса";
            // 
            // _tbResponse
            // 
            this._tbResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbResponse.Location = new System.Drawing.Point(655, 175);
            this._tbResponse.Name = "_tbResponse";
            this._tbResponse.Size = new System.Drawing.Size(259, 232);
            this._tbResponse.TabIndex = 18;
            this._tbResponse.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 545);
            this.Controls.Add(this._tbResponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._tbCurrentRequestURI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._labelPassword);
            this.Controls.Add(this._labelUsername);
            this.Controls.Add(this._labelAccessToken);
            this.Controls.Add(this._tbPassword);
            this.Controls.Add(this._tbUsername);
            this.Controls.Add(this._tbAccessToken);
            this.Controls.Add(this._listBoxRequestsURIs);
            this.Controls.Add(this._btnPickImg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Клиентское приложение для демонстрации работы API";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxMain)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenCvSharp.UserInterface.PictureBoxIpl _pictureBoxMain;
        private System.Windows.Forms.Button _btnPickImg;
        private System.Windows.Forms.ListBox _listBoxRequestsURIs;
        private System.Windows.Forms.TextBox _tbAccessToken;
        private System.Windows.Forms.TextBox _tbUsername;
        private System.Windows.Forms.TextBox _tbPassword;
        private System.Windows.Forms.Label _labelAccessToken;
        private System.Windows.Forms.Label _labelUsername;
        private System.Windows.Forms.Label _labelPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LocalizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RCNNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HaarCascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChechLimitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem токенДоступаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GetTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshTokenToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbCurrentRequestURI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox _tbResponse;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протоколToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адресToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localhostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

