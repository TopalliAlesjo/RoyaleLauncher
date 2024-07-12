using RoyaleLauncher.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RoyaleLauncher
{
    public partial class FrmFaqRegistrazione : Form
    {
        bool Logo = false, Darkmode = false;

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


        public FrmFaqRegistrazione()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            RefreshUsernameLogo();
        }
        private void FrmSettingsDatabase_Load(object sender, EventArgs e)
        {

            CaricaTrasparenza();// carica trasparenza form
            CaricaColori();// carica stile di colore scelto

            // inizializzo elementi
            PnlFaqNomeStart.Visible = true;
            PnlFaqBackgoundFoto.Visible = false;
            PnlFaqNomeStart.Location = new Point(244, 188);
            PnlFaqBackgoundFoto.Location = new Point(244, 188);
            BtnFaqNomeStart.BackColor = Color.FromArgb(46, 51, 73);
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
            // carica rdb buttons e trasparenza
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
            this.Close();
        }

        private void BtnFaqNomeStart_Click(object sender, EventArgs e)
        {
            // inizializzo elementi
            BtnFaqNomeStart.BackColor = Variabili.BtnAttivo;
            BtnFaqFotoBackgound.BackColor = Variabili.BtnDisattivo;
            PnlFaqBackgoundFoto.Visible = false;
            PnlFaqNomeStart.Visible = true;
            PnlFaqBackgoundFoto.BringToFront();
        }

        private void BtnFaqFotoBackgound_Click(object sender, EventArgs e)
        {
            // inizializzo elementi
            BtnFaqNomeStart.BackColor = Variabili.BtnDisattivo;
            BtnFaqFotoBackgound.BackColor = Variabili.BtnAttivo;
            PnlFaqNomeStart.Visible = false;
            PnlFaqBackgoundFoto.Visible = true;
            PnlFaqNomeStart.BringToFront();
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
                if (Darkmode)
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

        private void PnlToolBar_MouseDown(object sender, MouseEventArgs e) // trascinare finestra
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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
                Darkmode = true; // quando si refresha il logo diventa nero per la darkmode
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
            PnlFaqNomeStart.BackColor = Variabili.PnlSX;
            PnlFaqBackgoundFoto.BackColor = Variabili.PnlSX;
            this.BackColor = Variabili.PnlDX;
            // lablel
            LblDescFotoBackgound.ForeColor = Variabili.Scritte;
            LblDescNomeStart.ForeColor = Variabili.Scritte;

            // bottoni pnlSX back color
            BtnFaqNomeStart.BackColor = Variabili.PnlSX;
            BtnFaqFotoBackgound.BackColor = Variabili.PnlSX;

            // bottoni pnlSX fore color
            BtnFaqNomeStart.ForeColor = Variabili.Scritte;
            BtnFaqFotoBackgound.ForeColor = Variabili.Scritte;

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
                BtnFaqNomeStart.Image = Resources.FaqNero;
                BtnFaqFotoBackgound.Image = Resources.FaqNero;
            }
            else if (Colore == "Verde")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnFaqNomeStart.Image = Resources.FaqNero;
                BtnFaqFotoBackgound.Image = Resources.FaqNero;
            }
            else if (Colore == "Blu")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.ospite;
                }
                BtnFaqNomeStart.Image = Resources.FaqNero;
                BtnFaqFotoBackgound.Image = Resources.FaqNero;
            }
            else if (Colore == "Dark Mode")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnFaqNomeStart.Image = Resources.FaqNero;
                BtnFaqFotoBackgound.Image = Resources.FaqNero;
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
