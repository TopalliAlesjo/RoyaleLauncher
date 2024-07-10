namespace RoyaleLauncher
{
    partial class FrmDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatabase));
            this.BtnEsci = new System.Windows.Forms.Button();
            this.PnlToolBar = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnEliminazione = new System.Windows.Forms.Button();
            this.BtnRegistrazione = new System.Windows.Forms.Button();
            this.LblDescUsername = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.OfdFileStart = new System.Windows.Forms.OpenFileDialog();
            this.PnlEliminazione = new MyPanel();
            this.CmbNomeAppEliminazione = new CustomControls.RJControls.RJComboBox();
            this.LblDescEliminazione = new System.Windows.Forms.Label();
            this.TxtStartElimina = new CustomControls.RJControls.RJTextBox();
            this.LblDescStringaStartEliminazione = new System.Windows.Forms.Label();
            this.BtnElimina = new System.Windows.Forms.Button();
            this.LblDescNomeAppEliminazione = new System.Windows.Forms.Label();
            this.PnlRegistrazione = new MyPanel();
            this.BtnFaqRegistrazione = new System.Windows.Forms.Button();
            this.LblCampoObbligatorioStart = new System.Windows.Forms.Label();
            this.LblCampoObbligatorioID = new System.Windows.Forms.Label();
            this.LblDescCampiObbligatori = new System.Windows.Forms.Label();
            this.BtnApriDialogoFileRgFoto = new System.Windows.Forms.Button();
            this.TxtFotoRegistra = new CustomControls.RJControls.RJTextBox();
            this.LblDescFotoBackRegistrazione = new System.Windows.Forms.Label();
            this.BtnApriDialogoFileRg = new System.Windows.Forms.Button();
            this.LblDescIns = new System.Windows.Forms.Label();
            this.TxtStartRegistra = new CustomControls.RJControls.RJTextBox();
            this.LblDescStrStart = new System.Windows.Forms.Label();
            this.BtnRegistra = new System.Windows.Forms.Button();
            this.LblDescId = new System.Windows.Forms.Label();
            this.TxtIdRegistra = new CustomControls.RJControls.RJTextBox();
            this.OfdFileFoto = new System.Windows.Forms.OpenFileDialog();
            this.PnlToolBar.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            this.PnlEliminazione.SuspendLayout();
            this.PnlRegistrazione.SuspendLayout();
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
            this.BtnEsci.TabIndex = 0;
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
            this.PnlMenu.Controls.Add(this.BtnEliminazione);
            this.PnlMenu.Controls.Add(this.BtnRegistrazione);
            this.PnlMenu.Controls.Add(this.LblDescUsername);
            this.PnlMenu.Controls.Add(this.LblUsername);
            this.PnlMenu.Controls.Add(this.PcbLogo);
            this.PnlMenu.Location = new System.Drawing.Point(0, -5);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(189, 457);
            this.PnlMenu.TabIndex = 6;
            // 
            // BtnEliminazione
            // 
            this.BtnEliminazione.FlatAppearance.BorderSize = 0;
            this.BtnEliminazione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminazione.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnEliminazione.Image = global::RoyaleLauncher.Properties.Resources.database;
            this.BtnEliminazione.Location = new System.Drawing.Point(0, 193);
            this.BtnEliminazione.Name = "BtnEliminazione";
            this.BtnEliminazione.Size = new System.Drawing.Size(189, 42);
            this.BtnEliminazione.TabIndex = 1;
            this.BtnEliminazione.Text = "Eliminazione";
            this.BtnEliminazione.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnEliminazione.UseVisualStyleBackColor = true;
            this.BtnEliminazione.Click += new System.EventHandler(this.BtnEliminazione_Click);
            // 
            // BtnRegistrazione
            // 
            this.BtnRegistrazione.FlatAppearance.BorderSize = 0;
            this.BtnRegistrazione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrazione.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnRegistrazione.Image = global::RoyaleLauncher.Properties.Resources.database;
            this.BtnRegistrazione.Location = new System.Drawing.Point(0, 145);
            this.BtnRegistrazione.Name = "BtnRegistrazione";
            this.BtnRegistrazione.Size = new System.Drawing.Size(189, 42);
            this.BtnRegistrazione.TabIndex = 0;
            this.BtnRegistrazione.Text = "Registrazione";
            this.BtnRegistrazione.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRegistrazione.UseVisualStyleBackColor = true;
            this.BtnRegistrazione.Click += new System.EventHandler(this.BtnRegistrazione_Click);
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
            // OfdFileStart
            // 
            this.OfdFileStart.FileName = "Seleziona L\'app";
            this.OfdFileStart.SupportMultiDottedExtensions = true;
            // 
            // PnlEliminazione
            // 
            this.PnlEliminazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlEliminazione.Controls.Add(this.CmbNomeAppEliminazione);
            this.PnlEliminazione.Controls.Add(this.LblDescEliminazione);
            this.PnlEliminazione.Controls.Add(this.TxtStartElimina);
            this.PnlEliminazione.Controls.Add(this.LblDescStringaStartEliminazione);
            this.PnlEliminazione.Controls.Add(this.BtnElimina);
            this.PnlEliminazione.Controls.Add(this.LblDescNomeAppEliminazione);
            this.PnlEliminazione.Location = new System.Drawing.Point(264, 43);
            this.PnlEliminazione.Name = "PnlEliminazione";
            this.PnlEliminazione.Size = new System.Drawing.Size(501, 197);
            this.PnlEliminazione.TabIndex = 17;
            // 
            // CmbNomeAppEliminazione
            // 
            this.CmbNomeAppEliminazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.CmbNomeAppEliminazione.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbNomeAppEliminazione.BorderSize = 1;
            this.CmbNomeAppEliminazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbNomeAppEliminazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbNomeAppEliminazione.ForeColor = System.Drawing.Color.DimGray;
            this.CmbNomeAppEliminazione.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.CmbNomeAppEliminazione.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CmbNomeAppEliminazione.ListTextColor = System.Drawing.Color.DimGray;
            this.CmbNomeAppEliminazione.Location = new System.Drawing.Point(148, 46);
            this.CmbNomeAppEliminazione.MinimumSize = new System.Drawing.Size(200, 30);
            this.CmbNomeAppEliminazione.Name = "CmbNomeAppEliminazione";
            this.CmbNomeAppEliminazione.Padding = new System.Windows.Forms.Padding(1);
            this.CmbNomeAppEliminazione.Size = new System.Drawing.Size(299, 30);
            this.CmbNomeAppEliminazione.TabIndex = 0;
            this.CmbNomeAppEliminazione.Texts = "";
            this.CmbNomeAppEliminazione.OnSelectedIndexChanged += new System.EventHandler(this.CmbNomeAppEliminazione_OnSelectedIndexChanged);
            // 
            // LblDescEliminazione
            // 
            this.LblDescEliminazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescEliminazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescEliminazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescEliminazione.Location = new System.Drawing.Point(3, 14);
            this.LblDescEliminazione.Name = "LblDescEliminazione";
            this.LblDescEliminazione.Size = new System.Drawing.Size(242, 23);
            this.LblDescEliminazione.TabIndex = 4;
            this.LblDescEliminazione.Text = "Inserisci Campi Di Eliminazione:";
            // 
            // TxtStartElimina
            // 
            this.TxtStartElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtStartElimina.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TxtStartElimina.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.TxtStartElimina.BorderSize = 1;
            this.TxtStartElimina.Enabled = false;
            this.TxtStartElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStartElimina.ForeColor = System.Drawing.Color.DimGray;
            this.TxtStartElimina.Location = new System.Drawing.Point(148, 80);
            this.TxtStartElimina.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStartElimina.Multiline = false;
            this.TxtStartElimina.Name = "TxtStartElimina";
            this.TxtStartElimina.Padding = new System.Windows.Forms.Padding(7);
            this.TxtStartElimina.PasswordChar = false;
            this.TxtStartElimina.Size = new System.Drawing.Size(299, 31);
            this.TxtStartElimina.TabIndex = 15;
            this.TxtStartElimina.Texts = "Seleziona Nome App";
            this.TxtStartElimina.UnderlinedStyle = true;
            // 
            // LblDescStringaStartEliminazione
            // 
            this.LblDescStringaStartEliminazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescStringaStartEliminazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescStringaStartEliminazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescStringaStartEliminazione.Location = new System.Drawing.Point(43, 92);
            this.LblDescStringaStartEliminazione.Name = "LblDescStringaStartEliminazione";
            this.LblDescStringaStartEliminazione.Size = new System.Drawing.Size(98, 19);
            this.LblDescStringaStartEliminazione.TabIndex = 12;
            this.LblDescStringaStartEliminazione.Text = "Stringa Start:";
            // 
            // BtnElimina
            // 
            this.BtnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnElimina.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnElimina.Image = global::RoyaleLauncher.Properties.Resources.database;
            this.BtnElimina.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnElimina.Location = new System.Drawing.Point(148, 118);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(100, 44);
            this.BtnElimina.TabIndex = 1;
            this.BtnElimina.Text = "Elimina";
            this.BtnElimina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnElimina.UseVisualStyleBackColor = true;
            this.BtnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // LblDescNomeAppEliminazione
            // 
            this.LblDescNomeAppEliminazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescNomeAppEliminazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescNomeAppEliminazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescNomeAppEliminazione.Location = new System.Drawing.Point(43, 53);
            this.LblDescNomeAppEliminazione.Name = "LblDescNomeAppEliminazione";
            this.LblDescNomeAppEliminazione.Size = new System.Drawing.Size(105, 23);
            this.LblDescNomeAppEliminazione.TabIndex = 11;
            this.LblDescNomeAppEliminazione.Text = "Nome App:";
            // 
            // PnlRegistrazione
            // 
            this.PnlRegistrazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PnlRegistrazione.Controls.Add(this.BtnFaqRegistrazione);
            this.PnlRegistrazione.Controls.Add(this.LblCampoObbligatorioStart);
            this.PnlRegistrazione.Controls.Add(this.LblCampoObbligatorioID);
            this.PnlRegistrazione.Controls.Add(this.LblDescCampiObbligatori);
            this.PnlRegistrazione.Controls.Add(this.BtnApriDialogoFileRgFoto);
            this.PnlRegistrazione.Controls.Add(this.TxtFotoRegistra);
            this.PnlRegistrazione.Controls.Add(this.LblDescFotoBackRegistrazione);
            this.PnlRegistrazione.Controls.Add(this.BtnApriDialogoFileRg);
            this.PnlRegistrazione.Controls.Add(this.LblDescIns);
            this.PnlRegistrazione.Controls.Add(this.TxtStartRegistra);
            this.PnlRegistrazione.Controls.Add(this.LblDescStrStart);
            this.PnlRegistrazione.Controls.Add(this.BtnRegistra);
            this.PnlRegistrazione.Controls.Add(this.LblDescId);
            this.PnlRegistrazione.Controls.Add(this.TxtIdRegistra);
            this.PnlRegistrazione.Location = new System.Drawing.Point(264, 241);
            this.PnlRegistrazione.Name = "PnlRegistrazione";
            this.PnlRegistrazione.Size = new System.Drawing.Size(501, 197);
            this.PnlRegistrazione.TabIndex = 8;
            // 
            // BtnFaqRegistrazione
            // 
            this.BtnFaqRegistrazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnFaqRegistrazione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaqRegistrazione.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFaqRegistrazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnFaqRegistrazione.Image = global::RoyaleLauncher.Properties.Resources.faq;
            this.BtnFaqRegistrazione.Location = new System.Drawing.Point(454, 156);
            this.BtnFaqRegistrazione.Name = "BtnFaqRegistrazione";
            this.BtnFaqRegistrazione.Size = new System.Drawing.Size(37, 37);
            this.BtnFaqRegistrazione.TabIndex = 3;
            this.BtnFaqRegistrazione.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFaqRegistrazione.UseVisualStyleBackColor = false;
            this.BtnFaqRegistrazione.Click += new System.EventHandler(this.BtnFaqRegistrazione_Click);
            // 
            // LblCampoObbligatorioStart
            // 
            this.LblCampoObbligatorioStart.AutoSize = true;
            this.LblCampoObbligatorioStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampoObbligatorioStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LblCampoObbligatorioStart.Location = new System.Drawing.Point(34, 92);
            this.LblCampoObbligatorioStart.Name = "LblCampoObbligatorioStart";
            this.LblCampoObbligatorioStart.Size = new System.Drawing.Size(13, 16);
            this.LblCampoObbligatorioStart.TabIndex = 30;
            this.LblCampoObbligatorioStart.Text = "*";
            // 
            // LblCampoObbligatorioID
            // 
            this.LblCampoObbligatorioID.AutoSize = true;
            this.LblCampoObbligatorioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCampoObbligatorioID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LblCampoObbligatorioID.Location = new System.Drawing.Point(34, 53);
            this.LblCampoObbligatorioID.Name = "LblCampoObbligatorioID";
            this.LblCampoObbligatorioID.Size = new System.Drawing.Size(13, 16);
            this.LblCampoObbligatorioID.TabIndex = 29;
            this.LblCampoObbligatorioID.Text = "*";
            // 
            // LblDescCampiObbligatori
            // 
            this.LblDescCampiObbligatori.AutoSize = true;
            this.LblDescCampiObbligatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescCampiObbligatori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LblDescCampiObbligatori.Location = new System.Drawing.Point(330, 2);
            this.LblDescCampiObbligatori.Name = "LblDescCampiObbligatori";
            this.LblDescCampiObbligatori.Size = new System.Drawing.Size(168, 16);
            this.LblDescCampiObbligatori.TabIndex = 28;
            this.LblDescCampiObbligatori.Text = "* = Campo Obbligatorio";
            // 
            // BtnApriDialogoFileRgFoto
            // 
            this.BtnApriDialogoFileRgFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApriDialogoFileRgFoto.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApriDialogoFileRgFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApriDialogoFileRgFoto.Image = global::RoyaleLauncher.Properties.Resources.Folder;
            this.BtnApriDialogoFileRgFoto.Location = new System.Drawing.Point(454, 119);
            this.BtnApriDialogoFileRgFoto.Name = "BtnApriDialogoFileRgFoto";
            this.BtnApriDialogoFileRgFoto.Size = new System.Drawing.Size(37, 31);
            this.BtnApriDialogoFileRgFoto.TabIndex = 2;
            this.BtnApriDialogoFileRgFoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApriDialogoFileRgFoto.UseVisualStyleBackColor = true;
            this.BtnApriDialogoFileRgFoto.Click += new System.EventHandler(this.BtnApriDialogoFileRgFoto_Click);
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
            this.TxtFotoRegistra.Location = new System.Drawing.Point(148, 119);
            this.TxtFotoRegistra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFotoRegistra.Multiline = false;
            this.TxtFotoRegistra.Name = "TxtFotoRegistra";
            this.TxtFotoRegistra.Padding = new System.Windows.Forms.Padding(7);
            this.TxtFotoRegistra.PasswordChar = false;
            this.TxtFotoRegistra.Size = new System.Drawing.Size(299, 31);
            this.TxtFotoRegistra.TabIndex = 18;
            this.TxtFotoRegistra.Texts = "Seleziona File";
            this.TxtFotoRegistra.UnderlinedStyle = true;
            // 
            // LblDescFotoBackRegistrazione
            // 
            this.LblDescFotoBackRegistrazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescFotoBackRegistrazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescFotoBackRegistrazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescFotoBackRegistrazione.Location = new System.Drawing.Point(17, 125);
            this.LblDescFotoBackRegistrazione.Name = "LblDescFotoBackRegistrazione";
            this.LblDescFotoBackRegistrazione.Size = new System.Drawing.Size(124, 19);
            this.LblDescFotoBackRegistrazione.TabIndex = 17;
            this.LblDescFotoBackRegistrazione.Text = "Foto Backgound:";
            // 
            // BtnApriDialogoFileRg
            // 
            this.BtnApriDialogoFileRg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApriDialogoFileRg.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApriDialogoFileRg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnApriDialogoFileRg.Image = global::RoyaleLauncher.Properties.Resources.Folder;
            this.BtnApriDialogoFileRg.Location = new System.Drawing.Point(454, 80);
            this.BtnApriDialogoFileRg.Name = "BtnApriDialogoFileRg";
            this.BtnApriDialogoFileRg.Size = new System.Drawing.Size(37, 31);
            this.BtnApriDialogoFileRg.TabIndex = 1;
            this.BtnApriDialogoFileRg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnApriDialogoFileRg.UseVisualStyleBackColor = true;
            this.BtnApriDialogoFileRg.Click += new System.EventHandler(this.BtnApriDialogoFile_Click);
            // 
            // LblDescIns
            // 
            this.LblDescIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescIns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescIns.Location = new System.Drawing.Point(3, 14);
            this.LblDescIns.Name = "LblDescIns";
            this.LblDescIns.Size = new System.Drawing.Size(242, 23);
            this.LblDescIns.TabIndex = 4;
            this.LblDescIns.Text = "Inserisci Campi Di Registrazione:";
            // 
            // TxtStartRegistra
            // 
            this.TxtStartRegistra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtStartRegistra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TxtStartRegistra.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.TxtStartRegistra.BorderSize = 1;
            this.TxtStartRegistra.Enabled = false;
            this.TxtStartRegistra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStartRegistra.ForeColor = System.Drawing.Color.DimGray;
            this.TxtStartRegistra.Location = new System.Drawing.Point(148, 80);
            this.TxtStartRegistra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStartRegistra.Multiline = false;
            this.TxtStartRegistra.Name = "TxtStartRegistra";
            this.TxtStartRegistra.Padding = new System.Windows.Forms.Padding(7);
            this.TxtStartRegistra.PasswordChar = false;
            this.TxtStartRegistra.Size = new System.Drawing.Size(299, 31);
            this.TxtStartRegistra.TabIndex = 15;
            this.TxtStartRegistra.Texts = "Seleziona File";
            this.TxtStartRegistra.UnderlinedStyle = true;
            // 
            // LblDescStrStart
            // 
            this.LblDescStrStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescStrStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescStrStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescStrStart.Location = new System.Drawing.Point(43, 92);
            this.LblDescStrStart.Name = "LblDescStrStart";
            this.LblDescStrStart.Size = new System.Drawing.Size(98, 19);
            this.LblDescStrStart.TabIndex = 12;
            this.LblDescStrStart.Text = "Stringa Start:";
            // 
            // BtnRegistra
            // 
            this.BtnRegistra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistra.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnRegistra.Image = global::RoyaleLauncher.Properties.Resources.database;
            this.BtnRegistra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistra.Location = new System.Drawing.Point(148, 157);
            this.BtnRegistra.Name = "BtnRegistra";
            this.BtnRegistra.Size = new System.Drawing.Size(100, 37);
            this.BtnRegistra.TabIndex = 4;
            this.BtnRegistra.Text = "Registra";
            this.BtnRegistra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistra.UseVisualStyleBackColor = true;
            this.BtnRegistra.Click += new System.EventHandler(this.BtnRegistraGioco_Click);
            // 
            // LblDescId
            // 
            this.LblDescId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.LblDescId.Location = new System.Drawing.Point(43, 53);
            this.LblDescId.Name = "LblDescId";
            this.LblDescId.Size = new System.Drawing.Size(105, 23);
            this.LblDescId.TabIndex = 11;
            this.LblDescId.Text = "Nome App:";
            // 
            // TxtIdRegistra
            // 
            this.TxtIdRegistra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtIdRegistra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TxtIdRegistra.BorderFocusColor = System.Drawing.Color.LightBlue;
            this.TxtIdRegistra.BorderSize = 1;
            this.TxtIdRegistra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtIdRegistra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdRegistra.ForeColor = System.Drawing.Color.DimGray;
            this.TxtIdRegistra.Location = new System.Drawing.Point(148, 41);
            this.TxtIdRegistra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdRegistra.Multiline = false;
            this.TxtIdRegistra.Name = "TxtIdRegistra";
            this.TxtIdRegistra.Padding = new System.Windows.Forms.Padding(7);
            this.TxtIdRegistra.PasswordChar = false;
            this.TxtIdRegistra.Size = new System.Drawing.Size(299, 31);
            this.TxtIdRegistra.TabIndex = 0;
            this.TxtIdRegistra.Texts = "";
            this.TxtIdRegistra.UnderlinedStyle = true;
            // 
            // OfdFileFoto
            // 
            this.OfdFileFoto.FileName = "Seleziona La Foto";
            this.OfdFileFoto.SupportMultiDottedExtensions = true;
            // 
            // FrmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PnlEliminazione);
            this.Controls.Add(this.PnlRegistrazione);
            this.Controls.Add(this.PnlMenu);
            this.Controls.Add(this.PnlToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDatabase";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoyaleLauncher";
            this.Load += new System.EventHandler(this.FrmDatabase_Load);
            this.PnlToolBar.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            this.PnlEliminazione.ResumeLayout(false);
            this.PnlRegistrazione.ResumeLayout(false);
            this.PnlRegistrazione.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEsci;
        private System.Windows.Forms.Panel PnlToolBar;
        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblDescUsername;
        private System.Windows.Forms.Button BtnRegistrazione;
        private System.Windows.Forms.Button BtnRegistra;
        private System.Windows.Forms.Label LblDescIns;
        private System.Windows.Forms.Label LblDescId;
        private System.Windows.Forms.Label LblDescStrStart;
        private CustomControls.RJControls.RJTextBox TxtIdRegistra;
        private CustomControls.RJControls.RJTextBox TxtStartRegistra;
        private MyPanel PnlRegistrazione;
        private System.Windows.Forms.Button BtnApriDialogoFileRg;
        private System.Windows.Forms.OpenFileDialog OfdFileStart;
        private System.Windows.Forms.Button BtnEliminazione;
        private MyPanel PnlEliminazione;
        private System.Windows.Forms.Label LblDescEliminazione;
        private CustomControls.RJControls.RJTextBox TxtStartElimina;
        private System.Windows.Forms.Label LblDescStringaStartEliminazione;
        private System.Windows.Forms.Button BtnElimina;
        private System.Windows.Forms.Label LblDescNomeAppEliminazione;
        private CustomControls.RJControls.RJComboBox CmbNomeAppEliminazione;
        private System.Windows.Forms.Label LblDescFotoBackRegistrazione;
        private System.Windows.Forms.Button BtnApriDialogoFileRgFoto;
        private CustomControls.RJControls.RJTextBox TxtFotoRegistra;
        private System.Windows.Forms.OpenFileDialog OfdFileFoto;
        private System.Windows.Forms.Label LblDescCampiObbligatori;
        private System.Windows.Forms.Label LblCampoObbligatorioStart;
        private System.Windows.Forms.Label LblCampoObbligatorioID;
        private System.Windows.Forms.Button BtnFaqRegistrazione;
    }
}

