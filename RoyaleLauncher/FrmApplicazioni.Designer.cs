namespace RoyaleLauncher
{
    partial class FrmApplicazioni
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApplicazioni));
            this.BtnEsci = new System.Windows.Forms.Button();
            this.PnlToolBar = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnApp6 = new System.Windows.Forms.Button();
            this.BtnApp5 = new System.Windows.Forms.Button();
            this.BtnApp4 = new System.Windows.Forms.Button();
            this.BtnApp3 = new System.Windows.Forms.Button();
            this.BtnApp2 = new System.Windows.Forms.Button();
            this.BtnApp1 = new System.Windows.Forms.Button();
            this.LblDescUsername = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.OfdFileStart = new System.Windows.Forms.OpenFileDialog();
            this.PnlMenu2 = new System.Windows.Forms.Panel();
            this.BtnApp12 = new System.Windows.Forms.Button();
            this.BtnApp11 = new System.Windows.Forms.Button();
            this.BtnApp10 = new System.Windows.Forms.Button();
            this.BtnApp9 = new System.Windows.Forms.Button();
            this.BtnApp8 = new System.Windows.Forms.Button();
            this.BtnApp7 = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.PnlHome = new System.Windows.Forms.Panel();
            this.TmrCheckChiusura = new System.Windows.Forms.Timer(this.components);
            this.TmrCheckUsernameLogo = new System.Windows.Forms.Timer(this.components);
            this.PnlToolBar.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.PnlMenu2.SuspendLayout();
            this.PnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEsci
            // 
            this.BtnEsci.BackColor = System.Drawing.Color.Transparent;
            this.BtnEsci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEsci.Location = new System.Drawing.Point(580, 7);
            this.BtnEsci.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEsci.Name = "BtnEsci";
            this.BtnEsci.Size = new System.Drawing.Size(25, 25);
            this.BtnEsci.TabIndex = 3;
            this.BtnEsci.Text = "X";
            this.BtnEsci.UseVisualStyleBackColor = false;
            this.BtnEsci.Click += new System.EventHandler(this.BtnEsci_Click_1);
            // 
            // PnlToolBar
            // 
            this.PnlToolBar.BackColor = System.Drawing.Color.Transparent;
            this.PnlToolBar.Controls.Add(this.BtnEsci);
            this.PnlToolBar.Location = new System.Drawing.Point(0, 2);
            this.PnlToolBar.Name = "PnlToolBar";
            this.PnlToolBar.Size = new System.Drawing.Size(797, 35);
            this.PnlToolBar.TabIndex = 4;
            this.PnlToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlToolBar_MouseDown);
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlMenu.Controls.Add(this.BtnApp6);
            this.PnlMenu.Controls.Add(this.BtnApp5);
            this.PnlMenu.Controls.Add(this.BtnApp4);
            this.PnlMenu.Controls.Add(this.BtnApp3);
            this.PnlMenu.Controls.Add(this.BtnApp2);
            this.PnlMenu.Controls.Add(this.BtnApp1);
            this.PnlMenu.Location = new System.Drawing.Point(0, -5);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(189, 457);
            this.PnlMenu.TabIndex = 6;
            // 
            // BtnApp6
            // 
            this.BtnApp6.FlatAppearance.BorderSize = 0;
            this.BtnApp6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp6.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp6.Location = new System.Drawing.Point(0, 401);
            this.BtnApp6.Name = "BtnApp6";
            this.BtnApp6.Size = new System.Drawing.Size(189, 42);
            this.BtnApp6.TabIndex = 5;
            this.BtnApp6.Text = "App6";
            this.BtnApp6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp6.UseVisualStyleBackColor = true;
            this.BtnApp6.Click += new System.EventHandler(this.BtnApp6_Click);
            // 
            // BtnApp5
            // 
            this.BtnApp5.FlatAppearance.BorderSize = 0;
            this.BtnApp5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp5.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp5.Location = new System.Drawing.Point(0, 353);
            this.BtnApp5.Name = "BtnApp5";
            this.BtnApp5.Size = new System.Drawing.Size(189, 42);
            this.BtnApp5.TabIndex = 4;
            this.BtnApp5.Text = "App5";
            this.BtnApp5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp5.UseVisualStyleBackColor = true;
            this.BtnApp5.Click += new System.EventHandler(this.BtnApp5_Click);
            // 
            // BtnApp4
            // 
            this.BtnApp4.FlatAppearance.BorderSize = 0;
            this.BtnApp4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp4.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp4.Location = new System.Drawing.Point(0, 305);
            this.BtnApp4.Name = "BtnApp4";
            this.BtnApp4.Size = new System.Drawing.Size(189, 42);
            this.BtnApp4.TabIndex = 3;
            this.BtnApp4.Text = "App4";
            this.BtnApp4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp4.UseVisualStyleBackColor = true;
            this.BtnApp4.Click += new System.EventHandler(this.BtnApp4_Click);
            // 
            // BtnApp3
            // 
            this.BtnApp3.FlatAppearance.BorderSize = 0;
            this.BtnApp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp3.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp3.Location = new System.Drawing.Point(0, 106);
            this.BtnApp3.Name = "BtnApp3";
            this.BtnApp3.Size = new System.Drawing.Size(189, 42);
            this.BtnApp3.TabIndex = 2;
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
            this.BtnApp2.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp2.Location = new System.Drawing.Point(0, 58);
            this.BtnApp2.Name = "BtnApp2";
            this.BtnApp2.Size = new System.Drawing.Size(189, 42);
            this.BtnApp2.TabIndex = 1;
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
            this.BtnApp1.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp1.Location = new System.Drawing.Point(0, 10);
            this.BtnApp1.Name = "BtnApp1";
            this.BtnApp1.Size = new System.Drawing.Size(189, 42);
            this.BtnApp1.TabIndex = 0;
            this.BtnApp1.Text = "App1";
            this.BtnApp1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp1.UseVisualStyleBackColor = true;
            this.BtnApp1.Click += new System.EventHandler(this.BtnApp1_Click);
            // 
            // LblDescUsername
            // 
            this.LblDescUsername.AutoSize = true;
            this.LblDescUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LblDescUsername.Location = new System.Drawing.Point(134, 103);
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
            this.LblUsername.Location = new System.Drawing.Point(99, 80);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(115, 23);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "User";
            this.LblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PcbLogo
            // 
            this.PcbLogo.Location = new System.Drawing.Point(102, 3);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(100, 74);
            this.PcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbLogo.TabIndex = 0;
            this.PcbLogo.TabStop = false;
            // 
            // OfdFileStart
            // 
            this.OfdFileStart.FileName = "Seleziona File .EXE oppure URL";
            // 
            // PnlMenu2
            // 
            this.PnlMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlMenu2.Controls.Add(this.BtnApp12);
            this.PnlMenu2.Controls.Add(this.BtnApp11);
            this.PnlMenu2.Controls.Add(this.BtnApp10);
            this.PnlMenu2.Controls.Add(this.BtnApp9);
            this.PnlMenu2.Controls.Add(this.BtnApp8);
            this.PnlMenu2.Controls.Add(this.BtnApp7);
            this.PnlMenu2.Location = new System.Drawing.Point(608, 2);
            this.PnlMenu2.Name = "PnlMenu2";
            this.PnlMenu2.Size = new System.Drawing.Size(189, 457);
            this.PnlMenu2.TabIndex = 7;
            // 
            // BtnApp12
            // 
            this.BtnApp12.FlatAppearance.BorderSize = 0;
            this.BtnApp12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp12.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp12.Location = new System.Drawing.Point(0, 401);
            this.BtnApp12.Name = "BtnApp12";
            this.BtnApp12.Size = new System.Drawing.Size(189, 42);
            this.BtnApp12.TabIndex = 5;
            this.BtnApp12.Text = "App12";
            this.BtnApp12.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp12.UseVisualStyleBackColor = true;
            this.BtnApp12.Click += new System.EventHandler(this.BtnApp12_Click);
            // 
            // BtnApp11
            // 
            this.BtnApp11.FlatAppearance.BorderSize = 0;
            this.BtnApp11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp11.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp11.Location = new System.Drawing.Point(0, 353);
            this.BtnApp11.Name = "BtnApp11";
            this.BtnApp11.Size = new System.Drawing.Size(189, 42);
            this.BtnApp11.TabIndex = 4;
            this.BtnApp11.Text = "App11";
            this.BtnApp11.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp11.UseVisualStyleBackColor = true;
            this.BtnApp11.Click += new System.EventHandler(this.BtnApp11_Click);
            // 
            // BtnApp10
            // 
            this.BtnApp10.FlatAppearance.BorderSize = 0;
            this.BtnApp10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp10.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp10.Location = new System.Drawing.Point(0, 305);
            this.BtnApp10.Name = "BtnApp10";
            this.BtnApp10.Size = new System.Drawing.Size(189, 42);
            this.BtnApp10.TabIndex = 3;
            this.BtnApp10.Text = "App10";
            this.BtnApp10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp10.UseVisualStyleBackColor = true;
            this.BtnApp10.Click += new System.EventHandler(this.BtnApp10_Click);
            // 
            // BtnApp9
            // 
            this.BtnApp9.FlatAppearance.BorderSize = 0;
            this.BtnApp9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp9.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp9.Location = new System.Drawing.Point(0, 106);
            this.BtnApp9.Name = "BtnApp9";
            this.BtnApp9.Size = new System.Drawing.Size(189, 42);
            this.BtnApp9.TabIndex = 2;
            this.BtnApp9.Text = "App9";
            this.BtnApp9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp9.UseVisualStyleBackColor = true;
            this.BtnApp9.Click += new System.EventHandler(this.BtnApp9_Click);
            // 
            // BtnApp8
            // 
            this.BtnApp8.FlatAppearance.BorderSize = 0;
            this.BtnApp8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp8.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp8.Location = new System.Drawing.Point(0, 58);
            this.BtnApp8.Name = "BtnApp8";
            this.BtnApp8.Size = new System.Drawing.Size(189, 42);
            this.BtnApp8.TabIndex = 1;
            this.BtnApp8.Text = "App8";
            this.BtnApp8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp8.UseVisualStyleBackColor = true;
            this.BtnApp8.Click += new System.EventHandler(this.BtnApp8_Click);
            // 
            // BtnApp7
            // 
            this.BtnApp7.FlatAppearance.BorderSize = 0;
            this.BtnApp7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApp7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApp7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApp7.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnApp7.Location = new System.Drawing.Point(0, 10);
            this.BtnApp7.Name = "BtnApp7";
            this.BtnApp7.Size = new System.Drawing.Size(189, 42);
            this.BtnApp7.TabIndex = 0;
            this.BtnApp7.Text = "App7";
            this.BtnApp7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnApp7.UseVisualStyleBackColor = true;
            this.BtnApp7.Click += new System.EventHandler(this.BtnApp7_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnHome.Image = global::RoyaleLauncher.Properties.Resources.home;
            this.BtnHome.Location = new System.Drawing.Point(59, 118);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(189, 42);
            this.BtnHome.TabIndex = 0;
            this.BtnHome.Text = "Home  ";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PnlHome
            // 
            this.PnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlHome.Controls.Add(this.PcbLogo);
            this.PnlHome.Controls.Add(this.BtnHome);
            this.PnlHome.Controls.Add(this.LblUsername);
            this.PnlHome.Controls.Add(this.LblDescUsername);
            this.PnlHome.Location = new System.Drawing.Point(244, 43);
            this.PnlHome.Name = "PnlHome";
            this.PnlHome.Size = new System.Drawing.Size(316, 187);
            this.PnlHome.TabIndex = 11;
            // 
            // TmrCheckChiusura
            // 
            this.TmrCheckChiusura.Tick += new System.EventHandler(this.TmrCheckChiusura_Tick);
            // 
            // TmrCheckUsernameLogo
            // 
            this.TmrCheckUsernameLogo.Tick += new System.EventHandler(this.TmrCheckUsernameLogo_Tick);
            // 
            // FrmApplicazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PnlHome);
            this.Controls.Add(this.PnlMenu2);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmApplicazioni";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoyaleLauncher";
            this.Activated += new System.EventHandler(this.FrmApplicazioni_Activated);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmApplicazioni_VisibleChanged);
            this.PnlToolBar.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.PnlMenu2.ResumeLayout(false);
            this.PnlHome.ResumeLayout(false);
            this.PnlHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEsci;
        private System.Windows.Forms.Panel PnlToolBar;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblDescUsername;
        private System.Windows.Forms.OpenFileDialog OfdFileStart;
        private System.Windows.Forms.Button BtnApp6;
        private System.Windows.Forms.Button BtnApp5;
        private System.Windows.Forms.Button BtnApp4;
        private System.Windows.Forms.Button BtnApp3;
        private System.Windows.Forms.Button BtnApp2;
        private System.Windows.Forms.Button BtnApp1;
        private System.Windows.Forms.Panel PnlMenu2;
        private System.Windows.Forms.Button BtnApp12;
        private System.Windows.Forms.Button BtnApp11;
        private System.Windows.Forms.Button BtnApp10;
        private System.Windows.Forms.Button BtnApp9;
        private System.Windows.Forms.Button BtnApp8;
        private System.Windows.Forms.Button BtnApp7;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel PnlHome;
        private System.Windows.Forms.Timer TmrCheckChiusura;
        private System.Windows.Forms.Timer TmrCheckUsernameLogo;
    }
}

