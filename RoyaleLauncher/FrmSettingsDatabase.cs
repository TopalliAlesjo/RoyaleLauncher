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
    public partial class FrmSettingsDatabase : Form
    {
        bool Logo = false,DarkMode = false;

        // trascinare finestra
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // fare bottoni
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


        public FrmSettingsDatabase()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            RefreshLogo();
            RefreshUsername();
        }
        private void FrmSettingsDatabase_Load(object sender, EventArgs e)
        {
            
            CaricaTrasparenza(); // carica la trasparenza del form
            CaricaColori(); // carica stile colori form
            Variabili.FrmUsernamePERapps = false; // inizializza variabile
            // inzializza elementi
            PnlLogo.Visible = false;
            PnlUsername.Visible = true;
            PnlUsername.Location = new Point(244, 188);
            BtnUsername.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void CaricaTrasparenza()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connect, Query;

            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();

            // carica trasparenza
            Query = "SELECT Trasparenza " +
                "FROM Utente " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            bool Trasparenza = Convert.ToBoolean(Tabella.Rows[0]["Trasparenza"]);
            cn.Close();

            if (Trasparenza)
            {
                this.Opacity = 0.85;
            }
            else
            {
                this.Opacity = 1;
            }

        }
        private void BtnEsci_Click(object sender, EventArgs e)
        {
            Variabili.FrmUsernamePERapps = true; // serve per refreshare username e logo di frmapplicazioni
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connessione, Query;


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
            int righe = Tabella.Rows.Count;
            cn.Close();

            if (righe > 4) // se le app sono più di 4 si chiude questo e si apre FrmApplicazioni
            {
                this.Close();
                Variabili.Form.Show();
            }
            else
            {
                // chiude questo, chiude FrmApplicazioni, Rende vero il passaggio per FrmMain e avvia Frmmain
                this.Close();
                Variabili.Form.Hide();
                Variabili.FrmSettingsPassaggioEsci = true;
                FrmMain main = new FrmMain();
                main.Show();
            }
        }



        private void BtnApriDialogoFileLogo_Click(object sender, EventArgs e)
        {
            // apre l'exlorer da c:\\ e fa scegliere il logo desiderato
            OfdFileLogo.Title = "Seleziona una foto in formato .png o .jpg";
            OfdFileLogo.InitialDirectory = "c:\\";
            OfdFileLogo.Filter = "File PNG (*.png)|*.png|File JPG (*.jpg)|*.jpg";
            OfdFileLogo.FilterIndex = 1;
            OfdFileLogo.RestoreDirectory = true;

            if (OfdFileLogo.ShowDialog() == DialogResult.OK)
            {
                string FilePath = OfdFileLogo.FileName;
                TxtCambiaLogo.Texts = FilePath;
            }
        }

        private void BtnLogo_Click(object sender, EventArgs e)
        {
            // inizializzazione elementi
            BtnUsername.BackColor = Variabili.BtnDisattivo;
            BtnLogo.BackColor = Variabili.BtnAttivo;
            PnlUsername.Visible = false;
            PnlLogo.Visible = true;
            PnlLogo.BringToFront();
            PnlLogo.Location = new Point(244, 188);
        }

        private void BtnUsername_Click(object sender, EventArgs e)
        {
            // inizializzazione elementi
            BtnUsername.BackColor = Variabili.BtnAttivo;
            BtnLogo.BackColor = Variabili.BtnDisattivo;
            PnlLogo.Visible = false;
            PnlUsername.Visible = true;
            PnlUsername.BringToFront();
            PnlUsername.Location = new Point(244, 188);
        }

        private async void BtnCambiaLogo_Click(object sender, EventArgs e)
        {
            if (TxtCambiaLogo.Texts.Trim() == "" || TxtCambiaLogo.Texts == "Seleziona File") // controlla se i campi sono stati compilati
            {
                MessageBox.Show("Errore seleziona il logo, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                OleDbConnection cn;
                OleDbCommand cmd;
                string connect, query;

                connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
                cn = new OleDbConnection(connect);
                cn.Open();
                // scrivo nome e path logo
                query = "UPDATE Utente " +
                    "SET Logo = @pathlogo";
                cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("@pathlogo", TxtCambiaLogo.Texts);
                cmd.ExecuteNonQuery();
                await Task.Delay(600); // refresh db
                RefreshLogo();
                MessageBox.Show($"Logo Aggiornato con successo", "Status: Ok", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Errore: {ex} {Environment.NewLine}!!!SE IL PROBLEMA PERSISTE PERFAVORE CONTATTARE IL CREATORE!!!", "Satus: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnCambiaUsername_Click(object sender, EventArgs e)
        {
            if (TxtCambiaNome.Texts.Length > 12) // controlla se è stato superato il massimo di caratteri
            {
                MessageBox.Show("Errore hai superato il max dei 12 caratteri, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TxtCambiaNome.Texts.Trim() == "") // controlla se il campo username se è compilato
            {
                MessageBox.Show("Errore inserisci il tuo Username, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                OleDbConnection cn;
                OleDbCommand cmd;
                string connect, query;

                connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
                cn = new OleDbConnection(connect);
                cn.Open();

                query = "UPDATE Utente " +
                    "SET Nome = @nome";
                cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("@nome", TxtCambiaNome.Texts);
                cmd.ExecuteNonQuery();
                await Task.Delay(600);
                RefreshUsername();
                MessageBox.Show($"Nome Aggiornato con successo", "Status: Ok", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Errore: {ex} {Environment.NewLine}!!!SE IL PROBLEMA PERSISTE PERFAVORE CONTATTARE IL CREATORE!!!", "Satus: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void RefreshLogo()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string connect, query;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();
            // carica logo
            query = "SELECT Logo " +
                   "FROM Utente " +
                   "WHERE ID = 1";
            cmd = new OleDbCommand(query, cn);
            da = new OleDbDataAdapter(cmd);
            tabella = new DataTable();
            da.Fill(tabella);
            string PathLogo = tabella.Rows[0]["Logo"].ToString();
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
        }

        private void RefreshUsername()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string connect, query;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();
            // carica username
            query = "SELECT Nome " +
                   "FROM Utente " +
                   "WHERE ID = 1";
            cmd = new OleDbCommand(query, cn);
            da = new OleDbDataAdapter(cmd);
            tabella = new DataTable();
            da.Fill(tabella);
            string NomeUtente = tabella.Rows[0]["Nome"].ToString();
            if (NomeUtente == "")
            {
                LblUsername.Text = "Ospite";
            }
            else
            {
                LblUsername.Text = NomeUtente;
            }
        }
        private void CaricaColori()
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
            PnlMenu.BackColor = Variabili.PnlSX;
            PnlLogo.BackColor = Variabili.PnlSX;
            PnlUsername.BackColor = Variabili.PnlSX;

            this.BackColor = Variabili.PnlDX;
            // lablel
            LblDescCambiaLogo.ForeColor = Variabili.Scritte;
            LblDescId.ForeColor = Variabili.Scritte;
            LblDescIns.ForeColor = Variabili.Scritte;
            LblDescInsLogo.ForeColor = Variabili.Scritte;

            // bottoni pnlSX back color
            BtnUsername.BackColor = Variabili.PnlSX;
            BtnLogo.BackColor = Variabili.PnlSX;
            BtnApriDialogoFileLogo.BackColor = Variabili.PnlSX;
            BtnCambiaLogo.BackColor = Variabili.PnlSX;
            BtnCambiaUsername.BackColor = Variabili.PnlSX;

            // bottoni pnlSX fore color
            BtnUsername.ForeColor = Variabili.Scritte;
            BtnLogo.ForeColor = Variabili.Scritte;
            BtnApriDialogoFileLogo.ForeColor = Variabili.Scritte;
            BtnCambiaLogo.ForeColor = Variabili.Scritte;
            BtnCambiaUsername.ForeColor = Variabili.Scritte;

            // textbox
            TxtCambiaLogo.BackColor = Variabili.PnlDX;
            TxtCambiaNome.BackColor = Variabili.PnlDX;

            TxtCambiaLogo.BorderColor = Variabili.Scritte;
            TxtCambiaNome.BorderColor = Variabili.Scritte;

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
                BtnUsername.Image = Resources.DbNero;
                BtnLogo.Image = Resources.DbNero;
                BtnApriDialogoFileLogo.Image = Resources.folderNera;
                BtnCambiaLogo.Image = Resources.DbNero;
                BtnCambiaUsername.Image = Resources.DbNero;
            }
            else if (Colore == "Verde")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnUsername.Image = Resources.DbNero;
                BtnLogo.Image = Resources.DbNero;
                BtnApriDialogoFileLogo.Image = Resources.folderNera;
                BtnCambiaLogo.Image = Resources.DbNero;
                BtnCambiaUsername.Image = Resources.DbNero;
            }
            else if (Colore == "Blu")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.ospite;
                }
                BtnUsername.Image = Resources.database;
                BtnLogo.Image = Resources.database;
                BtnApriDialogoFileLogo.Image = Resources.Folder;
                BtnCambiaLogo.Image = Resources.database;
                BtnCambiaUsername.Image = Resources.database;
            }
            else if (Colore == "Dark Mode")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnUsername.Image = Resources.DbNero;
                BtnLogo.Image = Resources.DbNero;
                BtnApriDialogoFileLogo.Image = Resources.FolderDarkMode;
                BtnCambiaLogo.Image = Resources.DbNero;
                BtnCambiaUsername.Image = Resources.DbNero;
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
