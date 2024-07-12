namespace RoyaleLauncher
{
    partial class FrmSettingsDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettingsDatabase));
            this.BtnEsci = new System.Windows.Forms.Button();
            this.PnlToolBar = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnLogo = new System.Windows.Forms.Button();
            this.BtnUsername = new System.Windows.Forms.Button();
            this.LblDescUsername = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.OfdFileLogo = new System.Windows.Forms.OpenFileDialog();
            this.PnlLogo = new MyPanel();
            this.BtnApriDialogoFileLogo = new System.Windows.Forms.Button();
            this.LblDescInsLogo = new System.Windows.Forms.Label();
            this.TxtCambiaLogo = new CustomControls.RJControls.RJTextBox();
            this.LblDescCambiaLogo = new System.Windows.Forms.Label();
            this.BtnCambiaLogo = new System.Windows.Forms.Button();
            this.PnlUsername = new MyPanel();
            this.LblDescIns = new System.Windows.Forms.Label();
            this.BtnCambiaUsername = new System.Windows.Forms.Button();
            this.LblDescId = new System.Windows.Forms.Label();
            this.TxtCambiaNome = new CustomControls.RJControls.RJTextBox();
            this.PnlToolBar.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.PnlLogo.SuspendLayout();
            this.PnlUsername.SuspendLayout();
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
            this.PnlToolBar.Size = new System.Drawing.Size(797, 35);
            this.PnlToolBar.TabIndex = 4;
            this.PnlToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlToolBar_MouseDown);
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlMenu.Controls.Add(this.BtnLogo);
            this.PnlMenu.Controls.Add(this.BtnUsername);
            this.PnlMenu.Controls.Add(this.LblDescUsername);
            this.PnlMenu.Controls.Add(this.LblUsername);
            this.PnlMenu.Controls.Add(this.PcbLogo);
            this.PnlMenu.Location = new System.Drawing.Point(0, -5);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(189, 457);
            this.PnlMenu.TabIndex = 6;
            // 
            // BtnLogo
            // 
            this.BtnLogo.FlatAppearance.BorderSize = 0;
            this.BtnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnLogo.Image = global::RoyaleLauncher.Properties.Resources.database;
            this.BtnLogo.Location = new System.Drawing.Point(0, 193);
            this.BtnLogo.Name = "BtnLogo";
            this.BtnLogo.Size = new System.Drawing.Size(189, 42);
            this.BtnLogo.TabIndex = 1;
            this.BtnLogo.Text = "Logo        ";
            this.BtnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnLogo.UseVisualStyleBackColor = true;
            this.BtnLogo.Click += new System.EventHandler(this.BtnLogo_Click);
            // 
            // BtnUsername
            // 
            this.BtnUsername.FlatAppearance.BorderSize = 0;
            this.BtnUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnUsername.Image = global::RoyaleLauncher.Properties.Resources.database;
            this.BtnUsername.Location = new System.Drawing.Point(0, 145);
            this.BtnUsername.Name = "BtnUsername";
            this.BtnUsername.Size = new System.Drawing.Size(189, 42);
            this.BtnUsername.TabIndex = 0;
            this.BtnUsername.Text = "Username";
            this.BtnUsername.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnUsername.UseVisualStyleBackColor = true;
            this.BtnUsername.Click += new System.EventHandler(this.BtnUsername_Click);
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
            // OfdFileLogo
            // 
            this.OfdFileLogo.FileName = "Seleziona il Logo";
            this.OfdFileLogo.SupportMultiDottedExtensions = true;
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlLogo.Controls.Add(this.BtnApriDialogoFileLogo);
            this.PnlLogo.Controls.Add(this.LblDescInsLogo);
            this.PnlLogo.Controls.Add(this.TxtCambiaLogo);
            this.PnlLogo.Controls.Add(this.LblDescCambiaLogo);
            this.PnlLogo.Controls.Add(this.BtnCambiaLogo);
            this.PnlLogo.Location = new System.Drawing.Point(244, 188);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(510, 85);
            this.PnlLogo.TabIndex = 15;
            // 
            // BtnApriDialogoFileLogo
            // 
            this.BtnApriDialogoFileLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApriDialogoFileLogo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApriDialogoFileLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApriDialogoFileLogo.Image = global::RoyaleLauncher.Properties.Resources.Folder;
            this.BtnApriDialogoFileLogo.Location = new System.Drawing.Point(364, 38);
            this.BtnApriDialogoFileLogo.Name = "BtnApriDialogoFileLogo";
            this.BtnApriDialogoFileLogo.Size = new System.Drawing.Size(37, 31);
            this.BtnApriDialogoFileLogo.TabIndex = 0;
            this.BtnApriDialogoFileLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApriDialogoFileLogo.UseVisualStyleBackColor = true;
            this.BtnApriDialogoFileLogo.Click += new System.EventHandler(this.BtnApriDialogoFileLogo_Click);
            // 
            // LblDescInsLogo
            // 
            this.LblDescInsLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescInsLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescInsLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescInsLogo.Location = new System.Drawing.Point(3, 11);
            this.LblDescInsLogo.Name = "LblDescInsLogo";
            this.LblDescInsLogo.Size = new System.Drawing.Size(167, 23);
            this.LblDescInsLogo.TabIndex = 4;
            this.LblDescInsLogo.Text = "Inserisci il nuovo logo:\r\n";
            // 
            // TxtCambiaLogo
            // 
            this.TxtCambiaLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtCambiaLogo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TxtCambiaLogo.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.TxtCambiaLogo.BorderSize = 1;
            this.TxtCambiaLogo.Enabled = false;
            this.TxtCambiaLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCambiaLogo.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCambiaLogo.Location = new System.Drawing.Point(58, 38);
            this.TxtCambiaLogo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCambiaLogo.Multiline = false;
            this.TxtCambiaLogo.Name = "TxtCambiaLogo";
            this.TxtCambiaLogo.Padding = new System.Windows.Forms.Padding(7);
            this.TxtCambiaLogo.PasswordChar = false;
            this.TxtCambiaLogo.Size = new System.Drawing.Size(299, 31);
            this.TxtCambiaLogo.TabIndex = 18;
            this.TxtCambiaLogo.Texts = "Seleziona File";
            this.TxtCambiaLogo.UnderlinedStyle = true;
            // 
            // LblDescCambiaLogo
            // 
            this.LblDescCambiaLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescCambiaLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescCambiaLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescCambiaLogo.Location = new System.Drawing.Point(0, 46);
            this.LblDescCambiaLogo.Name = "LblDescCambiaLogo";
            this.LblDescCambiaLogo.Size = new System.Drawing.Size(51, 19);
            this.LblDescCambiaLogo.TabIndex = 17;
            this.LblDescCambiaLogo.Text = "Logo:";
            // 
            // BtnCambiaLogo
            // 
            this.BtnCambiaLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiaLogo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiaLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnCambiaLogo.Image = global::RoyaleLauncher.Properties.Resources.database;
            this.BtnCambiaLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCambiaLogo.Location = new System.Drawing.Point(405, 38);
            this.BtnCambiaLogo.Name = "BtnCambiaLogo";
            this.BtnCambiaLogo.Size = new System.Drawing.Size(100, 32);
            this.BtnCambiaLogo.TabIndex = 1;
            this.BtnCambiaLogo.Text = "Cambia";
            this.BtnCambiaLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCambiaLogo.UseVisualStyleBackColor = true;
            this.BtnCambiaLogo.Click += new System.EventHandler(this.BtnCambiaLogo_Click);
            // 
            // PnlUsername
            // 
            this.PnlUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlUsername.Controls.Add(this.LblDescIns);
            this.PnlUsername.Controls.Add(this.BtnCambiaUsername);
            this.PnlUsername.Controls.Add(this.LblDescId);
            this.PnlUsername.Controls.Add(this.TxtCambiaNome);
            this.PnlUsername.Location = new System.Drawing.Point(244, 329);
            this.PnlUsername.Name = "PnlUsername";
            this.PnlUsername.Size = new System.Drawing.Size(510, 85);
            this.PnlUsername.TabIndex = 8;
            // 
            // LblDescIns
            // 
            this.LblDescIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescIns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescIns.Location = new System.Drawing.Point(3, 11);
            this.LblDescIns.Name = "LblDescIns";
            this.LblDescIns.Size = new System.Drawing.Size(199, 23);
            this.LblDescIns.TabIndex = 4;
            this.LblDescIns.Text = "Inserisci il nuovo username:\r\n";
            // 
            // BtnCambiaUsername
            // 
            this.BtnCambiaUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiaUsername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiaUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnCambiaUsername.Image = global::RoyaleLauncher.Properties.Resources.database;
            this.BtnCambiaUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCambiaUsername.Location = new System.Drawing.Point(405, 35);
            this.BtnCambiaUsername.Name = "BtnCambiaUsername";
            this.BtnCambiaUsername.Size = new System.Drawing.Size(100, 37);
            this.BtnCambiaUsername.TabIndex = 1;
            this.BtnCambiaUsername.Text = "Cambia";
            this.BtnCambiaUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCambiaUsername.UseVisualStyleBackColor = true;
            this.BtnCambiaUsername.Click += new System.EventHandler(this.BtnCambiaUsername_Click);
            // 
            // LblDescId
            // 
            this.LblDescId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescId.Location = new System.Drawing.Point(7, 46);
            this.LblDescId.Name = "LblDescId";
            this.LblDescId.Size = new System.Drawing.Size(85, 23);
            this.LblDescId.TabIndex = 11;
            this.LblDescId.Text = "Username:";
            // 
            // TxtCambiaNome
            // 
            this.TxtCambiaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtCambiaNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TxtCambiaNome.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.TxtCambiaNome.BorderSize = 1;
            this.TxtCambiaNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCambiaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCambiaNome.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCambiaNome.Location = new System.Drawing.Point(99, 38);
            this.TxtCambiaNome.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCambiaNome.Multiline = false;
            this.TxtCambiaNome.Name = "TxtCambiaNome";
            this.TxtCambiaNome.Padding = new System.Windows.Forms.Padding(7);
            this.TxtCambiaNome.PasswordChar = false;
            this.TxtCambiaNome.Size = new System.Drawing.Size(299, 31);
            this.TxtCambiaNome.TabIndex = 0;
            this.TxtCambiaNome.Texts = "Max 12 Caratteri";
            this.TxtCambiaNome.UnderlinedStyle = true;
            // 
            // FrmSettingsDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PnlLogo);
            this.Controls.Add(this.PnlUsername);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettingsDatabase";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoyaleLauncher";
            this.Load += new System.EventHandler(this.FrmSettingsDatabase_Load);
            this.PnlToolBar.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.PnlLogo.ResumeLayout(false);
            this.PnlUsername.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEsci;
        private System.Windows.Forms.Panel PnlToolBar;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblDescUsername;
        private System.Windows.Forms.Button BtnUsername;
        private System.Windows.Forms.Button BtnCambiaUsername;
        private System.Windows.Forms.Label LblDescIns;
        private System.Windows.Forms.Label LblDescId;
        private CustomControls.RJControls.RJTextBox TxtCambiaNome;
        private MyPanel PnlUsername;
        private System.Windows.Forms.Button BtnLogo;
        private System.Windows.Forms.OpenFileDialog OfdFileLogo;
        private MyPanel PnlLogo;
        private System.Windows.Forms.Label LblDescInsLogo;
        private System.Windows.Forms.Button BtnCambiaLogo;
        private System.Windows.Forms.Button BtnApriDialogoFileLogo;
        private CustomControls.RJControls.RJTextBox TxtCambiaLogo;
        private System.Windows.Forms.Label LblDescCambiaLogo;
    }
}

