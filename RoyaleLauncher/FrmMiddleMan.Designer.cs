namespace RoyaleLauncher
{
    partial class FrmMiddleMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMiddleMan));
            this.BtnEsci = new System.Windows.Forms.Button();
            this.PnlToolBar = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.LblDescUsername = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.LblDescSettingsUser = new System.Windows.Forms.Label();
            this.LblDescUscitaAutomatica = new System.Windows.Forms.Label();
            this.BtnSettingDisinstalla = new System.Windows.Forms.Button();
            this.BtnFaqUscitaAutomatica = new System.Windows.Forms.Button();
            this.BtnSettingsLogoUsername = new System.Windows.Forms.Button();
            this.BtnRegistraGioco = new System.Windows.Forms.Button();
            this.RdbUscitaAutomaticaDisattivata = new CustomControls.RJControls.RJRadioButton();
            this.RdbUscitaAutomaticaAttivato = new CustomControls.RJControls.RJRadioButton();
            this.LblDescCambiaTrasparenza = new System.Windows.Forms.Label();
            this.RdbTrasparenzaAttiva1 = new CustomControls.RJControls.RJRadioButton();
            this.RdbTrasparenzaDisattivata1 = new CustomControls.RJControls.RJRadioButton();
            this.PnlSettingsTrasparenza = new MyPanel();
            this.PnlSettingsUscitaAuto = new MyPanel();
            this.LblDescColoreLauncher = new System.Windows.Forms.Label();
            this.CmbColoreLauncher = new CustomControls.RJControls.RJComboBox();
            this.PnlToolBar.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.PnlSettingsTrasparenza.SuspendLayout();
            this.PnlSettingsUscitaAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEsci
            // 
            this.BtnEsci.BackColor = System.Drawing.Color.Transparent;
            this.BtnEsci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEsci.Image = global::RoyaleLauncher.Properties.Resources._return;
            this.BtnEsci.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEsci.Location = new System.Drawing.Point(766, 7);
            this.BtnEsci.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEsci.Name = "BtnEsci";
            this.BtnEsci.Size = new System.Drawing.Size(25, 25);
            this.BtnEsci.TabIndex = 3;
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
            this.PnlMenu.Controls.Add(this.BtnSettings);
            this.PnlMenu.Controls.Add(this.BtnDashboard);
            this.PnlMenu.Controls.Add(this.LblDescUsername);
            this.PnlMenu.Controls.Add(this.LblUsername);
            this.PnlMenu.Controls.Add(this.PcbLogo);
            this.PnlMenu.Location = new System.Drawing.Point(0, -5);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(189, 457);
            this.PnlMenu.TabIndex = 6;
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
            this.BtnSettings.TabIndex = 1;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
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
            // LblDescSettingsUser
            // 
            this.LblDescSettingsUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescSettingsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescSettingsUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescSettingsUser.Location = new System.Drawing.Point(195, 293);
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
            this.LblDescUscitaAutomatica.Location = new System.Drawing.Point(8, 0);
            this.LblDescUscitaAutomatica.Name = "LblDescUscitaAutomatica";
            this.LblDescUscitaAutomatica.Size = new System.Drawing.Size(177, 16);
            this.LblDescUscitaAutomatica.TabIndex = 13;
            this.LblDescUscitaAutomatica.Text = "Uscita Automatica Launcher:";
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
            this.BtnSettingDisinstalla.TabIndex = 5;
            this.BtnSettingDisinstalla.Text = "Disinstalla Launcher";
            this.BtnSettingDisinstalla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettingDisinstalla.UseVisualStyleBackColor = false;
            this.BtnSettingDisinstalla.Click += new System.EventHandler(this.BtnSettingDisinstalla_Click);
            // 
            // BtnFaqUscitaAutomatica
            // 
            this.BtnFaqUscitaAutomatica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BtnFaqUscitaAutomatica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaqUscitaAutomatica.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFaqUscitaAutomatica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnFaqUscitaAutomatica.Image = global::RoyaleLauncher.Properties.Resources.faq;
            this.BtnFaqUscitaAutomatica.Location = new System.Drawing.Point(746, 312);
            this.BtnFaqUscitaAutomatica.Name = "BtnFaqUscitaAutomatica";
            this.BtnFaqUscitaAutomatica.Size = new System.Drawing.Size(46, 47);
            this.BtnFaqUscitaAutomatica.TabIndex = 4;
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
            this.BtnSettingsLogoUsername.Location = new System.Drawing.Point(218, 312);
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
            this.BtnRegistraGioco.TabIndex = 3;
            this.BtnRegistraGioco.Text = "Registra/Elimina \r\n         Gioco";
            this.BtnRegistraGioco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistraGioco.UseVisualStyleBackColor = true;
            this.BtnRegistraGioco.Click += new System.EventHandler(this.BtnRegistraGioco_Click);
            // 
            // RdbUscitaAutomaticaDisattivata
            // 
            this.RdbUscitaAutomaticaDisattivata.AutoSize = true;
            this.RdbUscitaAutomaticaDisattivata.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.RdbUscitaAutomaticaDisattivata.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbUscitaAutomaticaDisattivata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RdbUscitaAutomaticaDisattivata.Location = new System.Drawing.Point(101, 19);
            this.RdbUscitaAutomaticaDisattivata.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbUscitaAutomaticaDisattivata.Name = "RdbUscitaAutomaticaDisattivata";
            this.RdbUscitaAutomaticaDisattivata.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbUscitaAutomaticaDisattivata.Size = new System.Drawing.Size(83, 21);
            this.RdbUscitaAutomaticaDisattivata.TabIndex = 2;
            this.RdbUscitaAutomaticaDisattivata.TabStop = true;
            this.RdbUscitaAutomaticaDisattivata.Text = "Disattiva";
            this.RdbUscitaAutomaticaDisattivata.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbUscitaAutomaticaDisattivata.UseVisualStyleBackColor = true;
            this.RdbUscitaAutomaticaDisattivata.CheckedChanged += new System.EventHandler(this.RdbUscitaAutomaticaDisattivata_CheckedChanged);
            // 
            // RdbUscitaAutomaticaAttivato
            // 
            this.RdbUscitaAutomaticaAttivato.AutoSize = true;
            this.RdbUscitaAutomaticaAttivato.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.RdbUscitaAutomaticaAttivato.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.RdbUscitaAutomaticaAttivato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RdbUscitaAutomaticaAttivato.Location = new System.Drawing.Point(26, 19);
            this.RdbUscitaAutomaticaAttivato.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbUscitaAutomaticaAttivato.Name = "RdbUscitaAutomaticaAttivato";
            this.RdbUscitaAutomaticaAttivato.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbUscitaAutomaticaAttivato.Size = new System.Drawing.Size(68, 21);
            this.RdbUscitaAutomaticaAttivato.TabIndex = 1;
            this.RdbUscitaAutomaticaAttivato.TabStop = true;
            this.RdbUscitaAutomaticaAttivato.Text = "Attiva";
            this.RdbUscitaAutomaticaAttivato.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbUscitaAutomaticaAttivato.UseVisualStyleBackColor = true;
            this.RdbUscitaAutomaticaAttivato.CheckedChanged += new System.EventHandler(this.RdbUscitaAutomaticaAttivato_CheckedChanged);
            // 
            // LblDescCambiaTrasparenza
            // 
            this.LblDescCambiaTrasparenza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescCambiaTrasparenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescCambiaTrasparenza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescCambiaTrasparenza.Location = new System.Drawing.Point(8, 0);
            this.LblDescCambiaTrasparenza.Name = "LblDescCambiaTrasparenza";
            this.LblDescCambiaTrasparenza.Size = new System.Drawing.Size(189, 16);
            this.LblDescCambiaTrasparenza.TabIndex = 49;
            this.LblDescCambiaTrasparenza.Text = "Trasparenza dell\'applicazione:";
            // 
            // RdbTrasparenzaAttiva1
            // 
            this.RdbTrasparenzaAttiva1.AutoSize = true;
            this.RdbTrasparenzaAttiva1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.RdbTrasparenzaAttiva1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.RdbTrasparenzaAttiva1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RdbTrasparenzaAttiva1.Location = new System.Drawing.Point(26, 19);
            this.RdbTrasparenzaAttiva1.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbTrasparenzaAttiva1.Name = "RdbTrasparenzaAttiva1";
            this.RdbTrasparenzaAttiva1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbTrasparenzaAttiva1.Size = new System.Drawing.Size(68, 21);
            this.RdbTrasparenzaAttiva1.TabIndex = 47;
            this.RdbTrasparenzaAttiva1.TabStop = true;
            this.RdbTrasparenzaAttiva1.Text = "Attiva";
            this.RdbTrasparenzaAttiva1.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbTrasparenzaAttiva1.UseVisualStyleBackColor = true;
            this.RdbTrasparenzaAttiva1.CheckedChanged += new System.EventHandler(this.RdbTrasparenzaAttiva_CheckedChanged);
            // 
            // RdbTrasparenzaDisattivata1
            // 
            this.RdbTrasparenzaDisattivata1.AutoSize = true;
            this.RdbTrasparenzaDisattivata1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.RdbTrasparenzaDisattivata1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbTrasparenzaDisattivata1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.RdbTrasparenzaDisattivata1.Location = new System.Drawing.Point(101, 19);
            this.RdbTrasparenzaDisattivata1.MinimumSize = new System.Drawing.Size(0, 21);
            this.RdbTrasparenzaDisattivata1.Name = "RdbTrasparenzaDisattivata1";
            this.RdbTrasparenzaDisattivata1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RdbTrasparenzaDisattivata1.Size = new System.Drawing.Size(83, 21);
            this.RdbTrasparenzaDisattivata1.TabIndex = 48;
            this.RdbTrasparenzaDisattivata1.TabStop = true;
            this.RdbTrasparenzaDisattivata1.Text = "Disattiva";
            this.RdbTrasparenzaDisattivata1.UnCheckedColor = System.Drawing.Color.Gray;
            this.RdbTrasparenzaDisattivata1.UseVisualStyleBackColor = true;
            this.RdbTrasparenzaDisattivata1.CheckedChanged += new System.EventHandler(this.RdbTrasparenzaDisattivata_CheckedChanged);
            // 
            // PnlSettingsTrasparenza
            // 
            this.PnlSettingsTrasparenza.Controls.Add(this.LblDescCambiaTrasparenza);
            this.PnlSettingsTrasparenza.Controls.Add(this.RdbTrasparenzaAttiva1);
            this.PnlSettingsTrasparenza.Controls.Add(this.RdbTrasparenzaDisattivata1);
            this.PnlSettingsTrasparenza.Location = new System.Drawing.Point(556, 264);
            this.PnlSettingsTrasparenza.Name = "PnlSettingsTrasparenza";
            this.PnlSettingsTrasparenza.Size = new System.Drawing.Size(185, 42);
            this.PnlSettingsTrasparenza.TabIndex = 53;
            // 
            // PnlSettingsUscitaAuto
            // 
            this.PnlSettingsUscitaAuto.Controls.Add(this.LblDescUscitaAutomatica);
            this.PnlSettingsUscitaAuto.Controls.Add(this.RdbUscitaAutomaticaAttivato);
            this.PnlSettingsUscitaAuto.Controls.Add(this.RdbUscitaAutomaticaDisattivata);
            this.PnlSettingsUscitaAuto.Location = new System.Drawing.Point(556, 312);
            this.PnlSettingsUscitaAuto.Name = "PnlSettingsUscitaAuto";
            this.PnlSettingsUscitaAuto.Size = new System.Drawing.Size(184, 43);
            this.PnlSettingsUscitaAuto.TabIndex = 54;
            // 
            // LblDescColoreLauncher
            // 
            this.LblDescColoreLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescColoreLauncher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescColoreLauncher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescColoreLauncher.Location = new System.Drawing.Point(198, 231);
            this.LblDescColoreLauncher.Name = "LblDescColoreLauncher";
            this.LblDescColoreLauncher.Size = new System.Drawing.Size(121, 16);
            this.LblDescColoreLauncher.TabIndex = 56;
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
            this.CmbColoreLauncher.Location = new System.Drawing.Point(218, 250);
            this.CmbColoreLauncher.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbColoreLauncher.Name = "CmbColoreLauncher";
            this.CmbColoreLauncher.Padding = new System.Windows.Forms.Padding(1);
            this.CmbColoreLauncher.Size = new System.Drawing.Size(200, 30);
            this.CmbColoreLauncher.TabIndex = 55;
            this.CmbColoreLauncher.Texts = "";
            this.CmbColoreLauncher.OnSelectedIndexChanged += new System.EventHandler(this.CmbColoreLauncher_OnSelectedIndexChanged);
            // 
            // FrmMiddleMan
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
            this.Controls.Add(this.BtnFaqUscitaAutomatica);
            this.Controls.Add(this.LblDescSettingsUser);
            this.Controls.Add(this.BtnSettingsLogoUsername);
            this.Controls.Add(this.BtnRegistraGioco);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMiddleMan";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoyaleLauncher";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PnlToolBar.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.PnlSettingsTrasparenza.ResumeLayout(false);
            this.PnlSettingsTrasparenza.PerformLayout();
            this.PnlSettingsUscitaAuto.ResumeLayout(false);
            this.PnlSettingsUscitaAuto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEsci;
        private System.Windows.Forms.Panel PnlToolBar;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblDescUsername;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnRegistraGioco;
        private System.Windows.Forms.Button BtnSettingsLogoUsername;
        private System.Windows.Forms.Label LblDescSettingsUser;
        private CustomControls.RJControls.RJRadioButton RdbUscitaAutomaticaAttivato;
        private CustomControls.RJControls.RJRadioButton RdbUscitaAutomaticaDisattivata;
        private System.Windows.Forms.Label LblDescUscitaAutomatica;
        private System.Windows.Forms.Button BtnFaqUscitaAutomatica;
        private System.Windows.Forms.Button BtnSettingDisinstalla;
        private System.Windows.Forms.Label LblDescCambiaTrasparenza;
        private CustomControls.RJControls.RJRadioButton RdbTrasparenzaAttiva1;
        private CustomControls.RJControls.RJRadioButton RdbTrasparenzaDisattivata1;
        private MyPanel PnlSettingsTrasparenza;
        private MyPanel PnlSettingsUscitaAuto;
        private System.Windows.Forms.Label LblDescColoreLauncher;
        private CustomControls.RJControls.RJComboBox CmbColoreLauncher;
    }
}

