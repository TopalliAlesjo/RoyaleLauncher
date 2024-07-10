using RoyaleLauncher.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyaleLauncher
{
    public partial class FrmDatabase : Form
    {
        bool Logo = false, DarkMode = false;
        // trascinare finestra
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // fare bordi
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nbottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );


        public FrmDatabase()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            RefreshUsernameLogo();
        }


        private void FrmDatabase_Load(object sender, EventArgs e)
        {
            // preparo db
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connect, Query;

            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();

            Query = "";
            cmd = new OleDbCommand(Query);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();


            CaricaTrasparenza(Query, cn, cmd, da, Tabella); // carica trasparenza
            CaricaVariabiliColori(); // carica stile colori del form
            cn.Close();

            // carica combo box di tutte le app da poter eliminare
            RefreshComboBox();

            /////// inizializzo elementi e variabili
            PnlEliminazione.Visible = false;
            PnlRegistrazione.Visible = true;
            PnlRegistrazione.Location = new Point(264, 112);
            BtnRegistrazione.BackColor = Variabili.BtnAttivo;
            Variabili.FrmDatabasePassaggioBtnEsci = false;
        }
        private void CaricaTrasparenza(string Query, OleDbConnection cn, OleDbCommand cmd, OleDbDataAdapter da, DataTable Tabella)
        {
            Query = "SELECT Trasparenza " +
                    "FROM Utente " +
                    "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            bool Trasparenza = Convert.ToBoolean(Tabella.Rows[0]["Trasparenza"]);
            if (Trasparenza)
            {
                this.Opacity = 0.85;
            }
            else
            {
                this.Opacity = 1;
            }
            cn.Close();
        }
        private void BtnEsci_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connessione, Query;
            int righe;

            Connessione = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connessione);
            cn.Open();
            // prima query per sapere quantità di righe
            Query = "SELECT * " +
                "FROM Path ";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            righe = Tabella.Rows.Count;
            cn.Close();
            // verifica quale dei due form aprire
            if (righe > 4)
            {
                // chiude questo form e apre il FrmApplicazioni
                Variabili.Pass2 += 1;
                Variabili.Form.Show();
                this.Close();
            }
            else
            {
                // chiude questo apre FrmMain e rende il passaggio aperto per FrmMain e FrmApplicazioni con le variabili
                Variabili.FrmDatabasePassaggioBtnEsci = true;
                Variabili.FrmAppsPassaggioMainDatabase = true;
                FrmMain main = new FrmMain();
                main.Show();
                this.Close();
            }
        }

        private void PnlToolBar_MouseDown(object sender, MouseEventArgs e) // trascinare finestra
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnRegistrazione_Click(object sender, EventArgs e)
        {
            /////// inizializzo elementi
            BtnRegistrazione.BackColor = Variabili.BtnAttivo;
            BtnEliminazione.BackColor = Variabili.BtnDisattivo;
            PnlEliminazione.Visible = false;
            PnlRegistrazione.BringToFront();
            PnlRegistrazione.Visible = true;
            PnlRegistrazione.BringToFront();
            PnlRegistrazione.Location = new Point(264, 112);
        }

        private void BtnEliminazione_Click(object sender, EventArgs e)
        {
            /////// inizializzo elementi
            BtnRegistrazione.BackColor = Variabili.BtnDisattivo;
            BtnEliminazione.BackColor = Variabili.BtnAttivo;
            PnlRegistrazione.Visible = false;
            PnlEliminazione.Visible = true;
            PnlEliminazione.BringToFront();
            PnlEliminazione.Location = new Point(264, 112);
        }

        private async void BtnRegistraGioco_Click(object sender, EventArgs e)
        {
            string IDcheck, StartCheck, Foto;
            if (TxtIdRegistra.Texts.Trim() == "" || TxtStartRegistra.Texts.Trim() == "Seleziona File") // fa un check se i campi compilati
            {
                MessageBox.Show($"Errore:  compilare i campi.", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                OleDbConnection cn;
                OleDbCommand cmd;
                OleDbDataAdapter da;
                DataTable tabella;

                string connessione = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
                cn = new OleDbConnection(connessione);
                cn.Open();
                // carica nel db l'app richiesta con i suoi parametri
                string query = "INSERT INTO Path ([ID], [Start], [immagine]) " +
                                "VALUES (@id, @start, @foto)";
                cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", TxtIdRegistra.Texts);
                cmd.Parameters.AddWithValue("@start", TxtStartRegistra.Texts);
                cmd.Parameters.AddWithValue("@foto", TxtFotoRegistra.Texts);
                cmd.ExecuteNonQuery();

                // fa un check se sono stati caricati nel db correttamente
                query = "SELECT * " +
                        "From Path " +
                        "WHERE (ID = @id) and (start = @start) and (immagine = @foto)";
                cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", TxtIdRegistra.Texts);
                cmd.Parameters.AddWithValue("@start", TxtStartRegistra.Texts);
                cmd.Parameters.AddWithValue("@foto", TxtFotoRegistra.Texts);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);

                IDcheck = tabella.Rows[0]["ID"].ToString();
                StartCheck = tabella.Rows[0]["start"].ToString();
                Foto = tabella.Rows[0]["immagine"].ToString();
                cn.Close();

                if (IDcheck == TxtIdRegistra.Texts && StartCheck == TxtStartRegistra.Texts && Foto == TxtFotoRegistra.Texts) // se tutto corrisponde registrazione andata a buonfine
                {
                    await Task.Delay(600);
                    if (Foto == "Seleziona File") // seleziona quale messaggio inviare a seconda del campo facoltativo (foto backgound) se è stato compilato o meno
                    {
                        MessageBox.Show($"Inseriti con successo nel database: {Environment.NewLine} {Environment.NewLine} ID: {IDcheck}  {Environment.NewLine} Start: {StartCheck} {Environment.NewLine} Foto: Standard", "Status: Ok", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show($"Inseriti con successo nel database: {Environment.NewLine} {Environment.NewLine} ID: {IDcheck}  {Environment.NewLine} Start: {StartCheck} {Environment.NewLine} Foto: {Foto}", "Status: Ok", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    // rende come all'inizio i campi cosi da poter registrare altre app
                    TxtIdRegistra.Texts = "";
                    TxtStartRegistra.Texts = "Seleziona File";
                    TxtFotoRegistra.Texts = "Seleziona File";
                    // refresha le app disponibili nella cmb cosi da poterne usufruire 
                    RefreshComboBox();
                }
                else
                {
                    MessageBox.Show($"Errore nel inserimento, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Errore: {ex} {Environment.NewLine}!!!SE IL PROBLEMA PERSISTE PERFAVORE CONTATTARE IL CREATORE!!!", "Satus: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void BtnElimina_Click(object sender, EventArgs e)
        {
            if (CmbNomeAppEliminazione.Texts == "" || TxtStartElimina.Texts == "Seleziona Nome App") // fa un check se i campi sono compilati
            {
                MessageBox.Show($"Errore: Scegliere l'app da eliminare.", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                OleDbConnection cn;
                OleDbCommand cmd;
                string CnMain, Query;
                CnMain = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
                cn = new OleDbConnection(CnMain);
                cn.Open();

                // elimina l'app richiesta 
                Query = "DELETE FROM Path " +
                    "WHERE (ID = @id) and (start = @pathstart)";
                cmd = new OleDbCommand(Query, cn);
                cmd.Parameters.AddWithValue("@id", CmbNomeAppEliminazione.Texts);
                cmd.Parameters.AddWithValue("@pathstart", TxtStartElimina.Texts);
                int righe = cmd.ExecuteNonQuery(); // prende numero righe eliminate
                cn.Close();

                if (righe > 0)
                {
                    // ferma 600 ms per far caricare il db ed evitare errori
                    await Task.Delay(600);
                    MessageBox.Show($"Eliminata dal DataBase con successo {righe} riga.", "Status: Ok", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    // rende come all'inizio i campi cosi da poter registrare altre app
                    CmbNomeAppEliminazione.Texts = "";
                    TxtStartElimina.Texts = "Seleziona File";
                    RefreshComboBox();
                }
                else
                {
                    MessageBox.Show($"Errore nell'eliminazione ricontrollare i dati inseriti, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception errore)
            {
                MessageBox.Show($@"Errore: {errore} {Environment.NewLine}!!!SE IL PROBLEMA PERSISTE PERFAVORE CONTATTARE IL CREATORE!!!", "Satus: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnApriDialogoFile_Click(object sender, EventArgs e)
        {
            // apre l'exlorer da c:\\ e fa scegliere l'app desiderata
            OfdFileStart.Title = "Seleziona .EXE oppure URL Per inserire l'App";
            OfdFileStart.InitialDirectory = "c:\\";
            OfdFileStart.Filter = "File Personalizzati (*.exe, *.txt, *.url)|*.exe;*.txt;*.url|Tutti i file (*.*)|*.*";
            OfdFileStart.FilterIndex = 1;
            OfdFileStart.RestoreDirectory = true;

            if (OfdFileStart.ShowDialog() == DialogResult.OK) // se è andato a buonfine la scelta dell'app si inserisce nella txt
            {
                string FilePath = OfdFileStart.FileName;
                TxtStartRegistra.Texts = FilePath;
            }
        }

        private void BtnApriDialogoFileRgFoto_Click(object sender, EventArgs e)
        {
            // apre l'exlorer da c:\\ e fa scegliere l'app desiderata
            OfdFileFoto.Title = "Seleziona una foto in formato .png o .jpg";
            OfdFileFoto.InitialDirectory = "c:\\";
            OfdFileFoto.Filter = "File PNG (*.png, *.jpg, *.jpeg)|*png;*.jpg;*.jpeg";
            OfdFileFoto.FilterIndex = 1;
            OfdFileFoto.RestoreDirectory = true;

            if (OfdFileFoto.ShowDialog() == DialogResult.OK) // se è andato a buonfine la scelta dell'app si inserisce nella txt
            {
                string FilePath = OfdFileFoto.FileName;
                TxtFotoRegistra.Texts = FilePath;
            }
        }

        private void CmbNomeAppEliminazione_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string connect, query;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();
            // seleziono tutto quello con ID = @id (@id, preso dal cmb)
            query = "SELECT * " +
                "FROM path " +
                "WHERE ID = @id";
            cmd = new OleDbCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", CmbNomeAppEliminazione.Texts);
            da = new OleDbDataAdapter(cmd);
            tabella = new DataTable();
            da.Fill(tabella);

            string start = tabella.Rows[0]["start"].ToString();
            cn.Close();
            // inserisco path da eliminare nella txt
            TxtStartElimina.Texts = start;

        }

        private void BtnFaqRegistrazione_Click(object sender, EventArgs e)
        {
            // faccio vedere FrmFaqRegistrazione
            FrmFaqRegistrazione FrmFaq = new FrmFaqRegistrazione();
            FrmFaq.Show();
        }

        private void RefreshUsernameLogo()
        {
            // refresha username e logo
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connessione, Query;

            Connessione = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connessione);
            cn.Open();

            // carica logo
            Query = "SELECT Logo " +
                "FROM Utente " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            string PathLogo = Tabella.Rows[0]["Logo"].ToString();
            if (PathLogo == "")
            {
                if (DarkMode)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                else
                {
                    PcbLogo.Image = Resources.ospite;
                }
            }
            else
            {
                PcbLogo.ImageLocation = PathLogo;
            }

            // carica nome utente
            Query = "SELECT Nome " +
                   "FROM Utente " +
                   "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            string NomeUtente = Tabella.Rows[0]["Nome"].ToString();
            if (NomeUtente == "")
            {
                LblUsername.Text = "Ospite";
            }
            else
            {
                LblUsername.Text = NomeUtente;
            }
            cn.Close();
        }

        private void RefreshComboBox()
        {
            // pulisce cmb e lo carica con i nuovi dati
            CmbNomeAppEliminazione.Items.Clear(); // elimina tutti i dati dalla cmb
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string connect, query;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();

            // carica combo box elimina
            query = "SELECT ID " +
                "FROM Path";
            cmd = new OleDbCommand(query, cn);
            da = new OleDbDataAdapter(cmd);
            tabella = new DataTable();
            da.Fill(tabella);
            int righe = tabella.Rows.Count;
            // carica dati nella cmb elimina
            for (int i = 0; i <= righe - 1; i++)
            {
                string id = tabella.Rows[i]["ID"].ToString();
                CmbNomeAppEliminazione.Items.Add(id);
            }

            cn.Close();
        }
        private void CaricaVariabiliColori()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connect, Query;

            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();
            // carico nel db il colore scelto
            Query = "SELECT Colore " +
                "FROM Utente " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            string Colore = Tabella.Rows[0]["Colore"].ToString();
            cn.Close();
            // assegno i colori nelle variabili in base alla scelta


            if (Colore == "Arancione")
            {
                RefreshColoreLauncher(); // carica colori dei elementi
                RefreshBtnImage(); // cambia icone dei btn
            }
            else if (Colore == "Verde") 
            {
                RefreshColoreLauncher(); // carica colori dei elementi
                RefreshBtnImage(); // cambia icone dei btn
            }
            else if (Colore == "Blu")
            {
                RefreshColoreLauncher(); // carica colori dei elementi
                RefreshBtnImage(); // cambia icone dei btn
            }
            else if (Colore == "Dark Mode") 
            {
                DarkMode = true; // quando si refresha il logo diventa nero per la darkmode
                RefreshColoreLauncher(); // carica colori dei elementi
                RefreshBtnImage(); // cambia icone dei btn
            }
            else
            {
                MessageBox.Show($"Errore nella scelta del colore, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void RefreshColoreLauncher()
        {
            //////////////// carica colori nei elementi
            ///// username-online
            LblUsername.ForeColor = Variabili.Scritte;
            LblDescUsername.ForeColor = Variabili.Online;
            // pannelli
            PnlEliminazione.BackColor = Variabili.PnlSX;
            PnlRegistrazione.BackColor = Variabili.PnlSX;
            PnlMenu.BackColor = Variabili.PnlSX;

            this.BackColor = Variabili.PnlDX;
            // lablel
            LblCampoObbligatorioID.ForeColor = Variabili.Scritte;
            LblCampoObbligatorioStart.ForeColor = Variabili.Scritte;
            LblDescCampiObbligatori.ForeColor = Variabili.Scritte;
            LblDescEliminazione.ForeColor = Variabili.Scritte;
            LblDescFotoBackRegistrazione.ForeColor = Variabili.Scritte;
            LblDescId.ForeColor = Variabili.Scritte;
            LblDescIns.ForeColor = Variabili.Scritte;
            LblDescNomeAppEliminazione.ForeColor = Variabili.Scritte;
            LblDescStringaStartEliminazione.ForeColor = Variabili.Scritte;
            LblDescStrStart.ForeColor = Variabili.Scritte;

            // bottoni pnlSX back color
            BtnRegistrazione.BackColor = Variabili.PnlSX;
            BtnEliminazione.BackColor = Variabili.PnlSX;

            BtnApriDialogoFileRg.BackColor = Variabili.PnlSX;
            BtnApriDialogoFileRgFoto.BackColor = Variabili.PnlSX;
            BtnElimina.BackColor = Variabili.PnlSX;
            BtnRegistra.BackColor = Variabili.PnlSX;
            BtnFaqRegistrazione.BackColor = Variabili.PnlSX;
            // textbox
            TxtFotoRegistra.BackColor = Variabili.PnlDX;
            TxtFotoRegistra.BorderColor = Variabili.Scritte;
            TxtFotoRegistra.BorderFocusColor = Color.LightBlue;

            TxtIdRegistra.BackColor = Variabili.PnlDX;
            TxtIdRegistra.BorderColor = Variabili.Scritte;
            TxtIdRegistra.BorderFocusColor = Color.LightBlue;

            TxtStartElimina.BackColor = Variabili.PnlDX;
            TxtStartElimina.BorderColor = Variabili.Scritte;
            TxtStartElimina.BorderFocusColor = Color.LightBlue;

            TxtStartRegistra.BackColor = Variabili.PnlDX;
            TxtStartRegistra.BorderColor = Variabili.Scritte;
            TxtStartRegistra.BorderFocusColor = Color.LightBlue;
            // combobox
            CmbNomeAppEliminazione.BackColor = Variabili.PnlDX;
            CmbNomeAppEliminazione.BorderColor = Variabili.Scritte;
            CmbNomeAppEliminazione.IconColor = Variabili.Scritte;
            CmbNomeAppEliminazione.ListBackColor = Variabili.PnlSX;
            // bottoni pnlSX fore color
            BtnRegistrazione.ForeColor = Variabili.Scritte;
            BtnEliminazione.ForeColor = Variabili.Scritte;

            BtnApriDialogoFileRg.ForeColor = Variabili.Scritte;
            BtnApriDialogoFileRgFoto.ForeColor = Variabili.Scritte;
            BtnElimina.ForeColor = Variabili.Scritte;
            BtnRegistra.ForeColor = Variabili.Scritte;
            BtnFaqRegistrazione.ForeColor = Variabili.Scritte;
        }
        private void RefreshBtnImage()
        {
            CheckLogoOspite(); // controlla se ha il logo personalizzato o meno

            ////// carica immagini con i loro colori nei elementi
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connect, Query;

            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();
            // carico nel db il colore scelto
            Query = "SELECT Colore " +
                "FROM Utente " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            string Colore = Tabella.Rows[0]["Colore"].ToString();
            cn.Close();
            // carica icone dei btn
            if (Colore == "Arancione")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnRegistrazione.Image = Resources.DbNero;
                BtnEliminazione.Image = Resources.DbNero;
                BtnElimina.Image = Resources.DbNero;
                BtnRegistra.Image = Resources.DbNero;
                BtnFaqRegistrazione.Image = Resources.FaqNero;
                BtnApriDialogoFileRg.Image = Resources.folderNera;
                BtnApriDialogoFileRgFoto.Image = Resources.folderNera;
            }
            else if (Colore == "Verde")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnRegistrazione.Image = Resources.DbNero;
                BtnEliminazione.Image = Resources.DbNero;
                BtnElimina.Image = Resources.DbNero;
                BtnRegistra.Image = Resources.DbNero;
                BtnFaqRegistrazione.Image = Resources.FaqNero;
                BtnApriDialogoFileRg.Image = Resources.folderNera;
                BtnApriDialogoFileRgFoto.Image = Resources.folderNera;
            }
            else if (Colore == "Blu")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.ospite;
                }
                BtnRegistrazione.Image = Resources.database;
                BtnEliminazione.Image = Resources.database;
                BtnElimina.Image = Resources.database;
                BtnRegistra.Image = Resources.database;
                BtnFaqRegistrazione.Image = Resources.faq;
                BtnApriDialogoFileRg.Image = Resources.Folder;
                BtnApriDialogoFileRgFoto.Image = Resources.Folder;
            }
            else if (Colore == "Dark Mode")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnRegistrazione.Image = Resources.DbNero;
                BtnEliminazione.Image = Resources.DbNero;
                BtnElimina.Image = Resources.DbNero;
                BtnRegistra.Image = Resources.DbNero;
                BtnFaqRegistrazione.Image = Resources.FaqNero;
                BtnApriDialogoFileRg.Image = Resources.FolderDarkMode;
                BtnApriDialogoFileRgFoto.Image = Resources.FolderDarkMode;
            }
            else
            {
                MessageBox.Show($"Errore nella scelta del colore, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CheckLogoOspite()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connect, Query;

            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();

            Query = "SELECT Logo " +
                "FROM Utente " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            string logo = Tabella.Rows[0]["Logo"].ToString();
            cn.Close();

            if (logo == "") // controlla se il logo è personalizzato
            {
                Logo = true;
            }
        }
    }
}
