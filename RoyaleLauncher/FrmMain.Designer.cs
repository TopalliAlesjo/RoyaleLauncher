namespace RoyaleLauncher
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnEsci = new System.Windows.Forms.Button();
            this.PnlToolBar = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnApp4 = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnApp3 = new System.Windows.Forms.Button();
            this.BtnApp2 = new System.Windows.Forms.Button();
            this.BtnApp1 = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.LblDescUsername = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.LblNotificaImage = new System.Windows.Forms.Label();
            this.LblDescSettingsUser = new System.Windows.Forms.Label();
            this.LblDescUscitaAutomatica = new System.Windows.Forms.Label();
            this.LblDescRiordina = new System.Windows.Forms.Label();
            this.LblDescSettingsOrdine1 = new System.Windows.Forms.Label();
            this.LblDescSettingsOrdine2 = new System.Windows.Forms.Label();
            this.LblDescSettingsOrdine3 = new System.Windows.Forms.Label();
            this.LblDescSettingsOrdine4 = new System.Windows.Forms.Label();
            this.BtnSettingDisinstalla = new System.Windows.Forms.Button();
            this.BtnRiordinaApps = new System.Windows.Forms.Button();
            this.BtnFaqUscitaAutomatica = new System.Windows.Forms.Button();
            this.BtnSettingsLogoUsername = new System.Windows.Forms.Button();
            this.BtnRegistraGioco = new System.Windows.Forms.Button();
            this.BtnAvvia = new System.Windows.Forms.Button();
            this.PcbMain = new System.Windows.Forms.PictureBox();
            this.LblDescCambiaTrasparenza = new System.Windows.Forms.Label();
            this.PnlSettingsTrasparenza = new System.Windows.Forms.Panel();
            this.RdbTrasparenzaAttiva = new CustomControls.RJControls.RJRadioButton();
            this.RdbTrasparenzaDisattivata = new CustomControls.RJControls.RJRadioButton();
            this.PnlSettingsUscitaAuto = new System.Windows.Forms.Panel();
            this.RdbUscitaAutomaticaAttivato = new CustomControls.RJControls.RJRadioButton();
            this.RdbUscitaAutomaticaDisattivata = new CustomControls.RJControls.RJRadioButton();
            this.LblDescColoreLauncher = new System.Windows.Forms.Label();
            this.CmbColoreLauncher = new CustomControls.RJControls.RJComboBox();
            this.CmbApp4 = new CustomControls.RJControls.RJComboBox();
            this.CmbApp3 = new CustomControls.RJControls.RJComboBox();
            this.CmbApp2 = new CustomControls.RJControls.RJComboBox();
            this.CmbApp1 = new CustomControls.RJControls.RJComboBox();
            this.PnlToolBar.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMain)).BeginInit();
            this.PnlSettingsTrasparenza.SuspendLayout();
            this.PnlSettingsUscitaAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEsci
            // 
            this.BtnEsci.BackColor = System.Drawing.Color.Transparent;
            this.BtnEsci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEsci.Location = new System.Drawing.Point(766, 7);
            this.BtnEsci.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEsci.Name = "BtnEsci";
            this.BtnEsci.Size = new System.Drawing.Size(25, 25);
            this.BtnEsci.TabIndex = 3;
            this.BtnEsci.Text = "X";
            this.BtnEsci.UseVisualStyleBackColor = false;
            this.BtnEsci.Click += new System.EventHandler(this.BtnEsci_Click);
            // 
            // PnlToolBar
            // 
            this.PnlToolBar.BackColor = System.Drawing.Color.Transparent;
            this.PnlToolBar.Controls.Add(this.BtnEsci);
            this.PnlToolBar.Location = new System.Drawing.Point(0, 2);
            this.PnlToolBar.Name = "PnlToolBar";
            this.PnlToolBar.Size = new System.Drawing.Size(801, 35);
            this.PnlToolBar.TabIndex = 4;
            this.PnlToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlToolBar_MouseDown);
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlMenu.Controls.Add(this.BtnApp4);
            this.PnlMenu.Controls.Add(this.BtnSettings);
            this.PnlMenu.Controls.Add(this.BtnApp3);
            this.PnlMenu.Controls.Add(this.BtnApp2);
            this.PnlMenu.Controls.Add(this.BtnApp1);
            this.PnlMenu.Controls.Add(this.BtnDashboard);
            this.PnlMenu.Controls.Add(this.LblDescUsername);
            this.PnlMenu.Controls.Add(this.LblUsername);
            this.PnlMenu.Controls.Add(this.PcbLogo);
            this.PnlMenu.Location = new System.Drawing.Point(0, -5);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(189, 457);
            this.PnlMenu.TabIndex = 6;
            // 
            // BtnApp4
            // 
            this.BtnApp4.FlatAppearance.BorderSize = 0;
            this.BtnApp4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp4.Location = new System.Drawing.Point(0, 337);
            this.BtnApp4.Name = "BtnApp4";
            this.BtnApp4.Size = new System.Drawing.Size(189, 42);
            this.BtnApp4.TabIndex = 4;
            this.BtnApp4.Text = "App4";
            this.BtnApp4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp4.UseVisualStyleBackColor = true;
            this.BtnApp4.Click += new System.EventHandler(this.BtnApp4_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnSettings.Image = global::RoyaleLauncher.Properties.Resources.settings;
            this.BtnSettings.Location = new System.Drawing.Point(0, 412);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(189, 42);
            this.BtnSettings.TabIndex = 5;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnApp3
            // 
            this.BtnApp3.FlatAppearance.BorderSize = 0;
            this.BtnApp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp3.Location = new System.Drawing.Point(0, 289);
            this.BtnApp3.Name = "BtnApp3";
            this.BtnApp3.Size = new System.Drawing.Size(189, 42);
            this.BtnApp3.TabIndex = 3;
            this.BtnApp3.Text = "App3";
            this.BtnApp3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp3.UseVisualStyleBackColor = true;
            this.BtnApp3.Click += new System.EventHandler(this.BtnApp3_Click);
            // 
            // BtnApp2
            // 
            this.BtnApp2.FlatAppearance.BorderSize = 0;
            this.BtnApp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp2.Location = new System.Drawing.Point(0, 241);
            this.BtnApp2.Name = "BtnApp2";
            this.BtnApp2.Size = new System.Drawing.Size(189, 42);
            this.BtnApp2.TabIndex = 2;
            this.BtnApp2.Text = "App2";
            this.BtnApp2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp2.UseVisualStyleBackColor = true;
            this.BtnApp2.Click += new System.EventHandler(this.BtnApp2_Click);
            // 
            // BtnApp1
            // 
            this.BtnApp1.FlatAppearance.BorderSize = 0;
            this.BtnApp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp1.Location = new System.Drawing.Point(0, 193);
            this.BtnApp1.Name = "BtnApp1";
            this.BtnApp1.Size = new System.Drawing.Size(189, 42);
            this.BtnApp1.TabIndex = 1;
            this.BtnApp1.Text = "App1";
            this.BtnApp1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp1.UseVisualStyleBackColor = true;
            this.BtnApp1.Click += new System.EventHandler(this.BtnApp1_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnDashboard.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 145);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(189, 42);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "Home  ";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // LblDescUsername
            // 
            this.LblDescUsername.AutoSize = true;
            this.LblDescUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LblDescUsername.Location = new System.Drawing.Point(76, 117);
            this.LblDescUsername.Name = "LblDescUsername";
            this.LblDescUsername.Size = new System.Drawing.Size(37, 12);
            this.LblDescUsername.TabIndex = 2;
            this.LblDescUsername.Text = "Online";
            // 
            // LblUsername
            // 
            this.LblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblUsername.Location = new System.Drawing.Point(51, 94);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(93, 23);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "User";
            this.LblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PcbLogo
            // 
            this.PcbLogo.Location = new System.Drawing.Point(44, 17);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(100, 74);
            this.PcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbLogo.TabIndex = 0;
            this.PcbLogo.TabStop = false;
            // 
            // LblNotificaImage
            // 
            this.LblNotificaImage.AutoSize = true;
            this.LblNotificaImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNotificaImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LblNotificaImage.Location = new System.Drawing.Point(193, 429);
            this.LblNotificaImage.Name = "LblNotificaImage";
            this.LblNotificaImage.Size = new System.Drawing.Size(464, 12);
            this.LblNotificaImage.TabIndex = 9;
            this.LblNotificaImage.Text = "L\'app in questione non è un .exe e non ha icona, pertanto è stata impostata una d" +
    "a standard\r\n";
            // 
            // LblDescSettingsUser
            // 
            this.LblDescSettingsUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescSettingsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescSettingsUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescSettingsUser.Location = new System.Drawing.Point(192, 40);
            this.LblDescSettingsUser.Name = "LblDescSettingsUser";
            this.LblDescSettingsUser.Size = new System.Drawing.Size(121, 16);
            this.LblDescSettingsUser.TabIndex = 9;
            this.LblDescSettingsUser.Text = "Opzioni Per Utenti:";
            // 
            // LblDescUscitaAutomatica
            // 
            this.LblDescUscitaAutomatica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescUscitaAutomatica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescUscitaAutomatica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescUscitaAutomatica.Location = new System.Drawing.Point(1, 0);
            this.LblDescUscitaAutomatica.Name = "LblDescUscitaAutomatica";
            this.LblDescUscitaAutomatica.Size = new System.Drawing.Size(177, 16);
            this.LblDescUscitaAutomatica.TabIndex = 13;
            this.LblDescUscitaAutomatica.Text = "Uscita Automatica Launcher:";
            // 
            // LblDescRiordina
            // 
            this.LblDescRiordina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescRiordina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescRiordina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescRiordina.Location = new System.Drawing.Point(469, 128);
            this.LblDescRiordina.Name = "LblDescRiordina";
            this.LblDescRiordina.Size = new System.Drawing.Size(121, 16);
            this.LblDescRiordina.TabIndex = 41;
            this.LblDescRiordina.Text = "Ordine Applicazioni:";
            // 
            // LblDescSettingsOrdine1
            // 
            this.LblDescSettingsOrdine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescSettingsOrdine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescSettingsOrdine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescSettingsOrdine1.Location = new System.Drawing.Point(463, 156);
            this.LblDescSettingsOrdine1.Name = "LblDescSettingsOrdine1";
            this.LblDescSettingsOrdine1.Size = new System.Drawing.Size(23, 16);
            this.LblDescSettingsOrdine1.TabIndex = 43;
            this.LblDescSettingsOrdine1.Text = "1*:";
            // 
            // LblDescSettingsOrdine2
            // 
            this.LblDescSettingsOrdine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescSettingsOrdine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescSettingsOrdine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescSettingsOrdine2.Location = new System.Drawing.Point(463, 188);
            this.LblDescSettingsOrdine2.Name = "LblDescSettingsOrdine2";
            this.LblDescSettingsOrdine2.Size = new System.Drawing.Size(23, 16);
            this.LblDescSettingsOrdine2.TabIndex = 44;
            this.LblDescSettingsOrdine2.Text = "2*:";
            // 
            // LblDescSettingsOrdine3
            // 
            this.LblDescSettingsOrdine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescSettingsOrdine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescSettingsOrdine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescSettingsOrdine3.Location = new System.Drawing.Point(463, 219);
            this.LblDescSettingsOrdine3.Name = "LblDescSettingsOrdine3";
            this.LblDescSettingsOrdine3.Size = new System.Drawing.Size(23, 16);
            this.LblDescSettingsOrdine3.TabIndex = 45;
            this.LblDescSettingsOrdine3.Text = "3*:";
            // 
            // LblDescSettingsOrdine4
            // 
            this.LblDescSettingsOrdine4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescSettingsOrdine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescSettingsOrdine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescSettingsOrdine4.Location = new System.Drawing.Point(463, 255);
            this.LblDescSettingsOrdine4.Name = "LblDescSettingsOrdine4";
            this.LblDescSettingsOrdine4.Size = new System.Drawing.Size(23, 16);
            this.LblDescSettingsOrdine4.TabIndex = 46;
            this.LblDescSettingsOrdine4.Text = "4*:";
            // 
            // BtnSettingDisinstalla
            // 
            this.BtnSettingDisinstalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnSettingDisinstalla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettingDisinstalla.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettingDisinstalla.ForeColor = System.Drawing.Color.Red;
            this.BtnSettingDisinstalla.Image = global::RoyaleLauncher.Properties.Resources.warning;
            this.BtnSettingDisinstalla.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSettingDisinstalla.Location = new System.Drawing.Point(469, 378);
            this.BtnSettingDisinstalla.Name = "BtnSettingDisinstalla";
            this.BtnSettingDisinstalla.Size = new System.Drawing.Size(169, 44);
            this.BtnSettingDisinstalla.TabIndex = 9;
            this.BtnSettingDisinstalla.Text = "Disinstalla Launcher";
            this.BtnSettingDisinstalla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettingDisinstalla.UseVisualStyleBackColor = false;
            this.BtnSettingDisinstalla.Click += new System.EventHandler(this.BtnSettingDisinstalla_Click);
            // 
            // BtnRiordinaApps
            // 
            this.BtnRiordinaApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRiordinaApps.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRiordinaApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnRiordinaApps.Image = global::RoyaleLauncher.Properties.Resources.ListApps;
            this.BtnRiordinaApps.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRiordinaApps.Location = new System.Drawing.Point(492, 289);
            this.BtnRiordinaApps.Name = "BtnRiordinaApps";
            this.BtnRiordinaApps.Size = new System.Drawing.Size(144, 44);
            this.BtnRiordinaApps.TabIndex = 5;
            this.BtnRiordinaApps.Text = "Riordina Apps";
            this.BtnRiordinaApps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRiordinaApps.UseVisualStyleBackColor = true;
            this.BtnRiordinaApps.Click += new System.EventHandler(this.BtnRiordinaApps_Click);
            // 
            // BtnFaqUscitaAutomatica
            // 
            this.BtnFaqUscitaAutomatica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnFaqUscitaAutomatica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaqUscitaAutomatica.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFaqUscitaAutomatica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnFaqUscitaAutomatica.Image = global::RoyaleLauncher.Properties.Resources.faq;
            this.BtnFaqUscitaAutomatica.Location = new System.Drawing.Point(390, 373);
            this.BtnFaqUscitaAutomatica.Name = "BtnFaqUscitaAutomatica";
            this.BtnFaqUscitaAutomatica.Size = new System.Drawing.Size(46, 47);
            this.BtnFaqUscitaAutomatica.TabIndex = 8;
            this.BtnFaqUscitaAutomatica.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFaqUscitaAutomatica.UseVisualStyleBackColor = false;
            this.BtnFaqUscitaAutomatica.Click += new System.EventHandler(this.BtnFaqUscitaAutomatica_Click);
            // 
            // BtnSettingsLogoUsername
            // 
            this.BtnSettingsLogoUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettingsLogoUsername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettingsLogoUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnSettingsLogoUsername.Image = global::RoyaleLauncher.Properties.Resources.ospiteX25;
            this.BtnSettingsLogoUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSettingsLogoUsername.Location = new System.Drawing.Point(211, 59);
            this.BtnSettingsLogoUsername.Name = "BtnSettingsLogoUsername";
            this.BtnSettingsLogoUsername.Size = new System.Drawing.Size(194, 44);
            this.BtnSettingsLogoUsername.TabIndex = 0;
            this.BtnSettingsLogoUsername.Text = "Cambia Username/Logo";
            this.BtnSettingsLogoUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettingsLogoUsername.UseVisualStyleBackColor = true;
            this.BtnSettingsLogoUsername.Click += new System.EventHandler(this.BtnSettingsUsername_Click);
            // 
            // BtnRegistraGioco
            // 
            this.BtnRegistraGioco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistraGioco.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistraGioco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnRegistraGioco.Image = global::RoyaleLauncher.Properties.Resources.database;
            this.BtnRegistraGioco.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistraGioco.Location = new System.Drawing.Point(644, 397);
            this.BtnRegistraGioco.Name = "BtnRegistraGioco";
            this.BtnRegistraGioco.Size = new System.Drawing.Size(144, 44);
            this.BtnRegistraGioco.TabIndex = 10;
            this.BtnRegistraGioco.Text = "Registra/Elimina \r\n         APP";
            this.BtnRegistraGioco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistraGioco.UseVisualStyleBackColor = true;
            this.BtnRegistraGioco.Click += new System.EventHandler(this.BtnRegistraGioco_Click);
            // 
            // BtnAvvia
            // 
            this.BtnAvvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAvvia.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvvia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnAvvia.Image = global::RoyaleLauncher.Properties.Resources.Avvia;
            this.BtnAvvia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAvvia.Location = new System.Drawing.Point(697, 345);
            this.BtnAvvia.Name = "BtnAvvia";
            this.BtnAvvia.Size = new System.Drawing.Size(94, 44);
            this.BtnAvvia.TabIndex = 11;
            this.BtnAvvia.Text = "AVVIA";
            this.BtnAvvia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAvvia.UseVisualStyleBackColor = true;
            this.BtnAvvia.Click += new System.EventHandler(this.BtnAvvia_Click);
            // 
            // PcbMain
            // 
            this.PcbMain.Location = new System.Drawing.Point(593, 37);
            this.PcbMain.Name = "PcbMain";
            this.PcbMain.Size = new System.Drawing.Size(613, 296);
            this.PcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbMain.TabIndex = 7;
            this.PcbMain.TabStop = false;
            // 
            // LblDescCambiaTrasparenza
            // 
            this.LblDescCambiaTrasparenza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescCambiaTrasparenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescCambiaTrasparenza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescCambiaTrasparenza.Location = new System.Drawing.Point(1, 0);
            this.LblDescCambiaTrasparenza.Name = "LblDescCambiaTrasparenza";
            this.LblDescCambiaTrasparenza.Size = new System.Drawing.Size(189, 16);
            this.LblDescCambiaTrasparenza.TabIndex = 49;
            this.LblDescCambiaTrasparenza.Text = "Trasparenza dell\'applicazione:";
            // 
            // PnlSettingsTrasparenza
            // 
            this.PnlSettingsTrasparenza.Controls.Add(this.LblDescCambiaTrasparenza);
            this.PnlSettingsTrasparenza.Controls.Add(this.RdbTrasparenzaAttiva);
            this.PnlSettingsTrasparenza.Controls.Add(this.RdbTrasparenzaDisattivata);
            this.PnlSettingsTrasparenza.Location = new System.Drawing.Point(194, 306);
            this.PnlSettingsTrasparenza.Name = "PnlSettingsTrasparenza";
            this.PnlSettingsTrasparenza.Size = new System.Drawing.Size(211, 61);
            this.PnlSettingsTrasparenza.TabIndex = 50;
            // 
            // RdbTrasparenzaAttiva
            // 
            this.RdbTrasparenzaAttiva.AutoSize = true;
            this.RdbTrasparenzaAttiva.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.RdbTrasparenzaAttiva.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.RdbTrasparenzaAttiva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RdbTrasparenzaAttiva.Location = new System.Drawing.Point(31, 19);
            this.RdbTrasparenzaAttiva.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbTrasparenzaAttiva.Name = "RdbTrasparenzaAttiva";
            this.RdbTrasparenzaAttiva.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbTrasparenzaAttiva.Size = new System.Drawing.Size(68, 21);
            this.RdbTrasparenzaAttiva.TabIndex = 47;
            this.RdbTrasparenzaAttiva.TabStop = true;
            this.RdbTrasparenzaAttiva.Text = "Attiva";
            this.RdbTrasparenzaAttiva.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbTrasparenzaAttiva.UseVisualStyleBackColor = true;
            this.RdbTrasparenzaAttiva.CheckedChanged += new System.EventHandler(this.RdbTrasparenzaAttiva_CheckedChanged);
            // 
            // RdbTrasparenzaDisattivata
            // 
            this.RdbTrasparenzaDisattivata.AutoSize = true;
            this.RdbTrasparenzaDisattivata.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.RdbTrasparenzaDisattivata.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbTrasparenzaDisattivata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RdbTrasparenzaDisattivata.Location = new System.Drawing.Point(106, 19);
            this.RdbTrasparenzaDisattivata.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbTrasparenzaDisattivata.Name = "RdbTrasparenzaDisattivata";
            this.RdbTrasparenzaDisattivata.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbTrasparenzaDisattivata.Size = new System.Drawing.Size(83, 21);
            this.RdbTrasparenzaDisattivata.TabIndex = 48;
            this.RdbTrasparenzaDisattivata.TabStop = true;
            this.RdbTrasparenzaDisattivata.Text = "Disattiva";
            this.RdbTrasparenzaDisattivata.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbTrasparenzaDisattivata.UseVisualStyleBackColor = true;
            this.RdbTrasparenzaDisattivata.CheckedChanged += new System.EventHandler(this.RdbTrasparenzaDisattivata_CheckedChanged);
            // 
            // PnlSettingsUscitaAuto
            // 
            this.PnlSettingsUscitaAuto.Controls.Add(this.LblDescUscitaAutomatica);
            this.PnlSettingsUscitaAuto.Controls.Add(this.RdbUscitaAutomaticaAttivato);
            this.PnlSettingsUscitaAuto.Controls.Add(this.RdbUscitaAutomaticaDisattivata);
            this.PnlSettingsUscitaAuto.Location = new System.Drawing.Point(194, 373);
            this.PnlSettingsUscitaAuto.Name = "PnlSettingsUscitaAuto";
            this.PnlSettingsUscitaAuto.Size = new System.Drawing.Size(190, 49);
            this.PnlSettingsUscitaAuto.TabIndex = 51;
            // 
            // RdbUscitaAutomaticaAttivato
            // 
            this.RdbUscitaAutomaticaAttivato.AutoSize = true;
            this.RdbUscitaAutomaticaAttivato.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.RdbUscitaAutomaticaAttivato.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.RdbUscitaAutomaticaAttivato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RdbUscitaAutomaticaAttivato.Location = new System.Drawing.Point(31, 19);
            this.RdbUscitaAutomaticaAttivato.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbUscitaAutomaticaAttivato.Name = "RdbUscitaAutomaticaAttivato";
            this.RdbUscitaAutomaticaAttivato.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbUscitaAutomaticaAttivato.Size = new System.Drawing.Size(68, 21);
            this.RdbUscitaAutomaticaAttivato.TabIndex = 6;
            this.RdbUscitaAutomaticaAttivato.TabStop = true;
            this.RdbUscitaAutomaticaAttivato.Text = "Attiva";
            this.RdbUscitaAutomaticaAttivato.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbUscitaAutomaticaAttivato.UseVisualStyleBackColor = true;
            this.RdbUscitaAutomaticaAttivato.CheckedChanged += new System.EventHandler(this.RdbUscitaAutomaticaAttivato_CheckedChanged);
            // 
            // RdbUscitaAutomaticaDisattivata
            // 
            this.RdbUscitaAutomaticaDisattivata.AutoSize = true;
            this.RdbUscitaAutomaticaDisattivata.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.RdbUscitaAutomaticaDisattivata.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbUscitaAutomaticaDisattivata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RdbUscitaAutomaticaDisattivata.Location = new System.Drawing.Point(106, 19);
            this.RdbUscitaAutomaticaDisattivata.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbUscitaAutomaticaDisattivata.Name = "RdbUscitaAutomaticaDisattivata";
            this.RdbUscitaAutomaticaDisattivata.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbUscitaAutomaticaDisattivata.Size = new System.Drawing.Size(83, 21);
            this.RdbUscitaAutomaticaDisattivata.TabIndex = 7;
            this.RdbUscitaAutomaticaDisattivata.TabStop = true;
            this.RdbUscitaAutomaticaDisattivata.Text = "Disattiva";
            this.RdbUscitaAutomaticaDisattivata.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbUscitaAutomaticaDisattivata.UseVisualStyleBackColor = true;
            this.RdbUscitaAutomaticaDisattivata.CheckedChanged += new System.EventHandler(this.RdbUscitaAutomaticaDisattivata_CheckedChanged);
            // 
            // LblDescColoreLauncher
            // 
            this.LblDescColoreLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescColoreLauncher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescColoreLauncher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescColoreLauncher.Location = new System.Drawing.Point(192, 188);
            this.LblDescColoreLauncher.Name = "LblDescColoreLauncher";
            this.LblDescColoreLauncher.Size = new System.Drawing.Size(121, 16);
            this.LblDescColoreLauncher.TabIndex = 53;
            this.LblDescColoreLauncher.Text = "Colore Launcher:";
            // 
            // CmbColoreLauncher
            // 
            this.CmbColoreLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CmbColoreLauncher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbColoreLauncher.BorderSize = 1;
            this.CmbColoreLauncher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbColoreLauncher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbColoreLauncher.ForeColor = System.Drawing.Color.DimGray;
            this.CmbColoreLauncher.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbColoreLauncher.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmbColoreLauncher.ListTextColor = System.Drawing.Color.DimGray;
            this.CmbColoreLauncher.Location = new System.Drawing.Point(211, 207);
            this.CmbColoreLauncher.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbColoreLauncher.Name = "CmbColoreLauncher";
            this.CmbColoreLauncher.Padding = new System.Windows.Forms.Padding(1);
            this.CmbColoreLauncher.Size = new System.Drawing.Size(200, 30);
            this.CmbColoreLauncher.TabIndex = 52;
            this.CmbColoreLauncher.Texts = "";
            this.CmbColoreLauncher.OnSelectedIndexChanged += new System.EventHandler(this.CmbColoreLauncher_OnSelectedIndexChanged);
            // 
            // CmbApp4
            // 
            this.CmbApp4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CmbApp4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbApp4.BorderSize = 1;
            this.CmbApp4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbApp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbApp4.ForeColor = System.Drawing.Color.DimGray;
            this.CmbApp4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbApp4.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmbApp4.ListTextColor = System.Drawing.Color.DimGray;
            this.CmbApp4.Location = new System.Drawing.Point(492, 255);
            this.CmbApp4.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbApp4.Name = "CmbApp4";
            this.CmbApp4.Padding = new System.Windows.Forms.Padding(1);
            this.CmbApp4.Size = new System.Drawing.Size(299, 30);
            this.CmbApp4.TabIndex = 4;
            this.CmbApp4.Texts = "";
            // 
            // CmbApp3
            // 
            this.CmbApp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CmbApp3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbApp3.BorderSize = 1;
            this.CmbApp3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbApp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbApp3.ForeColor = System.Drawing.Color.DimGray;
            this.CmbApp3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbApp3.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmbApp3.ListTextColor = System.Drawing.Color.DimGray;
            this.CmbApp3.Location = new System.Drawing.Point(492, 219);
            this.CmbApp3.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbApp3.Name = "CmbApp3";
            this.CmbApp3.Padding = new System.Windows.Forms.Padding(1);
            this.CmbApp3.Size = new System.Drawing.Size(299, 30);
            this.CmbApp3.TabIndex = 3;
            this.CmbApp3.Texts = "";
            // 
            // CmbApp2
            // 
            this.CmbApp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CmbApp2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbApp2.BorderSize = 1;
            this.CmbApp2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbApp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbApp2.ForeColor = System.Drawing.Color.DimGray;
            this.CmbApp2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbApp2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmbApp2.ListTextColor = System.Drawing.Color.DimGray;
            this.CmbApp2.Location = new System.Drawing.Point(492, 183);
            this.CmbApp2.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbApp2.Name = "CmbApp2";
            this.CmbApp2.Padding = new System.Windows.Forms.Padding(1);
            this.CmbApp2.Size = new System.Drawing.Size(299, 30);
            this.CmbApp2.TabIndex = 2;
            this.CmbApp2.Texts = "";
            // 
            // CmbApp1
            // 
            this.CmbApp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CmbApp1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbApp1.BorderSize = 1;
            this.CmbApp1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbApp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbApp1.ForeColor = System.Drawing.Color.DimGray;
            this.CmbApp1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbApp1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmbApp1.ListTextColor = System.Drawing.Color.DimGray;
            this.CmbApp1.Location = new System.Drawing.Point(492, 147);
            this.CmbApp1.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbApp1.Name = "CmbApp1";
            this.CmbApp1.Padding = new System.Windows.Forms.Padding(1);
            this.CmbApp1.Size = new System.Drawing.Size(299, 30);
            this.CmbApp1.TabIndex = 1;
            this.CmbApp1.Texts = "";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.LblDescColoreLauncher);
            this.Controls.Add(this.CmbColoreLauncher);
            this.Controls.Add(this.PnlSettingsUscitaAuto);
            this.Controls.Add(this.PnlSettingsTrasparenza);
            this.Controls.Add(this.BtnSettingDisinstalla);
            this.Controls.Add(this.LblDescSettingsOrdine4);
            this.Controls.Add(this.LblDescSettingsOrdine3);
            this.Controls.Add(this.LblDescSettingsOrdine2);
            this.Controls.Add(this.LblDescSettingsOrdine1);
            this.Controls.Add(this.BtnRiordinaApps);
            this.Controls.Add(this.LblDescRiordina);
            this.Controls.Add(this.CmbApp4);
            this.Controls.Add(this.CmbApp3);
            this.Controls.Add(this.CmbApp2);
            this.Controls.Add(this.CmbApp1);
            this.Controls.Add(this.BtnFaqUscitaAutomatica);
            this.Controls.Add(this.LblDescSettingsUser);
            this.Controls.Add(this.BtnSettingsLogoUsername);
            this.Controls.Add(this.LblNotificaImage);
            this.Controls.Add(this.BtnRegistraGioco);
            this.Controls.Add(this.BtnAvvia);
            this.Controls.Add(this.PcbMain);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoyaleLauncher";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PnlToolBar.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbMain)).EndInit();
            this.PnlSettingsTrasparenza.ResumeLayout(false);
            this.PnlSettingsTrasparenza.PerformLayout();
            this.PnlSettingsUscitaAuto.ResumeLayout(false);
            this.PnlSettingsUscitaAuto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEsci;
        private System.Windows.Forms.Panel PnlToolBar;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblDescUsername;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnApp3;
        private System.Windows.Forms.Button BtnApp2;
        private System.Windows.Forms.Button BtnApp1;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.PictureBox PcbMain;
        private System.Windows.Forms.Button BtnAvvia;
        private System.Windows.Forms.Button BtnRegistraGioco;
        private System.Windows.Forms.Button BtnApp4;
        private System.Windows.Forms.Label LblNotificaImage;
        private System.Windows.Forms.Button BtnSettingsLogoUsername;
        private System.Windows.Forms.Label LblDescSettingsUser;
        private CustomControls.RJControls.RJRadioButton RdbUscitaAutomaticaAttivato;
        private CustomControls.RJControls.RJRadioButton RdbUscitaAutomaticaDisattivata;
        private System.Windows.Forms.Label LblDescUscitaAutomatica;
        private System.Windows.Forms.Button BtnFaqUscitaAutomatica;
        private CustomControls.RJControls.RJComboBox CmbApp1;
        private CustomControls.RJControls.RJComboBox CmbApp2;
        private CustomControls.RJControls.RJComboBox CmbApp3;
        private CustomControls.RJControls.RJComboBox CmbApp4;
        private System.Windows.Forms.Label LblDescRiordina;
        private System.Windows.Forms.Button BtnRiordinaApps;
        private System.Windows.Forms.Label LblDescSettingsOrdine1;
        private System.Windows.Forms.Label LblDescSettingsOrdine2;
        private System.Windows.Forms.Label LblDescSettingsOrdine3;
        private System.Windows.Forms.Label LblDescSettingsOrdine4;
        private System.Windows.Forms.Button BtnSettingDisinstalla;
        private System.Windows.Forms.Label LblDescCambiaTrasparenza;
        private CustomControls.RJControls.RJRadioButton RdbTrasparenzaDisattivata;
        private CustomControls.RJControls.RJRadioButton RdbTrasparenzaAttiva;
        private System.Windows.Forms.Panel PnlSettingsTrasparenza;
        private System.Windows.Forms.Panel PnlSettingsUscitaAuto;
        private CustomControls.RJControls.RJComboBox CmbColoreLauncher;
        private System.Windows.Forms.Label LblDescColoreLauncher;
    }
}

