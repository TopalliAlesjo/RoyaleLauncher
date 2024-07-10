namespace RoyaleLauncher
{
    partial class FrmPrimoStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrimoStart));
            this.PnlToolBar = new System.Windows.Forms.Panel();
            this.LblTitolo = new System.Windows.Forms.Label();
            this.LblDescStatus = new System.Windows.Forms.Label();
            this.LblDescUsername = new System.Windows.Forms.Label();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDescAsterisco = new System.Windows.Forms.Label();
            this.LblDescLeggenda = new System.Windows.Forms.Label();
            this.CkbLogoBase = new System.Windows.Forms.CheckBox();
            this.LblDescFacoltativo = new System.Windows.Forms.Label();
            this.BtnFaqModalitàOspite = new System.Windows.Forms.Button();
            this.BtnModalitàOspite = new System.Windows.Forms.Button();
            this.LblDescrizione = new System.Windows.Forms.Label();
            this.LblDescEsempioNomeUtente = new System.Windows.Forms.Label();
            this.LblDescEsempioLogo = new System.Windows.Forms.Label();
            this.TxtNomeUtente = new CustomControls.RJControls.RJTextBox();
            this.LblDescNomeUtente = new System.Windows.Forms.Label();
            this.GrbEsempio = new System.Windows.Forms.GroupBox();
            this.PcbEsempioLogo = new System.Windows.Forms.PictureBox();
            this.LblDescLogo = new System.Windows.Forms.Label();
            this.BtnApriDialogoFileRgLogo = new System.Windows.Forms.Button();
            this.TxtFotoRegistra = new CustomControls.RJControls.RJTextBox();
            this.BtnFine = new System.Windows.Forms.Button();
            this.OfdFileLogo = new System.Windows.Forms.OpenFileDialog();
            this.OfdFileCollegamento = new System.Windows.Forms.OpenFileDialog();
            this.FbdCollegamentoApp = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlToolBar.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.GrbEsempio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbEsempioLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlToolBar
            // 
            this.PnlToolBar.BackColor = System.Drawing.Color.Transparent;
            this.PnlToolBar.Controls.Add(this.LblTitolo);
            this.PnlToolBar.Location = new System.Drawing.Point(0, 2);
            this.PnlToolBar.Name = "PnlToolBar";
            this.PnlToolBar.Size = new System.Drawing.Size(797, 35);
            this.PnlToolBar.TabIndex = 4;
            this.PnlToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlToolBar_MouseDown);
            // 
            // LblTitolo
            // 
            this.LblTitolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitolo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblTitolo.Location = new System.Drawing.Point(242, 12);
            this.LblTitolo.Name = "LblTitolo";
            this.LblTitolo.Size = new System.Drawing.Size(323, 23);
            this.LblTitolo.TabIndex = 28;
            this.LblTitolo.Text = "BENVENUTO NEL ROYALE LAUNCHER\r\n";
            // 
            // LblDescStatus
            // 
            this.LblDescStatus.AutoSize = true;
            this.LblDescStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LblDescStatus.Location = new System.Drawing.Point(38, 119);
            this.LblDescStatus.Name = "LblDescStatus";
            this.LblDescStatus.Size = new System.Drawing.Size(37, 12);
            this.LblDescStatus.TabIndex = 2;
            this.LblDescStatus.Text = "Online";
            // 
            // LblDescUsername
            // 
            this.LblDescUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescUsername.Location = new System.Drawing.Point(6, 96);
            this.LblDescUsername.Name = "LblDescUsername";
            this.LblDescUsername.Size = new System.Drawing.Size(100, 23);
            this.LblDescUsername.TabIndex = 1;
            this.LblDescUsername.Text = "Topalli";
            this.LblDescUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PnlMain
            // 
            this.PnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlMain.Controls.Add(this.label1);
            this.PnlMain.Controls.Add(this.LblDescAsterisco);
            this.PnlMain.Controls.Add(this.LblDescLeggenda);
            this.PnlMain.Controls.Add(this.CkbLogoBase);
            this.PnlMain.Controls.Add(this.LblDescFacoltativo);
            this.PnlMain.Controls.Add(this.BtnFaqModalitàOspite);
            this.PnlMain.Controls.Add(this.BtnModalitàOspite);
            this.PnlMain.Controls.Add(this.LblDescrizione);
            this.PnlMain.Controls.Add(this.LblDescEsempioNomeUtente);
            this.PnlMain.Controls.Add(this.LblDescEsempioLogo);
            this.PnlMain.Controls.Add(this.TxtNomeUtente);
            this.PnlMain.Controls.Add(this.LblDescNomeUtente);
            this.PnlMain.Controls.Add(this.GrbEsempio);
            this.PnlMain.Controls.Add(this.LblDescLogo);
            this.PnlMain.Controls.Add(this.BtnApriDialogoFileRgLogo);
            this.PnlMain.Controls.Add(this.TxtFotoRegistra);
            this.PnlMain.Controls.Add(this.BtnFine);
            this.PnlMain.Location = new System.Drawing.Point(86, 43);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(628, 364);
            this.PnlMain.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(474, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "*";
            // 
            // LblDescAsterisco
            // 
            this.LblDescAsterisco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescAsterisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescAsterisco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescAsterisco.Location = new System.Drawing.Point(6, 19);
            this.LblDescAsterisco.Name = "LblDescAsterisco";
            this.LblDescAsterisco.Size = new System.Drawing.Size(16, 18);
            this.LblDescAsterisco.TabIndex = 39;
            this.LblDescAsterisco.Text = "*";
            // 
            // LblDescLeggenda
            // 
            this.LblDescLeggenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescLeggenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescLeggenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescLeggenda.Location = new System.Drawing.Point(19, 19);
            this.LblDescLeggenda.Name = "LblDescLeggenda";
            this.LblDescLeggenda.Size = new System.Drawing.Size(192, 53);
            this.LblDescLeggenda.TabIndex = 38;
            this.LblDescLeggenda.Text = "= Campo Obbligatorio\r\n(se si usa la modalità ospite \r\nnon si rispetta questa legg" +
    "enda)";
            // 
            // CkbLogoBase
            // 
            this.CkbLogoBase.AutoSize = true;
            this.CkbLogoBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbLogoBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CkbLogoBase.Location = new System.Drawing.Point(171, 274);
            this.CkbLogoBase.Name = "CkbLogoBase";
            this.CkbLogoBase.Size = new System.Drawing.Size(94, 19);
            this.CkbLogoBase.TabIndex = 2;
            this.CkbLogoBase.Text = "Logo Base";
            this.CkbLogoBase.UseVisualStyleBackColor = true;
            this.CkbLogoBase.CheckedChanged += new System.EventHandler(this.CkbLogoBase_CheckedChanged);
            // 
            // LblDescFacoltativo
            // 
            this.LblDescFacoltativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescFacoltativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescFacoltativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescFacoltativo.Location = new System.Drawing.Point(91, 263);
            this.LblDescFacoltativo.Name = "LblDescFacoltativo";
            this.LblDescFacoltativo.Size = new System.Drawing.Size(74, 15);
            this.LblDescFacoltativo.TabIndex = 36;
            this.LblDescFacoltativo.Text = "(Facoltativo)";
            // 
            // BtnFaqModalitàOspite
            // 
            this.BtnFaqModalitàOspite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnFaqModalitàOspite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaqModalitàOspite.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFaqModalitàOspite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnFaqModalitàOspite.Image = global::RoyaleLauncher.Properties.Resources.faq;
            this.BtnFaqModalitàOspite.Location = new System.Drawing.Point(115, 313);
            this.BtnFaqModalitàOspite.Name = "BtnFaqModalitàOspite";
            this.BtnFaqModalitàOspite.Size = new System.Drawing.Size(46, 47);
            this.BtnFaqModalitàOspite.TabIndex = 4;
            this.BtnFaqModalitàOspite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFaqModalitàOspite.UseVisualStyleBackColor = false;
            this.BtnFaqModalitàOspite.Click += new System.EventHandler(this.BtnFaqModalitàOspite_Click);
            // 
            // BtnModalitàOspite
            // 
            this.BtnModalitàOspite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnModalitàOspite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModalitàOspite.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModalitàOspite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnModalitàOspite.Image = global::RoyaleLauncher.Properties.Resources.ospiteX25;
            this.BtnModalitàOspite.Location = new System.Drawing.Point(7, 313);
            this.BtnModalitàOspite.Name = "BtnModalitàOspite";
            this.BtnModalitàOspite.Size = new System.Drawing.Size(102, 47);
            this.BtnModalitàOspite.TabIndex = 3;
            this.BtnModalitàOspite.Text = "Modalità Ospite";
            this.BtnModalitàOspite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnModalitàOspite.UseVisualStyleBackColor = false;
            this.BtnModalitàOspite.Click += new System.EventHandler(this.BtnModalitàOspite_Click);
            // 
            // LblDescrizione
            // 
            this.LblDescrizione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescrizione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescrizione.Location = new System.Drawing.Point(166, 178);
            this.LblDescrizione.Name = "LblDescrizione";
            this.LblDescrizione.Size = new System.Drawing.Size(157, 15);
            this.LblDescrizione.TabIndex = 29;
            this.LblDescrizione.Text = "Compila i campi sottostanti:";
            // 
            // LblDescEsempioNomeUtente
            // 
            this.LblDescEsempioNomeUtente.AutoSize = true;
            this.LblDescEsempioNomeUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescEsempioNomeUtente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LblDescEsempioNomeUtente.Location = new System.Drawing.Point(446, 102);
            this.LblDescEsempioNomeUtente.Name = "LblDescEsempioNomeUtente";
            this.LblDescEsempioNomeUtente.Size = new System.Drawing.Size(60, 12);
            this.LblDescEsempioNomeUtente.TabIndex = 27;
            this.LblDescEsempioNomeUtente.Text = "Username:";
            // 
            // LblDescEsempioLogo
            // 
            this.LblDescEsempioLogo.AutoSize = true;
            this.LblDescEsempioLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescEsempioLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LblDescEsempioLogo.Location = new System.Drawing.Point(476, 60);
            this.LblDescEsempioLogo.Name = "LblDescEsempioLogo";
            this.LblDescEsempioLogo.Size = new System.Drawing.Size(33, 12);
            this.LblDescEsempioLogo.TabIndex = 26;
            this.LblDescEsempioLogo.Text = "Logo:";
            // 
            // TxtNomeUtente
            // 
            this.TxtNomeUtente.AccessibleDescription = "";
            this.TxtNomeUtente.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.TxtNomeUtente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtNomeUtente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TxtNomeUtente.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.TxtNomeUtente.BorderSize = 1;
            this.TxtNomeUtente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNomeUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeUtente.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNomeUtente.Location = new System.Drawing.Point(168, 197);
            this.TxtNomeUtente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNomeUtente.Multiline = false;
            this.TxtNomeUtente.Name = "TxtNomeUtente";
            this.TxtNomeUtente.Padding = new System.Windows.Forms.Padding(7);
            this.TxtNomeUtente.PasswordChar = false;
            this.TxtNomeUtente.Size = new System.Drawing.Size(299, 31);
            this.TxtNomeUtente.TabIndex = 0;
            this.TxtNomeUtente.Texts = "Max 12 caratteri";
            this.TxtNomeUtente.UnderlinedStyle = true;
            // 
            // LblDescNomeUtente
            // 
            this.LblDescNomeUtente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescNomeUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescNomeUtente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescNomeUtente.Location = new System.Drawing.Point(15, 205);
            this.LblDescNomeUtente.Name = "LblDescNomeUtente";
            this.LblDescNomeUtente.Size = new System.Drawing.Size(146, 23);
            this.LblDescNomeUtente.TabIndex = 24;
            this.LblDescNomeUtente.Text = "Inserisci Username:";
            // 
            // GrbEsempio
            // 
            this.GrbEsempio.Controls.Add(this.PcbEsempioLogo);
            this.GrbEsempio.Controls.Add(this.LblDescStatus);
            this.GrbEsempio.Controls.Add(this.LblDescUsername);
            this.GrbEsempio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GrbEsempio.Location = new System.Drawing.Point(512, 3);
            this.GrbEsempio.Name = "GrbEsempio";
            this.GrbEsempio.Size = new System.Drawing.Size(112, 136);
            this.GrbEsempio.TabIndex = 23;
            this.GrbEsempio.TabStop = false;
            this.GrbEsempio.Text = "Esempio";
            // 
            // PcbEsempioLogo
            // 
            this.PcbEsempioLogo.Image = global::RoyaleLauncher.Properties.Resources.Il_Trixi_Logo_Corona;
            this.PcbEsempioLogo.Location = new System.Drawing.Point(6, 19);
            this.PcbEsempioLogo.Name = "PcbEsempioLogo";
            this.PcbEsempioLogo.Size = new System.Drawing.Size(100, 74);
            this.PcbEsempioLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbEsempioLogo.TabIndex = 0;
            this.PcbEsempioLogo.TabStop = false;
            // 
            // LblDescLogo
            // 
            this.LblDescLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescLogo.Location = new System.Drawing.Point(7, 244);
            this.LblDescLogo.Name = "LblDescLogo";
            this.LblDescLogo.Size = new System.Drawing.Size(154, 19);
            this.LblDescLogo.TabIndex = 22;
            this.LblDescLogo.Text = "Logo Personalizzato:";
            // 
            // BtnApriDialogoFileRgLogo
            // 
            this.BtnApriDialogoFileRgLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApriDialogoFileRgLogo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApriDialogoFileRgLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApriDialogoFileRgLogo.Image = global::RoyaleLauncher.Properties.Resources.Folder;
            this.BtnApriDialogoFileRgLogo.Location = new System.Drawing.Point(475, 236);
            this.BtnApriDialogoFileRgLogo.Name = "BtnApriDialogoFileRgLogo";
            this.BtnApriDialogoFileRgLogo.Size = new System.Drawing.Size(37, 31);
            this.BtnApriDialogoFileRgLogo.TabIndex = 1;
            this.BtnApriDialogoFileRgLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApriDialogoFileRgLogo.UseVisualStyleBackColor = true;
            this.BtnApriDialogoFileRgLogo.Click += new System.EventHandler(this.BtnApriDialogoFileRgLogo_Click);
            // 
            // TxtFotoRegistra
            // 
            this.TxtFotoRegistra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtFotoRegistra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TxtFotoRegistra.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.TxtFotoRegistra.BorderSize = 1;
            this.TxtFotoRegistra.Enabled = false;
            this.TxtFotoRegistra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFotoRegistra.ForeColor = System.Drawing.Color.DimGray;
            this.TxtFotoRegistra.Location = new System.Drawing.Point(168, 236);
            this.TxtFotoRegistra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFotoRegistra.Multiline = false;
            this.TxtFotoRegistra.Name = "TxtFotoRegistra";
            this.TxtFotoRegistra.Padding = new System.Windows.Forms.Padding(7);
            this.TxtFotoRegistra.PasswordChar = false;
            this.TxtFotoRegistra.Size = new System.Drawing.Size(299, 31);
            this.TxtFotoRegistra.TabIndex = 20;
            this.TxtFotoRegistra.Texts = "Seleziona File";
            this.TxtFotoRegistra.UnderlinedStyle = true;
            // 
            // BtnFine
            // 
            this.BtnFine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFine.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnFine.Image = global::RoyaleLauncher.Properties.Resources.next;
            this.BtnFine.Location = new System.Drawing.Point(523, 318);
            this.BtnFine.Name = "BtnFine";
            this.BtnFine.Size = new System.Drawing.Size(100, 42);
            this.BtnFine.TabIndex = 5;
            this.BtnFine.Text = "Fine";
            this.BtnFine.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFine.UseVisualStyleBackColor = false;
            this.BtnFine.Click += new System.EventHandler(this.BtnFine_Click);
            // 
            // OfdFileLogo
            // 
            this.OfdFileLogo.FileName = "Seleziona Il Logo";
            this.OfdFileLogo.SupportMultiDottedExtensions = true;
            // 
            // OfdFileCollegamento
            // 
            this.OfdFileCollegamento.FileName = "Inserisci il luogo di creazione";
            this.OfdFileCollegamento.SupportMultiDottedExtensions = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(577, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Created by ©AlesjoTopalli With ❤";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPrimoStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.PnlToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrimoStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoyaleLauncher";
            this.PnlToolBar.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.GrbEsempio.ResumeLayout(false);
            this.GrbEsempio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbEsempioLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlToolBar;
        private System.Windows.Forms.PictureBox PcbEsempioLogo;
        private System.Windows.Forms.Label LblDescUsername;
        private System.Windows.Forms.Label LblDescStatus;
        private System.Windows.Forms.Button BtnFine;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Button BtnApriDialogoFileRgLogo;
        private CustomControls.RJControls.RJTextBox TxtFotoRegistra;
        private System.Windows.Forms.Label LblDescLogo;
        private System.Windows.Forms.OpenFileDialog OfdFileLogo;
        private System.Windows.Forms.Label LblDescNomeUtente;
        private System.Windows.Forms.GroupBox GrbEsempio;
        private CustomControls.RJControls.RJTextBox TxtNomeUtente;
        private System.Windows.Forms.Label LblDescEsempioNomeUtente;
        private System.Windows.Forms.Label LblDescEsempioLogo;
        private System.Windows.Forms.Label LblDescrizione;
        private System.Windows.Forms.Label LblTitolo;
        private System.Windows.Forms.OpenFileDialog OfdFileCollegamento;
        private System.Windows.Forms.Button BtnModalitàOspite;
        private System.Windows.Forms.Button BtnFaqModalitàOspite;
        private System.Windows.Forms.FolderBrowserDialog FbdCollegamentoApp;
        private System.Windows.Forms.CheckBox CkbLogoBase;
        private System.Windows.Forms.Label LblDescFacoltativo;
        private System.Windows.Forms.Label LblDescLeggenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDescAsterisco;
        private System.Windows.Forms.Label label2;
    }
}

