using RoyaleLauncher.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RoyaleLauncher
{
    public partial class FrmMiddleMan : Form
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


        public FrmMiddleMan()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            RefreshUsernameLogo();
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            Variabili.FrmMiddleManSettings = false; // inizializzo passaggio 

            CaricaComboBoxSettings();
            CaricaTrasparenza(); // carica livello di trasparenza del form
            RefreshColoreLauncherLoad(); // carica colore del launcher
            // inzializzo elementi
            BtnRegistraGioco.Visible = false;
            LblDescSettingsUser.Visible = false;
            BtnSettingsLogoUsername.Visible = false;
            BtnFaqUscitaAutomatica.Visible = false;
            BtnSettingDisinstalla.Visible = false;
            LblDescColoreLauncher.Visible = false;
            CmbColoreLauncher.Visible = false;
            PnlSettingsTrasparenza.Visible = false;
            PnlSettingsUscitaAuto.Visible = false;
        }
        private void CaricaTrasparenza()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connessione, Query;

            Connessione = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connessione);
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
            Variabili.FrmMiddleManSettings = true; // apro il passaggio a FrmApplicazioni
            this.Close();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            // inzializzo elementi
            BtnDashboard.BackColor = Variabili.BtnAttivo;
            BtnSettings.BackColor = Variabili.BtnDisattivo;
            LblDescSettingsUser.Visible = false;
            BtnSettingsLogoUsername.Visible = false;
            BtnFaqUscitaAutomatica.Visible = false;
            BtnSettingDisinstalla.Visible = false;
            PnlSettingsTrasparenza.Visible = false;
            PnlSettingsUscitaAuto.Visible = false;
            LblDescColoreLauncher.Visible = false;
            CmbColoreLauncher.Visible = false;
            BtnRegistraGioco.Visible = true;

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            // inzializzo elementi
            BtnDashboard.BackColor = Variabili.BtnDisattivo;
            BtnSettings.BackColor = Variabili.BtnAttivo;
            BtnRegistraGioco.Visible = false;
            LblDescSettingsUser.Visible = true;
            BtnSettingsLogoUsername.Visible = true;
            BtnFaqUscitaAutomatica.Visible = true;
            BtnSettingDisinstalla.Location = new Point(619, 394);
            BtnSettingDisinstalla.Visible = true;
            LblDescColoreLauncher.Visible = true;
            CmbColoreLauncher.Visible = true;
            PnlSettingsTrasparenza.Visible = true;
            PnlSettingsUscitaAuto.Visible = true;

            // carico rdb uscita auto
            CaricaRdbUscitaAuto();
            // carico rdb trasparenza
            CaricaTrasparenzaRDB();
        }
        private void CaricaRdbUscitaAuto()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connessione, Query;

            Connessione = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connessione);
            cn.Open();

            // carica rdb buttons
            Query = "SELECT UscitaAuto " +
                    "FROM Utente " +
                    "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            bool UscitaAuto = Convert.ToBoolean(Tabella.Rows[0]["UscitaAuto"]);
            cn.Close();

            if (UscitaAuto)
            {
                RdbUscitaAutomaticaAttivato.Checked = true;
            }
            else
            {
                RdbUscitaAutomaticaDisattivata.Checked = true;
            }
        }
        private void CaricaTrasparenzaRDB()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connessione, Query;

            Connessione = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connessione);
            cn.Open();

            // carica rdb buttons
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
                RdbTrasparenzaAttiva1.Checked = true;
            }
            else
            {
                RdbTrasparenzaDisattivata1.Checked = true;
            }
        }

        private void BtnRegistraGioco_Click(object sender, EventArgs e)
        {
            // apro FrmDatabase chiudo questo e apro il passaggio a FrmApplicazioni con la variabile
            FrmDatabase frmDatabase = new FrmDatabase();
            frmDatabase.Show();
            Variabili.AperturaDB = true;
            this.Hide();
        }

        private void BtnSettingsUsername_Click(object sender, EventArgs e)
        {
            // apro FrmSettingsDatabase e chiudo questo
            FrmSettingsDatabase FrmSettingsDatabase = new FrmSettingsDatabase();
            FrmSettingsDatabase.Show();
            this.Hide();
        }

        private void RdbUscitaAutomaticaAttivato_CheckedChanged(object sender, EventArgs e)
        {
            // rendo true la uscita automatica
            OleDbConnection cn;
            OleDbCommand cmd;
            string connect, query;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();

            query = "UPDATE Utente " +
                "SET UscitaAuto = True " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(query, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void RdbUscitaAutomaticaDisattivata_CheckedChanged(object sender, EventArgs e)
        {
            // rendo false la uscita automatica
            OleDbConnection cn;
            OleDbCommand cmd;
            string connect, query;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();

            query = "UPDATE Utente " +
                "SET UscitaAuto = False " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(query, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void BtnFaqUscitaAutomatica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FAQ: Per 'Uscita Automatica' s'intende che appena si avvia un app dal launcher si può scegliere se far chiudere automaticamente il launcher o meno.", "FAQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void BtnSettingDisinstalla_Click(object sender, EventArgs e)
        {
            // dissinstalla app richiamando processo del unistaller creato al setup
            DialogResult risultato = MessageBox.Show($"Sei sicuro di voler disinstallare il launcher?", "Status: Ok", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (risultato == DialogResult.OK)
            {
                Process.Start($@"{Application.StartupPath}\unins000.exe");
                Application.Exit();
            }
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
            cn.Close();
            if (NomeUtente == "")
            {
                LblUsername.Text = "Ospite";
            }
            else
            {
                LblUsername.Text = NomeUtente;
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

        private void RdbTrasparenzaAttiva_CheckedChanged(object sender, EventArgs e)
        {
            // rende true la trasparenza
            OleDbConnection cn;
            OleDbCommand cmd;
            string Connect, Query;

            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();

            Query = "UPDATE Utente " +
                "SET Trasparenza = true " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            cmd.ExecuteNonQuery();
            this.Opacity = 0.85;
            cn.Close();
        }

        private void RdbTrasparenzaDisattivata_CheckedChanged(object sender, EventArgs e)
        {
            // rende false la trasparenza
            OleDbConnection cn;
            OleDbCommand cmd;
            string Connect, Query;

            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();

            Query = "UPDATE Utente " +
                "SET Trasparenza = false " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            cmd.ExecuteNonQuery();
            this.Opacity = 1;
            cn.Close();
        }
        private void CmbColoreLauncher_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CaricaVarColori();
        }
        private void CaricaVarColori()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            string Connect, Query;

            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();
            // carico nel db il colore scelto
            Query = "UPDATE Utente " +
                "SET Colore = @colore";
            cmd = new OleDbCommand(Query, cn);
            cmd.Parameters.AddWithValue("@colore", CmbColoreLauncher.Texts);
            cmd.ExecuteNonQuery();
            cn.Close();
            // assegno i colori nelle variabili in base alla scelta
            string Colore = CmbColoreLauncher.Texts;

            Colori(Colore);
        }
        private void RefreshColoreLauncherLoad()
        {
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
            Colori(Colore);

        }
        private void Colori(String Colore)
        {
            if (Colore == "Arancione")
            {
                Variabili.Online = Color.FromArgb(0, 0, 0);
                Variabili.PnlSX = Color.FromArgb(255, 110, 0);
                Variabili.PnlDX = Color.FromArgb(255, 140, 0);
                Variabili.Scritte = Color.FromArgb(0, 0, 0);
                Variabili.RdbCheckControl = Color.FromArgb(0, 0, 0);
                Variabili.RdbUnCheckControl = Color.FromArgb(0, 0, 0);
                Variabili.BtnAttivo = Color.FromArgb(255, 140, 0);
                Variabili.BtnDisattivo = Color.FromArgb(255, 110, 0);
                RefreshColoreLauncher(); // carica colori dei elementi
                RefreshBtnImage(); // cambia icone dei btn
            }
            else if (Colore == "Verde")
            {
                Variabili.Online = Color.FromArgb(0, 0, 0);
                Variabili.PnlSX = Color.FromArgb(34, 139, 34);
                Variabili.PnlDX = Color.FromArgb(50, 205, 50);
                Variabili.Scritte = Color.FromArgb(0, 0, 0);
                Variabili.RdbCheckControl = Color.FromArgb(0, 0, 0);
                Variabili.RdbUnCheckControl = Color.FromArgb(0, 0, 0);
                Variabili.BtnAttivo = Color.FromArgb(50, 205, 50);
                Variabili.BtnDisattivo = Color.FromArgb(34, 139, 34);
                RefreshColoreLauncher(); // carica colori dei elementi
                RefreshBtnImage(); // cambia icone dei btn
            }
            else if (Colore == "Blu")
            {
                Variabili.Online = Color.FromArgb(158, 161, 178);
                Variabili.PnlSX = Color.FromArgb(24, 30, 54);
                Variabili.PnlDX = Color.FromArgb(46, 51, 73);
                Variabili.Scritte = Color.FromArgb(0, 126, 249);
                Variabili.RdbCheckControl = Color.FromArgb(24, 30, 54);
                Variabili.RdbUnCheckControl = Color.FromArgb(128, 128, 128);
                Variabili.BtnAttivo = Color.FromArgb(46, 51, 73);
                Variabili.BtnDisattivo = Color.FromArgb(24, 30, 54);
                RefreshColoreLauncher(); // carica colori dei elementi
                RefreshBtnImage(); // cambia icone dei btn
            }
            else if (Colore == "Dark Mode")
            {
                DarkMode = true; // quando si refresha il logo diventa nero per la darkmode
                Variabili.Online = Color.FromArgb(0, 0, 0);
                Variabili.PnlSX = Color.FromArgb(23, 23, 23);
                Variabili.PnlDX = Color.FromArgb(33, 33, 33);
                Variabili.Scritte = Color.FromArgb(180, 180, 180);
                Variabili.RdbCheckControl = Color.FromArgb(0, 0, 0);
                Variabili.RdbUnCheckControl = Color.FromArgb(0, 0, 0);
                Variabili.BtnAttivo = Color.FromArgb(33, 33, 33);
                Variabili.BtnDisattivo = Color.FromArgb(23, 23, 23);
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
            // pannelli
            PnlMenu.BackColor = Variabili.PnlSX;
            this.BackColor = Variabili.PnlDX;
            // bottoni pnlSX back color
            BtnDashboard.BackColor = Variabili.PnlSX;
            BtnSettings.BackColor = Variabili.PnlSX;
            // bottoni pnlSX fore color
            BtnDashboard.ForeColor = Variabili.Scritte;
            BtnSettings.ForeColor = Variabili.Scritte;
            // label
            LblUsername.ForeColor = Variabili.Scritte;
            LblDescUsername.ForeColor = Variabili.Online;
            LblDescSettingsUser.ForeColor = Variabili.Scritte;
            LblDescColoreLauncher.ForeColor = Variabili.Scritte;
            LblDescCambiaTrasparenza.ForeColor = Variabili.Scritte;
            LblDescUscitaAutomatica.ForeColor = Variabili.Scritte;
            // btn pnlDX forecolor
            BtnSettingsLogoUsername.ForeColor = Variabili.Scritte;
            BtnRegistraGioco.ForeColor = Variabili.Scritte;
            BtnFaqUscitaAutomatica.ForeColor = Variabili.Scritte;
            // btn pnlDX backcolor
            BtnSettingsLogoUsername.BackColor = Variabili.PnlDX;
            BtnRegistraGioco.BackColor = Variabili.PnlDX;
            BtnFaqUscitaAutomatica.BackColor = Variabili.PnlDX;
            BtnSettingDisinstalla.BackColor = Variabili.PnlDX;
            // combo box
            CmbColoreLauncher.BackColor = Variabili.PnlDX;
            CmbColoreLauncher.BorderColor = Variabili.Scritte;
            CmbColoreLauncher.IconColor = Variabili.Scritte;
            CmbColoreLauncher.ListBackColor = Variabili.PnlSX;

            ////////////////// radio button
            /////////trasparenza
            RdbTrasparenzaAttiva1.BackColor = Variabili.PnlDX;
            RdbTrasparenzaAttiva1.ForeColor = Variabili.Scritte;

            RdbTrasparenzaDisattivata1.BackColor = Variabili.PnlDX;
            RdbTrasparenzaDisattivata1.ForeColor = Variabili.Scritte;

            RdbTrasparenzaAttiva1.CheckedColor = Variabili.RdbCheckControl;
            RdbTrasparenzaAttiva1.UnCheckedColor = Variabili.RdbUnCheckControl;

            RdbTrasparenzaDisattivata1.CheckedColor = Variabili.RdbCheckControl;
            RdbTrasparenzaDisattivata1.UnCheckedColor = Variabili.RdbUnCheckControl;
            // uscita auto
            RdbUscitaAutomaticaAttivato.BackColor = Variabili.PnlDX;
            RdbUscitaAutomaticaAttivato.ForeColor = Variabili.Scritte;

            RdbUscitaAutomaticaDisattivata.BackColor = Variabili.PnlDX;
            RdbUscitaAutomaticaDisattivata.ForeColor = Variabili.Scritte;

            RdbUscitaAutomaticaAttivato.CheckedColor = Variabili.RdbCheckControl;
            RdbUscitaAutomaticaAttivato.UnCheckedColor = Variabili.RdbUnCheckControl;

            RdbUscitaAutomaticaDisattivata.CheckedColor = Variabili.RdbCheckControl;
            RdbUscitaAutomaticaDisattivata.UnCheckedColor = Variabili.RdbUnCheckControl;
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
                BtnDashboard.Image = Resources.HomeNero;
                BtnSettings.Image = Resources.SettingsNero;
                BtnSettingsLogoUsername.Image = Resources.OspiteX25Nero;
                BtnFaqUscitaAutomatica.Image = Resources.FaqNero;
                BtnRegistraGioco.Image = Resources.DbNero;
            }
            else if (Colore == "Verde")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnDashboard.Image = Resources.HomeNero;
                BtnSettings.Image = Resources.SettingsNero;
                BtnSettingsLogoUsername.Image = Resources.OspiteX25Nero;
                BtnFaqUscitaAutomatica.Image = Resources.FaqNero;
                BtnRegistraGioco.Image = Resources.DbNero;
            }
            else if (Colore == "Blu")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.ospite;
                }
                BtnDashboard.Image = Resources.home;
                BtnSettings.Image = Resources.settings;
                BtnSettingsLogoUsername.Image = Resources.ospiteX25;
                BtnFaqUscitaAutomatica.Image = Resources.faq;
                BtnRegistraGioco.Image = Resources.database;
            }
            else if (Colore == "Dark Mode")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnDashboard.Image = Resources.HomeDarkMode;
                BtnSettings.Image = Resources.settingsDarkMode;
                BtnSettingsLogoUsername.Image = Resources.OspiteX25Nero;
                BtnFaqUscitaAutomatica.Image = Resources.FaqNero;
                BtnRegistraGioco.Image = Resources.DbNero;
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
        private void CaricaComboBoxSettings()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Query, Connect;
            Connect = $@"PROVIDER=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();
            // carica la combobox colori launcher
            CmbColoreLauncher.Items.Add("Arancione");
            CmbColoreLauncher.Items.Add("Verde");
            CmbColoreLauncher.Items.Add("Blu");
            CmbColoreLauncher.Items.Add("Dark Mode");
            // carica colore attuale
            Query = "SELECT Colore " +
                "FROM Utente " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            string colore = Tabella.Rows[0]["Colore"].ToString();
            cn.Close();
            CmbColoreLauncher.Texts = colore;
        }
    }
}
