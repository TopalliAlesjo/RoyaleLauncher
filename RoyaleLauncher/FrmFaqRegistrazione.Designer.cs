namespace RoyaleLauncher
{
    partial class FrmFaqRegistrazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaqRegistrazione));
            this.BtnEsci = new System.Windows.Forms.Button();
            this.PnlToolBar = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnFaqFotoBackgound = new System.Windows.Forms.Button();
            this.BtnFaqNomeStart = new System.Windows.Forms.Button();
            this.LblDescUsername = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.OfdFileLogo = new System.Windows.Forms.OpenFileDialog();
            this.PnlFaqNomeStart = new MyPanel();
            this.LblDescNomeStart = new System.Windows.Forms.Label();
            this.PcbNome = new System.Windows.Forms.PictureBox();
            this.PnlFaqBackgoundFoto = new MyPanel();
            this.LblDescFotoBackgound = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlToolBar.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.PnlFaqNomeStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbNome)).BeginInit();
            this.PnlFaqBackgoundFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.PnlToolBar.Size = new System.Drawing.Size(797, 35);
            this.PnlToolBar.TabIndex = 4;
            this.PnlToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlToolBar_MouseDown);
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlMenu.Controls.Add(this.BtnFaqFotoBackgound);
            this.PnlMenu.Controls.Add(this.BtnFaqNomeStart);
            this.PnlMenu.Controls.Add(this.LblDescUsername);
            this.PnlMenu.Controls.Add(this.LblUsername);
            this.PnlMenu.Controls.Add(this.PcbLogo);
            this.PnlMenu.Location = new System.Drawing.Point(0, -5);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(189, 457);
            this.PnlMenu.TabIndex = 6;
            // 
            // BtnFaqFotoBackgound
            // 
            this.BtnFaqFotoBackgound.FlatAppearance.BorderSize = 0;
            this.BtnFaqFotoBackgound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaqFotoBackgound.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFaqFotoBackgound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnFaqFotoBackgound.Image = global::RoyaleLauncher.Properties.Resources.faq;
            this.BtnFaqFotoBackgound.Location = new System.Drawing.Point(0, 193);
            this.BtnFaqFotoBackgound.Name = "BtnFaqFotoBackgound";
            this.BtnFaqFotoBackgound.Size = new System.Drawing.Size(189, 42);
            this.BtnFaqFotoBackgound.TabIndex = 1;
            this.BtnFaqFotoBackgound.Text = "Foto Backgound";
            this.BtnFaqFotoBackgound.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFaqFotoBackgound.UseVisualStyleBackColor = true;
            this.BtnFaqFotoBackgound.Click += new System.EventHandler(this.BtnFaqFotoBackgound_Click);
            // 
            // BtnFaqNomeStart
            // 
            this.BtnFaqNomeStart.FlatAppearance.BorderSize = 0;
            this.BtnFaqNomeStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaqNomeStart.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFaqNomeStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnFaqNomeStart.Image = global::RoyaleLauncher.Properties.Resources.faq;
            this.BtnFaqNomeStart.Location = new System.Drawing.Point(0, 145);
            this.BtnFaqNomeStart.Name = "BtnFaqNomeStart";
            this.BtnFaqNomeStart.Size = new System.Drawing.Size(189, 42);
            this.BtnFaqNomeStart.TabIndex = 0;
            this.BtnFaqNomeStart.Text = "Nome/Start         ";
            this.BtnFaqNomeStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFaqNomeStart.UseVisualStyleBackColor = true;
            this.BtnFaqNomeStart.Click += new System.EventHandler(this.BtnFaqNomeStart_Click);
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
            // PnlFaqNomeStart
            // 
            this.PnlFaqNomeStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlFaqNomeStart.Controls.Add(this.LblDescNomeStart);
            this.PnlFaqNomeStart.Controls.Add(this.PcbNome);
            this.PnlFaqNomeStart.Location = new System.Drawing.Point(244, 74);
            this.PnlFaqNomeStart.Name = "PnlFaqNomeStart";
            this.PnlFaqNomeStart.Size = new System.Drawing.Size(510, 156);
            this.PnlFaqNomeStart.TabIndex = 15;
            // 
            // LblDescNomeStart
            // 
            this.LblDescNomeStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescNomeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescNomeStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescNomeStart.Location = new System.Drawing.Point(160, 27);
            this.LblDescNomeStart.Name = "LblDescNomeStart";
            this.LblDescNomeStart.Size = new System.Drawing.Size(347, 125);
            this.LblDescNomeStart.TabIndex = 5;
            this.LblDescNomeStart.Text = "Nome: Come rappresentato nell\'immagine è il nome personalizzato che si da all\'app" +
    " scelta\r\n\r\nStart: Rappresenta l\'applicazione in sè, cioè nello start si sceglie " +
    "l\'app che si vuole aggiungere";
            this.LblDescNomeStart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PcbNome
            // 
            this.PcbNome.Image = global::RoyaleLauncher.Properties.Resources.FaqNome;
            this.PcbNome.Location = new System.Drawing.Point(3, 3);
            this.PcbNome.Name = "PcbNome";
            this.PcbNome.Size = new System.Drawing.Size(151, 149);
            this.PcbNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbNome.TabIndex = 0;
            this.PcbNome.TabStop = false;
            // 
            // PnlFaqBackgoundFoto
            // 
            this.PnlFaqBackgoundFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlFaqBackgoundFoto.Controls.Add(this.LblDescFotoBackgound);
            this.PnlFaqBackgoundFoto.Controls.Add(this.pictureBox1);
            this.PnlFaqBackgoundFoto.Location = new System.Drawing.Point(244, 248);
            this.PnlFaqBackgoundFoto.Name = "PnlFaqBackgoundFoto";
            this.PnlFaqBackgoundFoto.Size = new System.Drawing.Size(510, 156);
            this.PnlFaqBackgoundFoto.TabIndex = 8;
            // 
            // LblDescFotoBackgound
            // 
            this.LblDescFotoBackgound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescFotoBackgound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescFotoBackgound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescFotoBackgound.Location = new System.Drawing.Point(287, 3);
            this.LblDescFotoBackgound.Name = "LblDescFotoBackgound";
            this.LblDescFotoBackgound.Size = new System.Drawing.Size(220, 153);
            this.LblDescFotoBackgound.TabIndex = 6;
            this.LblDescFotoBackgound.Text = "Foto Backgound: È una semplice foto a piacere che potrebbe rappresentare l\'app, s" +
    "e non viene inserita ne verrà assegnata una standard dal software";
            this.LblDescFotoBackgound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RoyaleLauncher.Properties.Resources.FaqFotoBackground;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFaqRegistrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PnlFaqNomeStart);
            this.Controls.Add(this.PnlFaqBackgoundFoto);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFaqRegistrazione";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoyaleLauncher";
            this.Load += new System.EventHandler(this.FrmSettingsDatabase_Load);
            this.PnlToolBar.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.PnlFaqNomeStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbNome)).EndInit();
            this.PnlFaqBackgoundFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEsci;
        private System.Windows.Forms.Panel PnlToolBar;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblDescUsername;
        private System.Windows.Forms.Button BtnFaqNomeStart;
        private System.Windows.Forms.Button BtnFaqFotoBackgound;
        private System.Windows.Forms.OpenFileDialog OfdFileLogo;
        private MyPanel PnlFaqNomeStart;
        private MyPanel PnlFaqBackgoundFoto;
        private System.Windows.Forms.PictureBox PcbNome;
        private System.Windows.Forms.Label LblDescNomeStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblDescFotoBackgound;
    }
}

