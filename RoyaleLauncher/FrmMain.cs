using RoyaleLauncher.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyaleLauncher
{
    public partial class FrmMain : Form
    {
        bool app1, app2, app3, app4, checkapps, AppNoLogo1, AppNoLogo2, AppNoLogo3, AppNoLogo4, Logo = false, Darkmode = false;

        int righe, checka;
        Bitmap ColoreApp;
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


        public FrmMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            RefreshUsernameLogo();
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {

            // caricamento app
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connessione, Query = "";
            int Apps = 0;
            Connessione = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connessione);
            cn.Open();

            // inizializzo db
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();

            checkapps = false; // inizializzo check per app con posizione
            Variabili.Pass2 = 0; // inizializzo variabile per rendere utilizzabile dinuovo FrmApplicazioni
            checka = (Variabili.Pass += 1); // incremento variabile
            Logo = false; // inizializzo variabile Logo per cambiamenti di logo

            // inizializzo elementi
            InizializzazioneElementi();
            // anticipo caricamento di entrambe le combo box per setting riordina e colori launcher per caricare colore del launcher
            CaricaComboBoxSettings(Query, cn, cmd, da, Tabella);
            RefreshColoreLauncherLoad(); // carica colore del launcher
            // carica trasparenza form 
            RefreshTrasparenza(Query, cn, cmd, da, Tabella);

            if (Variabili.FrmAppsPassaggioBtnHome || checka == 1 || Variabili.FrmDatabasePassaggioBtnEsci || Variabili.FrmPrimoStartToMain || Variabili.FrmSettingsPassaggioEsci)
            {
                // inizializzo variabili

                Variabili.FrmSettingsPassaggioEsci = false;
                Variabili.FrmPrimoStartToMain = false;

                // prima query per sapere quantità di righe
                Query = "SELECT * " +
                        "FROM Path ";
                cmd = new OleDbCommand(Query, cn);
                da = new OleDbDataAdapter(cmd);
                Tabella = new DataTable();
                da.Fill(Tabella);
                Apps = Tabella.Rows.Count;

                ////////////////////
                /// CARICO BOTTONI CON RELATIVE POSIZIONI
                /////////////////////
                CaricaApp(Apps, Query, cn, cmd, da, Tabella);

                cn.Close();
                /////////////////////
                /// SE LE APP SONO PIU' DI 4 CARICO FrmApplicazioni
                ////////////////////
                switch (Apps)
                {
                    case 5:
                        Variabili.Form.Show();
                        this.BeginInvoke((Action)(() => this.Hide()));
                        break;
                    case 6:
                        Variabili.Form.Show();
                        this.BeginInvoke((Action)(() => this.Hide()));
                        break;
                    case 7:
                        Variabili.Form.Show();
                        this.BeginInvoke((Action)(() => this.Hide()));
                        break;
                    case 8:
                        Variabili.Form.Show();
                        this.BeginInvoke((Action)(() => this.Hide()));
                        break;
                    case 9:
                        Variabili.Form.Show();
                        this.BeginInvoke((Action)(() => this.Hide()));
                        break;
                    case 10:
                        Variabili.Form.Show();
                        this.BeginInvoke((Action)(() => this.Hide()));
                        break;
                    case 11:
                        Variabili.Form.Show();
                        this.BeginInvoke((Action)(() => this.Hide()));
                        break;
                    case 12:
                        Variabili.Form.Show();
                        this.BeginInvoke((Action)(() => this.Hide()));
                        break;
                    default:
                        if (Apps > 12)
                        {
                            MessageBox.Show($"Errore, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // nulla
                        }
                        break;
                }
            }
            else
            {
                // evita tutto
            }
            CheckPrimoStart(); // se primo start riinviare a FrmPrimoStart
        }

        private void CaricaApp(int Apps, string Query, OleDbConnection cn, OleDbCommand cmd, OleDbDataAdapter da, DataTable Tabella)
        {
            string start = "", fileExtension = "", id = "";
            string[] Combo = { "", "", "", "" };
            string IDApp, valore1, valore2, valore3, valore4;
            bool Passaggio = false;

            switch (Apps)
            {
                case 1:
                    // nulla
                    break;
                case 2:
                    // settings ordine #1
                    Query = "SELECT * " +
                        "FROM Path";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    IDApp = Tabella.Rows[0]["AppPosition"].ToString();
                    Combo[0] = IDApp;
                    // settings ordine #2
                    Query = "SELECT * " +
                        "FROM Path";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    IDApp = Tabella.Rows[1]["AppPosition"].ToString();
                    Combo[1] = IDApp;
                    valore1 = Combo[0];
                    valore2 = Combo[1];
                    if (valore1 == "1" && valore2 == "2" || valore1 == "2" && valore2 == "1") // faccio tutte le combinazioni possibili
                    {
                        Passaggio = true;
                    }
                    else
                    {
                        Passaggio = false;
                    }
                    break;
                case 3:
                    // settings ordine #1
                    Query = "SELECT * " +
                        "FROM Path";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    IDApp = Tabella.Rows[0]["AppPosition"].ToString();
                    Combo[0] = IDApp;
                    // settings ordine #2
                    Query = "SELECT * " +
                        "FROM Path";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    IDApp = Tabella.Rows[1]["AppPosition"].ToString();
                    Combo[1] = IDApp;
                    // settings ordine #3
                    Query = "SELECT * " +
                        "FROM Path";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    IDApp = Tabella.Rows[2]["AppPosition"].ToString();
                    Combo[2] = IDApp;
                    valore1 = Combo[0];
                    valore2 = Combo[1];
                    valore3 = Combo[2];
                    if ((valore1 == "1" && valore2 == "2" && valore3 == "3") || // faccio tutte le combinazioni possibili
                        (valore1 == "1" && valore2 == "3" && valore3 == "2") ||
                        (valore1 == "2" && valore2 == "1" && valore3 == "3") ||
                        (valore1 == "2" && valore2 == "3" && valore3 == "1") ||
                        (valore1 == "3" && valore2 == "1" && valore3 == "2") ||
                        (valore1 == "3" && valore2 == "2" && valore3 == "1"))
                    {
                        Passaggio = true;
                    }
                    else
                    {
                        Passaggio = false;
                    }
                    break;
                case 4:
                    // settings ordine #1
                    Query = "SELECT * " +
                        "FROM Path";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    IDApp = Tabella.Rows[0]["AppPosition"].ToString();
                    Combo[0] = IDApp;
                    // settings ordine #2
                    Query = "SELECT * " +
                        "FROM Path";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    IDApp = Tabella.Rows[1]["AppPosition"].ToString();
                    Combo[1] = IDApp;
                    // settings ordine #3
                    Query = "SELECT * " +
                        "FROM Path";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    IDApp = Tabella.Rows[2]["AppPosition"].ToString();
                    Combo[2] = IDApp;
                    // settings ordine #4
                    Query = "SELECT * " +
                        "FROM Path";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    IDApp = Tabella.Rows[3]["AppPosition"].ToString();
                    Combo[3] = IDApp;
                    valore1 = Combo[0];
                    valore2 = Combo[1];
                    valore3 = Combo[2];
                    valore4 = Combo[3];
                    if ((valore1 == "1" && valore2 == "2" && valore3 == "3" && valore4 == "4") || // faccio tutte le combinazioni possibili
                        (valore1 == "1" && valore2 == "2" && valore3 == "4" && valore4 == "3") ||
                        (valore1 == "1" && valore2 == "3" && valore3 == "2" && valore4 == "4") ||
                        (valore1 == "1" && valore2 == "3" && valore3 == "4" && valore4 == "2") ||
                        (valore1 == "1" && valore2 == "4" && valore3 == "2" && valore4 == "3") ||
                        (valore1 == "1" && valore2 == "4" && valore3 == "3" && valore4 == "2") ||
                        (valore1 == "2" && valore2 == "1" && valore3 == "3" && valore4 == "4") ||
                        (valore1 == "2" && valore2 == "1" && valore3 == "4" && valore4 == "3") ||
                        (valore1 == "2" && valore2 == "3" && valore3 == "1" && valore4 == "4") ||
                        (valore1 == "2" && valore2 == "3" && valore3 == "4" && valore4 == "1") ||
                        (valore1 == "2" && valore2 == "4" && valore3 == "1" && valore4 == "3") ||
                        (valore1 == "2" && valore2 == "4" && valore3 == "3" && valore4 == "1") ||
                        (valore1 == "3" && valore2 == "1" && valore3 == "2" && valore4 == "4") ||
                        (valore1 == "3" && valore2 == "1" && valore3 == "4" && valore4 == "2") ||
                        (valore1 == "3" && valore2 == "2" && valore3 == "1" && valore4 == "4") ||
                        (valore1 == "3" && valore2 == "2" && valore3 == "4" && valore4 == "1") ||
                        (valore1 == "3" && valore2 == "4" && valore3 == "1" && valore4 == "2") ||
                        (valore1 == "3" && valore2 == "4" && valore3 == "2" && valore4 == "1") ||
                        (valore1 == "4" && valore2 == "1" && valore3 == "2" && valore4 == "3") ||
                        (valore1 == "4" && valore2 == "1" && valore3 == "3" && valore4 == "2") ||
                        (valore1 == "4" && valore2 == "2" && valore3 == "1" && valore4 == "3") ||
                        (valore1 == "4" && valore2 == "2" && valore3 == "3" && valore4 == "1") ||
                        (valore1 == "4" && valore2 == "3" && valore3 == "1" && valore4 == "2") ||
                        (valore1 == "4" && valore2 == "3" && valore3 == "2" && valore4 == "1"))
                    {
                        Passaggio = true;
                    }
                    else
                    {
                        Passaggio = false;
                    }
                    break;
            }
            switch (Apps)
            {
                case 1:
                    if (Passaggio)
                    {
                        checkapps = true;
                        ////////////////////////////
                        /////// PRIMO CASE
                        ////////////////////////////
                        //////////////////////////////////// primo bottone
                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 1";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp1.Text = id;
                        CmbApp1.Texts = id; // carico id sulla combo box nei settings

                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 1";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp1.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp1.Image = ColoreApp;
                            AppNoLogo1 = true;
                        }
                        BtnApp1.Visible = true;
                    }
                    else {
                        //////////////////////////////////// primo bottone
                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp1.Text = id;

                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp1.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp1.Image = ColoreApp;
                            AppNoLogo1 = true;
                        }
                        BtnApp1.Visible = true;
                    }
                    break;
                case 2:
                    if (Passaggio) // && checka != 1 && Variabili.FrmDatabasePassaggioEliminazione == false
                    {
                        checkapps = true;
                        ////////////////////////////
                        /////// SECONDO CASE
                        ////////////////////////////
                        //////////////////////////////////// primo bottone
                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 1";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp1.Text = id;
                        CmbApp1.Texts = id; // carico id sulla combo box nei settings

                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 1";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp1.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp1.Image = ColoreApp;
                            AppNoLogo1 = true;
                        }
                        BtnApp1.Visible = true;

                        //////////////////////////////////// secondo bottone
                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 2";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp2.Text = id;
                        CmbApp2.Texts = id; // carico id sulla combo box nei settings
                        CmbApp3.Enabled = false; // rimuovo la possibilità di cambiare posizione app alle altre 2
                        CmbApp4.Enabled = false;

                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 2";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp2.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp2.Image = ColoreApp;
                            AppNoLogo2 = true;
                        }
                        BtnApp2.Visible = true;
                    }
                    else
                    {
                        //////////////////////////////////// primo bottone
                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp1.Text = id;

                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp1.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp1.Image = ColoreApp;
                            AppNoLogo1 = true;
                        }
                        BtnApp1.Visible = true;

                        //////////////////////////////////// secondo bottone
                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[1]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp2.Text = id;

                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[1]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp2.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp2.Image = ColoreApp;
                            AppNoLogo2 = true;
                        }
                        BtnApp2.Visible = true;
                    }
                    break;
                case 3:
                    if (Passaggio)
                    {
                        checkapps = true;
                        ////////////////////////////
                        /////// TERZO CASE
                        ////////////////////////////
                        //////////////////////////////////// primo bottone
                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 1";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp1.Text = id;
                        CmbApp1.Texts = id; // carico id sulla combo box nei settings

                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 1";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp1.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp1.Image = ColoreApp;
                            AppNoLogo1 = true;
                        }
                        BtnApp1.Visible = true;

                        //////////////////////////////////// secondo bottone
                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 2";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp2.Text = id;
                        CmbApp2.Texts = id; // carico id sulla combo box nei settings

                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 2";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp2.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp2.Image = ColoreApp;
                            AppNoLogo2 = true;
                        }
                        BtnApp2.Visible = true;

                        //////////////////////////////////// terzo bottone
                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 3";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp3.Text = id;
                        CmbApp3.Texts = id; // carico id sulla combo box nei settings
                        CmbApp4.Enabled = false; // rimuovo la possibilità di cambiare posizione app all'ultima

                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 3";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp3.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp3.Image = ColoreApp;
                            AppNoLogo3 = true;
                        }
                        BtnApp3.Visible = true;

                    }
                    else
                    {
                        //////////////////////////////////// primo bottone
                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp1.Text = id;

                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp1.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp1.Image = ColoreApp;
                            AppNoLogo1 = true;
                        }
                        BtnApp1.Visible = true;

                        //////////////////////////////////// secondo bottone
                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[1]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp2.Text = id;

                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[1]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp2.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp2.Image = ColoreApp;
                            AppNoLogo2 = true;
                        }
                        BtnApp2.Visible = true;

                        //////////////////////////////////// terzo bottone
                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[2]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp3.Text = id;

                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[2]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp3.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp3.Image = ColoreApp;
                            AppNoLogo3 = true;
                        }
                        BtnApp3.Visible = true;
                    }
                    break;
                case 4:
                    if (Passaggio)
                    {
                        checkapps = true;
                        ////////////////////////////
                        /////// QUARTO CASE
                        ////////////////////////////
                        //////////////////////////////////// primo bottone
                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 1";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp1.Text = id;
                        CmbApp1.Texts = id; // carico id sulla combo box nei settings

                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 1";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp1.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp1.Image = ColoreApp;
                            AppNoLogo1 = true;
                        }
                        BtnApp1.Visible = true;

                        //////////////////////////////////// secondo bottone
                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 2";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp2.Text = id;
                        CmbApp2.Texts = id; // carico id sulla combo box nei settings

                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 2";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp2.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp2.Image = ColoreApp;
                            AppNoLogo2 = true;
                        }
                        BtnApp2.Visible = true;

                        //////////////////////////////////// terzo bottone
                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 3";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp3.Text = id;
                        CmbApp3.Texts = id; // carico id sulla combo box nei settings

                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 3";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp3.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp3.Image = ColoreApp;
                            AppNoLogo3 = true;
                        }
                        BtnApp3.Visible = true;

                        //////////////////////////////////// quarto bottone
                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 4";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp4.Text = id;
                        CmbApp4.Texts = id; // carico id sulla combo box nei settings

                        Query = "SELECT * " +
                                "FROM Path " +
                                "WHERE AppPosition = 4";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp4.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp4.Image = ColoreApp;
                            AppNoLogo4 = true;
                        }
                        BtnApp4.Visible = true;
                    }
                    else
                    {
                        //////////////////////////////////// primo bottone
                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[0]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp1.Text = id;

                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[0]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp1.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp1.Image = ColoreApp;
                            AppNoLogo1 = true;
                        }
                        BtnApp1.Visible = true;

                        //////////////////////////////////// secondo bottone
                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[1]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp2.Text = id;

                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[1]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp2.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp2.Image = ColoreApp;
                            AppNoLogo2 = true;
                        }
                        BtnApp2.Visible = true;

                        //////////////////////////////////// terzo bottone
                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[2]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp3.Text = id;

                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[2]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp3.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp3.Image = ColoreApp;
                            AppNoLogo3 = true;
                        }
                        BtnApp3.Visible = true;

                        //////////////////////////////////// quarto bottone
                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        id = Tabella.Rows[3]["ID"].ToString();
                        id = id.Substring(0, 1).ToUpper() + id.Substring(1);
                        BtnApp4.Text = id;

                        Query = "SELECT * " +
                                "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        Tabella = new DataTable();
                        da.Fill(Tabella);
                        start = Tabella.Rows[3]["start"].ToString();
                        fileExtension = System.IO.Path.GetExtension(start);
                        if (fileExtension.ToLower() == ".exe")
                        {
                            Icon appIcon = Icon.ExtractAssociatedIcon(start);
                            Image BtnImage = appIcon.ToBitmap();
                            BtnApp4.Image = BtnImage;
                        }
                        else
                        {
                            BtnApp4.Image = ColoreApp;
                            AppNoLogo4 = true;
                        }
                        BtnApp4.Visible = true;
                    }
                    break;
            }
            BtnAllineamentoImage();
        }

        private void BtnEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            // caricando-inizializzando elementi
            BtnDashboard.BackColor = Variabili.BtnAttivo;
            BtnApp1.BackColor = Variabili.BtnDisattivo;
            BtnApp2.BackColor = Variabili.BtnDisattivo;
            BtnApp3.BackColor = Variabili.BtnDisattivo;
            BtnApp4.BackColor = Variabili.BtnDisattivo;
            BtnSettings.BackColor = Variabili.BtnDisattivo;
            LblNotificaImage.Visible = false;
            PcbMain.Image = null;
            BtnAvvia.Visible = false;
            LblDescSettingsUser.Visible = false;
            BtnSettingsLogoUsername.Visible = false;
            BtnFaqUscitaAutomatica.Visible = false;
            LblDescRiordina.Visible = false;
            LblDescColoreLauncher.Visible = false;
            CmbColoreLauncher.Visible = false;
            CmbApp1.Visible = false;
            CmbApp2.Visible = false;
            CmbApp3.Visible = false;
            CmbApp4.Visible = false;
            LblDescSettingsOrdine1.Visible = false;
            LblDescSettingsOrdine2.Visible = false;
            LblDescSettingsOrdine3.Visible = false;
            LblDescSettingsOrdine4.Visible = false;
            BtnRiordinaApps.Visible = false;
            BtnSettingDisinstalla.Visible = false;
            PnlSettingsTrasparenza.Visible = false;
            PnlSettingsUscitaAuto.Visible = false;
            BtnRegistraGioco.Visible = true;

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connessione, Query = "";
            int Apps = 0;
            Connessione = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connessione);
            cn.Open();
            // inizializzo db
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            // carica rdb buttons per uscita automatica
            CaricaRdbSettingsUscitaAuto(Query, cn, cmd, da, Tabella);
            // prendo num delle app per setting riordina
            RefreshSettingOrdina(Query, cn, cmd, da, Tabella, Apps);
            // Carica rdb buttons per trasparenza
            RefreshTrasparenzaRDB(Query, cn, cmd, da, Tabella);
            cn.Close();

            // caricando-inizializzando elementi
            BtnDashboard.BackColor = Variabili.BtnDisattivo;
            BtnApp1.BackColor = Variabili.BtnDisattivo;
            BtnApp2.BackColor = Variabili.BtnDisattivo;
            BtnApp3.BackColor = Variabili.BtnDisattivo;
            BtnApp4.BackColor = Variabili.BtnDisattivo;
            BtnSettings.BackColor = Variabili.BtnAttivo;
            LblNotificaImage.Visible = false;
            PcbMain.Image = null;
            BtnAvvia.Visible = false;
            BtnRegistraGioco.Visible = false;
            LblDescSettingsUser.Visible = true;
            BtnSettingsLogoUsername.Visible = true;
            BtnFaqUscitaAutomatica.Visible = true;
            LblDescRiordina.Visible = true;
            LblDescColoreLauncher.Visible = true;
            CmbColoreLauncher.Visible = true;
            CmbApp1.Visible = true;
            CmbApp2.Visible = true;
            CmbApp3.Visible = true;
            CmbApp4.Visible = true;
            BtnRiordinaApps.Visible = true;
            LblDescSettingsOrdine1.Visible = true;
            LblDescSettingsOrdine2.Visible = true;
            LblDescSettingsOrdine3.Visible = true;
            LblDescSettingsOrdine4.Visible = true;
            BtnSettingDisinstalla.Location = new Point(619, 394);
            BtnSettingDisinstalla.Visible = true;
            PnlSettingsTrasparenza.Visible = true;
            PnlSettingsUscitaAuto.Visible = true;

            // prendo num delle app per caricare le app correttamente
            Query = "SELECT * " +
                   "FROM Path ";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            Apps = Tabella.Rows.Count;
            CaricaApp(Apps, Query, cn, cmd, da, Tabella);
        }

        private void BtnAvvia_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Query;

            // connetto al database
            string connessione = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connessione);
            cn.Open(); // apro il database
            try
            {
                /////////////////////
                /// CERCA APP DA AVVIARE CON RELATIVA POSIZIONE
                ///////////////////
                string path = "";
                if (checkapps)
                {
                    if (app1)
                    {
                        Query = "SELECT * " +
                       "FROM Path " +
                       "WHERE AppPosition = 1";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        tabella = new DataTable();
                        da.Fill(tabella);
                        string id = tabella.Rows[0]["start"].ToString();
                        path = id;
                    }
                    else if (app2)
                    {
                        Query = "SELECT * " +
                       "FROM Path " +
                       "WHERE AppPosition = 2";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        tabella = new DataTable();
                        da.Fill(tabella);
                        string id = tabella.Rows[0]["start"].ToString();
                        path = id;
                    }
                    else if (app3)
                    {
                        Query = "SELECT * " +
                       "FROM Path " +
                       "WHERE AppPosition = 3";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        tabella = new DataTable();
                        da.Fill(tabella);
                        string id = tabella.Rows[0]["start"].ToString();
                        path = id;
                    }
                    else if (app4)
                    {
                        Query = "SELECT * " +
                       "FROM Path " +
                       "WHERE AppPosition = 4";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        tabella = new DataTable();
                        da.Fill(tabella);
                        string id = tabella.Rows[0]["start"].ToString();
                        path = id;
                    }
                    else
                    {
                        MessageBox.Show($"Errore nell'avvio dell'app, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else  ////////// CERCA APP DA AVVIARE SENZA RELATIVA POSIZIONE
                {
                    if (app1)
                    {
                        Query = "SELECT * " +
                       "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        tabella = new DataTable();
                        da.Fill(tabella);
                        string id = tabella.Rows[0]["start"].ToString();
                        path = id;
                    }
                    else if (app2)
                    {
                        Query = "SELECT * " +
                       "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        tabella = new DataTable();
                        da.Fill(tabella);
                        string id = tabella.Rows[1]["start"].ToString();
                        path = id;
                    }
                    else if (app3)
                    {
                        Query = "SELECT * " +
                       "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        tabella = new DataTable();
                        da.Fill(tabella);
                        string id = tabella.Rows[2]["start"].ToString();
                        path = id;
                    }
                    else if (app4)
                    {
                        Query = "SELECT * " +
                       "FROM Path";
                        cmd = new OleDbCommand(Query, cn);
                        da = new OleDbDataAdapter(cmd);
                        tabella = new DataTable();
                        da.Fill(tabella);
                        string id = tabella.Rows[3]["start"].ToString();
                        path = id;
                    }
                    else
                    {
                        MessageBox.Show($"Errore nell'avvio dell'app, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                Process.Start(path); // Avvia l'app
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Errore: {ex} {Environment.NewLine} !!!SE IL PROBLEMA PERSISTE PERFAVORE CONTATTARE IL CREATORE!!!", "Satus: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Controlla se l'uscita automatica è attiva 
            Query = "SELECT UscitaAuto " +
                   "FROM Utente " +
                   "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            tabella = new DataTable();
            da.Fill(tabella);
            cn.Close(); // chiusura database
            bool UscitaAuto = Convert.ToBoolean(tabella.Rows[0]["UscitaAuto"]);
            if (UscitaAuto)
            {
                Application.Exit();
            }
            else
            {
                // non uscire
            }

        }

        private void BtnRegistraGioco_Click(object sender, EventArgs e)
        {
            // indirizza al frmdatabase per registrare o eliminare app
            FrmDatabase frmDatabase = new FrmDatabase();
            frmDatabase.Show();
            this.Hide();
        }

        private void BtnSettingsUsername_Click(object sender, EventArgs e)
        {
            // indirizza al FrmSettingsDatabase per modificare Username o logo
            FrmSettingsDatabase FrmSettingsDatabase = new FrmSettingsDatabase();
            FrmSettingsDatabase.Show();
            this.Hide();
        }

        private void RdbUscitaAutomaticaAttivato_CheckedChanged(object sender, EventArgs e)
        {
            // rende true uscita automatica
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
            // rende false uscita automatica
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

        private async void BtnRiordinaApps_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection cn;
                OleDbCommand cmd;
                OleDbDataAdapter da;
                DataTable tabella;
                string connect, query;
                int Apps;
                string prima = "";
                string seconda = "";
                string terza = "";
                string quarta = "";

                connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
                cn = new OleDbConnection(connect);
                cn.Open();

                query = "SELECT ID " +
                    "FROM Path";
                cmd = new OleDbCommand(query, cn);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);
                // prende tutte le app riordinate secondo l'utente
                switch (righe)
                {
                    case 1:
                        prima = tabella.Rows[0]["ID"].ToString();
                        break;
                    case 2:
                        prima = tabella.Rows[0]["ID"].ToString();
                        seconda = tabella.Rows[1]["ID"].ToString();
                        break;
                    case 3:
                        prima = tabella.Rows[0]["ID"].ToString();
                        seconda = tabella.Rows[1]["ID"].ToString();
                        terza = tabella.Rows[2]["ID"].ToString();
                        break;
                    case 4:
                        prima = tabella.Rows[0]["ID"].ToString();
                        seconda = tabella.Rows[1]["ID"].ToString();
                        terza = tabella.Rows[2]["ID"].ToString();
                        quarta = tabella.Rows[3]["ID"].ToString();
                        break;
                }

                // prima query per sapere quantità di righe
                query = "SELECT * " +
                   "FROM Path ";
                cmd = new OleDbCommand(query, cn);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);
                Apps = tabella.Rows.Count;
                // confronta app e da i relativi errori
                switch (Apps)
                {
                    case 1:
                        // nulla
                        break;
                    case 2:
                        if (CmbApp1.Texts == CmbApp2.Texts)
                        {
                            MessageBox.Show($"Errore Un app è stata inserita più di una volta", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (CmbApp1.Texts == "" || CmbApp2.Texts == "")
                        {
                            MessageBox.Show($"Errore Inserisci tutte le app prima di proseguire", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case 3:
                        if (CmbApp1.Texts == CmbApp2.Texts || CmbApp1.Texts == CmbApp3.Texts || CmbApp2.Texts == CmbApp3.Texts)
                        {
                            MessageBox.Show($"Errore Un app è stata inserita più di una volta", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (CmbApp1.Texts == "" || CmbApp2.Texts == "" || CmbApp3.Texts == "")
                        {
                            MessageBox.Show($"Errore Inserisci tutte le app prima di proseguire", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case 4:
                        if (CmbApp1.Texts == CmbApp2.Texts || CmbApp1.Texts == CmbApp3.Texts || CmbApp1.Texts == CmbApp4.Texts ||
                            CmbApp2.Texts == CmbApp3.Texts || CmbApp2.Texts == CmbApp4.Texts || CmbApp3.Texts == CmbApp4.Texts)
                        {
                            MessageBox.Show($"Errore Un app è stata inserita più di una volta", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (CmbApp1.Texts == "" || CmbApp2.Texts == "" || CmbApp3.Texts == "" || CmbApp4.Texts == "")
                        {
                            MessageBox.Show($"Errore Inserisci tutte le app prima di proseguire", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                } // inserisce nel db codice identificativo per riordinare le app
                switch (righe)
                {
                    case 1:
                        MessageBox.Show($"Errore non si può riordinare un unica app!", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        if (CmbApp1.Texts == "" || CmbApp2.Texts == "")
                        {
                            MessageBox.Show($"Inserisci l'ordine delle app prima di continuare!", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // prima app
                        prima = CmbApp1.Texts;
                        query = "UPDATE Path " +
                            "SET AppPosition = '1' " +
                            "WHERE ID = @IDApp";
                        cmd = new OleDbCommand(query, cn);
                        cmd.Parameters.AddWithValue("@IDApp", prima);
                        cmd.ExecuteNonQuery();
                        // seconda app
                        seconda = CmbApp2.Texts;
                        query = "UPDATE Path " +
                            "SET AppPosition = '2' " +
                            "WHERE ID = @IDApp";
                        cmd = new OleDbCommand(query, cn);
                        cmd.Parameters.AddWithValue("@IDApp", seconda);
                        cmd.ExecuteNonQuery();
                        await Task.Delay(600);
                        MessageBox.Show($"App ordinate con successo.", "Status: Ok", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        CaricaApp(Apps, query, cn, cmd, da, tabella);
                        break;
                    case 3:
                        if (CmbApp1.Texts == "" || CmbApp2.Texts == "" || CmbApp3.Texts == "")
                        {
                            MessageBox.Show($"Inserisci l'ordine delle app prima di continuare!", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // prima app
                        prima = CmbApp1.Texts;
                        query = "UPDATE Path " +
                            "SET AppPosition = '1' " +
                            "WHERE ID = @IDApp";
                        cmd = new OleDbCommand(query, cn);
                        cmd.Parameters.AddWithValue("@IDApp", prima);
                        cmd.ExecuteNonQuery();
                        // seconda app
                        seconda = CmbApp2.Texts;
                        query = "UPDATE Path " +
                            "SET AppPosition = '2' " +
                            "WHERE ID = @IDApp";
                        cmd = new OleDbCommand(query, cn);
                        cmd.Parameters.AddWithValue("@IDApp", seconda);
                        cmd.ExecuteNonQuery();
                        // terza app
                        terza = CmbApp3.Texts;
                        query = "UPDATE Path " +
                            "SET AppPosition = '3' " +
                            "WHERE ID = @IDApp";
                        cmd = new OleDbCommand(query, cn);
                        cmd.Parameters.AddWithValue("@IDApp", terza);
                        cmd.ExecuteNonQuery();
                        await Task.Delay(600);
                        MessageBox.Show($"App ordinate con successo.", "Status: Ok", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        CaricaApp(Apps, query, cn, cmd, da, tabella);
                        break;
                    case 4:
                        if (CmbApp1.Texts == "" || CmbApp2.Texts == "" || CmbApp3.Texts == "" || CmbApp4.Texts == "")
                        {
                            MessageBox.Show($"Inserisci l'ordine delle app prima di continuare!", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // prima app
                        prima = CmbApp1.Texts;
                        query = "UPDATE Path " +
                            "SET AppPosition = '1' " +
                            "WHERE ID = @IDApp";
                        cmd = new OleDbCommand(query, cn);
                        cmd.Parameters.AddWithValue("@IDApp", prima);
                        cmd.ExecuteNonQuery();
                        // seconda app
                        seconda = CmbApp2.Texts;
                        query = "UPDATE Path " +
                            "SET AppPosition = '2' " +
                            "WHERE ID = @IDApp";
                        cmd = new OleDbCommand(query, cn);
                        cmd.Parameters.AddWithValue("@IDApp", seconda);
                        cmd.ExecuteNonQuery();
                        // terza app
                        terza = CmbApp3.Texts;
                        query = "UPDATE Path " +
                            "SET AppPosition = '3' " +
                            "WHERE ID = @IDApp";
                        cmd = new OleDbCommand(query, cn);
                        cmd.Parameters.AddWithValue("@IDApp", terza);
                        cmd.ExecuteNonQuery();
                        // quarta app
                        quarta = CmbApp4.Texts;
                        query = "UPDATE Path " +
                            "SET AppPosition = '4' " +
                            "WHERE ID = @IDApp";
                        cmd = new OleDbCommand(query, cn);
                        cmd.Parameters.AddWithValue("@IDApp", quarta);
                        cmd.ExecuteNonQuery();
                        await Task.Delay(600);
                        MessageBox.Show($"App ordinate con successo.", "Status: Ok", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        CaricaApp(Apps, query, cn, cmd, da, tabella);
                        break;
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Errore: {ex} {Environment.NewLine}!!!SE IL PROBLEMA PERSISTE PERFAVORE CONTATTARE IL CREATORE!!!", "Satus: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void RdbTrasparenzaAttiva_CheckedChanged(object sender, EventArgs e)
        {
            // rende trasparente
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
            // toglie la traparenza
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

        private void BtnApp1_Click(object sender, EventArgs e)
        {
            // caricando-inizializzando elementi
            app1 = true;
            app2 = false;
            app3 = false;
            app4 = false;
            LblDescSettingsUser.Visible = false;
            BtnSettingsLogoUsername.Visible = false;
            BtnFaqUscitaAutomatica.Visible = false;
            LblDescRiordina.Visible = false;
            LblDescColoreLauncher.Visible = false;
            CmbColoreLauncher.Visible = false;
            CmbApp1.Visible = false;
            CmbApp2.Visible = false;
            CmbApp3.Visible = false;
            CmbApp4.Visible = false;
            BtnRiordinaApps.Visible = false;
            LblDescSettingsOrdine1.Visible = false;
            LblDescSettingsOrdine2.Visible = false;
            LblDescSettingsOrdine3.Visible = false;
            LblDescSettingsOrdine4.Visible = false;
            BtnSettingDisinstalla.Visible = false;
            PnlSettingsTrasparenza.Visible = false;
            PnlSettingsUscitaAuto.Visible = false;
            BtnDashboard.BackColor = Variabili.BtnDisattivo;
            BtnApp1.BackColor = Variabili.BtnAttivo;
            BtnApp2.BackColor = Variabili.BtnDisattivo;
            BtnApp3.BackColor = Variabili.BtnDisattivo;
            BtnApp4.BackColor = Variabili.BtnDisattivo;
            BtnSettings.BackColor = Variabili.BtnDisattivo;
            LblNotificaImage.Visible = false;
            PcbMain.Visible = true;

            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string connect, query, background;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();

            // prende foto backgound se ha num identificativo
            if (checkapps)
            {
                query = "SELECT * " +
                    "FROM Path " +
                    "WHERE AppPosition = 1";
                cmd = new OleDbCommand(query, cn);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);
                background = tabella.Rows[0]["immagine"].ToString();
                if (background == "" || background == "Seleziona File")
                {
                    PcbMain.Image = Resources.background;
                }
                else
                {
                    PcbMain.ImageLocation = background;
                }

                BtnAvvia.Visible = true;
                BtnRegistraGioco.Visible = false;
                if (AppNoLogo1)
                {
                    LblNotificaImage.Visible = true;
                }
            }
            else // prende foto backgound senza num identificativo
            {
                query = "SELECT * " +
                       "FROM Path";
                cmd = new OleDbCommand(query, cn);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);
                background = tabella.Rows[0]["immagine"].ToString();
                if (background == "" || background == "Seleziona File")
                {
                    PcbMain.Image = Resources.background;
                }
                else
                {
                    PcbMain.ImageLocation = background;
                }

                BtnAvvia.Visible = true;
                BtnRegistraGioco.Visible = false;
                if (AppNoLogo1)
                {
                    LblNotificaImage.Visible = true;
                }
            }
            cn.Close();
        }

        private void BtnApp2_Click(object sender, EventArgs e)
        {
            app1 = false;
            app2 = true;
            app3 = false;
            app4 = false;
            LblDescSettingsUser.Visible = false;
            BtnSettingsLogoUsername.Visible = false;
            BtnFaqUscitaAutomatica.Visible = false;
            LblDescRiordina.Visible = false;
            LblDescColoreLauncher.Visible = false;
            CmbColoreLauncher.Visible = false;
            CmbApp1.Visible = false;
            CmbApp2.Visible = false;
            CmbApp3.Visible = false;
            CmbApp4.Visible = false;
            BtnRiordinaApps.Visible = false;
            LblDescSettingsOrdine1.Visible = false;
            LblDescSettingsOrdine2.Visible = false;
            LblDescSettingsOrdine3.Visible = false;
            LblDescSettingsOrdine4.Visible = false;
            BtnSettingDisinstalla.Visible = false;
            PnlSettingsTrasparenza.Visible = false;
            PnlSettingsUscitaAuto.Visible = false;
            BtnDashboard.BackColor = Variabili.BtnDisattivo;
            BtnApp1.BackColor = Variabili.BtnDisattivo;
            BtnApp2.BackColor = Variabili.BtnAttivo;
            BtnApp3.BackColor = Variabili.BtnDisattivo;
            BtnApp4.BackColor = Variabili.BtnDisattivo;
            BtnSettings.BackColor = Variabili.BtnDisattivo;
            LblNotificaImage.Visible = false;
            PcbMain.Visible = true;
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string connect, query, background;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();
            // prende foto backgound se ha num identificativo
            if (checkapps)
            {
                query = "SELECT * " +
                    "FROM Path " +
                    "WHERE AppPosition = 1";
                cmd = new OleDbCommand(query, cn);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);
                background = tabella.Rows[0]["immagine"].ToString();
                if (background == "" || background == "Seleziona File")
                {
                    PcbMain.Image = Resources.background;
                }
                else
                {
                    PcbMain.ImageLocation = background;
                }

                BtnAvvia.Visible = true;
                BtnRegistraGioco.Visible = false;
                if (AppNoLogo2)
                {
                    LblNotificaImage.Visible = true;
                }
            }
            else // prende foto backgound senza num identificativo
            {
                query = "SELECT * " +
                       "FROM Path";
                cmd = new OleDbCommand(query, cn);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);
                background = tabella.Rows[1]["immagine"].ToString();
                if (background == "" || background == "Seleziona File")
                {
                    PcbMain.Image = Resources.background;
                }
                else
                {
                    PcbMain.ImageLocation = background;
                }

                BtnAvvia.Visible = true;
                BtnRegistraGioco.Visible = false;
                if (AppNoLogo2)
                {
                    LblNotificaImage.Visible = true;
                }
            }
            cn.Close();
        }

        private void BtnApp3_Click(object sender, EventArgs e)
        {
            app1 = false;
            app2 = false;
            app3 = true;
            app4 = false;
            LblDescSettingsUser.Visible = false;
            BtnSettingsLogoUsername.Visible = false;
            BtnFaqUscitaAutomatica.Visible = false;
            LblDescRiordina.Visible = false;
            LblDescColoreLauncher.Visible = false;
            CmbColoreLauncher.Visible = false;
            CmbApp1.Visible = false;
            CmbApp2.Visible = false;
            CmbApp3.Visible = false;
            CmbApp4.Visible = false;
            BtnRiordinaApps.Visible = false;
            LblDescSettingsOrdine1.Visible = false;
            LblDescSettingsOrdine2.Visible = false;
            LblDescSettingsOrdine3.Visible = false;
            LblDescSettingsOrdine4.Visible = false;
            BtnSettingDisinstalla.Visible = false;
            PnlSettingsTrasparenza.Visible = false;
            PnlSettingsUscitaAuto.Visible = false;
            BtnDashboard.BackColor = Variabili.BtnDisattivo;
            BtnApp1.BackColor = Variabili.BtnDisattivo;
            BtnApp2.BackColor = Variabili.BtnDisattivo;
            BtnSettings.BackColor = Variabili.BtnDisattivo;
            BtnApp3.BackColor = Variabili.BtnAttivo;
            BtnApp4.BackColor = Variabili.BtnDisattivo;
            LblNotificaImage.Visible = false;
            PcbMain.Visible = true;

            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string connect, query, background;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();

            // prende foto backgound se ha num identificativo
            if (checkapps)
            {
                query = "SELECT * " +
                    "FROM Path " +
                    "WHERE AppPosition = 1";
                cmd = new OleDbCommand(query, cn);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);
                background = tabella.Rows[0]["immagine"].ToString();
                if (background == "" || background == "Seleziona File")
                {
                    PcbMain.Image = Resources.background;
                }
                else
                {
                    PcbMain.ImageLocation = background;
                }

                BtnAvvia.Visible = true;
                BtnRegistraGioco.Visible = false;
                if (AppNoLogo3)
                {
                    LblNotificaImage.Visible = true;
                }
            }
            else // prende foto backgound senza num identificativo
            {
                query = "SELECT * " +
                       "FROM Path";
                cmd = new OleDbCommand(query, cn);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);
                background = tabella.Rows[2]["immagine"].ToString();
                if (background == "" || background == "Seleziona File")
                {
                    PcbMain.Image = Resources.background;
                }
                else
                {
                    PcbMain.ImageLocation = background;
                }

                BtnAvvia.Visible = true;
                BtnRegistraGioco.Visible = false;
                if (AppNoLogo3)
                {
                    LblNotificaImage.Visible = true;
                }
            }
            cn.Close();
        }

        private void BtnApp4_Click(object sender, EventArgs e)
        {
            app1 = false;
            app2 = false;
            app3 = false;
            app4 = true;
            LblDescSettingsUser.Visible = false;
            BtnSettingsLogoUsername.Visible = false;
            BtnFaqUscitaAutomatica.Visible = false;
            LblDescRiordina.Visible = false;
            LblDescColoreLauncher.Visible = false;
            CmbColoreLauncher.Visible = false;
            CmbApp1.Visible = false;
            CmbApp2.Visible = false;
            CmbApp3.Visible = false;
            CmbApp4.Visible = false;
            BtnRiordinaApps.Visible = false;
            LblDescSettingsOrdine1.Visible = false;
            LblDescSettingsOrdine2.Visible = false;
            LblDescSettingsOrdine3.Visible = false;
            LblDescSettingsOrdine4.Visible = false;
            BtnSettingDisinstalla.Visible = false;
            PnlSettingsTrasparenza.Visible = false;
            PnlSettingsUscitaAuto.Visible = false;
            BtnDashboard.BackColor = Variabili.BtnDisattivo;
            BtnApp1.BackColor = Variabili.BtnDisattivo;
            BtnApp2.BackColor = Variabili.BtnDisattivo;
            BtnSettings.BackColor = Variabili.BtnDisattivo;
            BtnApp3.BackColor = Variabili.BtnDisattivo;
            BtnApp4.BackColor = Variabili.BtnAttivo;
            LblNotificaImage.Visible = false;
            PcbMain.Visible = true;

            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string connect, query, background;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();

            // prende foto backgound se ha num identificativo
            if (checkapps)
            {
                query = "SELECT * " +
                    "FROM Path " +
                    "WHERE AppPosition = 1";
                cmd = new OleDbCommand(query, cn);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);
                background = tabella.Rows[0]["immagine"].ToString();
                if (background == "" || background == "Seleziona File")
                {
                    PcbMain.Image = Resources.background;
                }
                else
                {
                    PcbMain.ImageLocation = background;
                }

                BtnAvvia.Visible = true;
                BtnRegistraGioco.Visible = false;
                if (AppNoLogo4)
                {
                    LblNotificaImage.Visible = true;
                }
            }
            else // prende foto backgound senza num identificativo
            {
                query = "SELECT * " +
                       "FROM Path";
                cmd = new OleDbCommand(query, cn);
                da = new OleDbDataAdapter(cmd);
                tabella = new DataTable();
                da.Fill(tabella);
                background = tabella.Rows[3]["immagine"].ToString();
                if (background == "" || background == "Seleziona File")
                {
                    PcbMain.Image = Resources.background;
                }
                else
                {
                    PcbMain.ImageLocation = background;
                }

                BtnAvvia.Visible = true;
                BtnRegistraGioco.Visible = false;
                if (AppNoLogo4)
                {
                    LblNotificaImage.Visible = true;
                }
            }
            cn.Close();
        }

        private void RefreshOrdineApps()
        {

            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connessione, Query;
            int Apps;

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
            Apps = Tabella.Rows.Count;

            // ordina applicazioni secondo codice identificavo
            switch (Apps)
            {
                case 1:
                    ////////////////////////////
                    /////// PRIMO CASE
                    ////////////////////////////
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 1";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    string id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;

                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 1";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    string start = Tabella.Rows[0]["start"].ToString();
                    string fileExtension = System.IO.Path.GetExtension(start);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }

                    BtnApp1.Visible = true;
                    break;
                case 2:
                    ////////////////////////////
                    /////// SECONDO CASE
                    ////////////////////////////
                    //////////////////////////////////// primo bottone
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 1";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;

                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 1";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    start = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;

                    //////////////////////////////////// secondo bottone
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 2";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp2.Text = id;

                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 2";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    start = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;
                    break;
                case 3:
                    ////////////////////////////
                    /////// TERZO CASE
                    ////////////////////////////
                    //////////////////////////////////// primo bottone
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 1";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;

                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 1";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    start = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;

                    //////////////////////////////////// secondo bottone
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 2";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp2.Text = id;

                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 2";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    start = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;

                    //////////////////////////////////// terzo bottone
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 3";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp3.Text = id;
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 3";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    start = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp3.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp3.Image = ColoreApp;
                    }
                    BtnApp3.Visible = true;
                    break;
                case 4:
                    ////////////////////////////
                    /////// QUARTO CASE
                    ////////////////////////////
                    //////////////////////////////////// primo bottone
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 1";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;

                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 1";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    start = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;

                    //////////////////////////////////// secondo bottone
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 2";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp2.Text = id;

                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 2";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    start = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;

                    //////////////////////////////////// terzo bottone
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 3";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp3.Text = id;

                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 3";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    start = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp3.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp3.Image = ColoreApp;
                    }
                    BtnApp3.Visible = true;

                    //////////////////////////////////// quarto bottone
                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 4";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp4.Text = id;

                    Query = "SELECT * " +
                            "FROM Path " +
                            "WHERE AppPosition = 4";
                    cmd = new OleDbCommand(Query, cn);
                    da = new OleDbDataAdapter(cmd);
                    Tabella = new DataTable();
                    da.Fill(Tabella);
                    start = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp4.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp4.Image = ColoreApp;
                    }
                    BtnApp4.Visible = true;
                    break;
                case 5:
                    Variabili.Form.Show();
                    this.BeginInvoke((Action)(() => this.Hide()));
                    break;
                case 6:
                    Variabili.Form.Show();
                    this.BeginInvoke((Action)(() => this.Hide()));
                    break;
                case 7:
                    Variabili.Form.Show();
                    this.BeginInvoke((Action)(() => this.Hide()));
                    break;
                case 8:
                    Variabili.Form.Show();
                    this.BeginInvoke((Action)(() => this.Hide()));
                    break;
                case 9:
                    Variabili.Form.Show();
                    this.BeginInvoke((Action)(() => this.Hide()));
                    break;
                case 10:
                    Variabili.Form.Show();
                    this.BeginInvoke((Action)(() => this.Hide()));
                    break;
                case 11:
                    Variabili.Form.Show();
                    this.BeginInvoke((Action)(() => this.Hide()));
                    break;
                case 12:
                    Variabili.Form.Show();
                    this.BeginInvoke((Action)(() => this.Hide()));
                    break;
                default:
                    MessageBox.Show($"Errore, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
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
            string Colore = CmbColoreLauncher.Texts;

            Colori(Colore);
        }
        private void Colori(string Colore)
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
                RefreshColoreLauncher();
                RefreshBtnImage();
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
                RefreshColoreLauncher();
                RefreshBtnImage();
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
                RefreshColoreLauncher();
                RefreshBtnImage();
            }
            else if (Colore == "Dark Mode")
            {
                Darkmode = true;
                Variabili.Online = Color.FromArgb(0, 0, 0);
                Variabili.PnlSX = Color.FromArgb(23, 23, 23);
                Variabili.PnlDX = Color.FromArgb(33, 33, 33);
                Variabili.Scritte = Color.FromArgb(180, 180, 180);
                Variabili.RdbCheckControl = Color.FromArgb(0, 0, 0);
                Variabili.RdbUnCheckControl = Color.FromArgb(0, 0, 0);
                Variabili.BtnAttivo = Color.FromArgb(33, 33, 33);
                Variabili.BtnDisattivo = Color.FromArgb(23, 23, 23);
                RefreshColoreLauncher();
                RefreshBtnImage();
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
            BtnApp1.BackColor = Variabili.PnlSX;
            BtnApp2.BackColor = Variabili.PnlSX;
            BtnApp3.BackColor = Variabili.PnlSX;
            BtnApp4.BackColor = Variabili.PnlSX;
            BtnSettings.BackColor = Variabili.PnlSX;
            // bottoni pnlSX fore color
            BtnDashboard.ForeColor = Variabili.Scritte;
            BtnApp1.ForeColor = Variabili.Scritte;
            BtnApp2.ForeColor = Variabili.Scritte;
            BtnApp3.ForeColor = Variabili.Scritte;
            BtnApp4.ForeColor = Variabili.Scritte;
            BtnSettings.ForeColor = Variabili.Scritte;
            // label
            LblUsername.ForeColor = Variabili.Scritte;
            LblDescUsername.ForeColor = Variabili.Online;
            LblDescSettingsUser.ForeColor = Variabili.Scritte;
            LblDescColoreLauncher.ForeColor = Variabili.Scritte;
            LblDescRiordina.ForeColor = Variabili.Scritte;
            LblDescSettingsOrdine1.ForeColor = Variabili.Scritte;
            LblDescSettingsOrdine2.ForeColor = Variabili.Scritte;
            LblDescSettingsOrdine3.ForeColor = Variabili.Scritte;
            LblDescSettingsOrdine4.ForeColor = Variabili.Scritte;
            LblDescCambiaTrasparenza.ForeColor = Variabili.Scritte;
            LblDescUscitaAutomatica.ForeColor = Variabili.Scritte;
            // btn pnlDX forecolor
            BtnSettingsLogoUsername.ForeColor = Variabili.Scritte;
            BtnRiordinaApps.ForeColor = Variabili.Scritte;
            BtnAvvia.ForeColor = Variabili.Scritte;
            BtnRegistraGioco.ForeColor = Variabili.Scritte;
            BtnFaqUscitaAutomatica.ForeColor = Variabili.Scritte;
            // btn pnlDX backcolor
            BtnSettingsLogoUsername.BackColor = Variabili.PnlDX;
            BtnRiordinaApps.BackColor = Variabili.PnlDX;
            BtnAvvia.BackColor = Variabili.PnlDX;
            BtnRegistraGioco.BackColor = Variabili.PnlDX;
            BtnFaqUscitaAutomatica.BackColor = Variabili.PnlDX;
            BtnSettingDisinstalla.BackColor = Variabili.PnlDX;
            // combo box
            CmbColoreLauncher.BackColor = Variabili.PnlDX;
            CmbColoreLauncher.BorderColor = Variabili.Scritte;
            CmbColoreLauncher.IconColor = Variabili.Scritte;
            CmbColoreLauncher.ListBackColor = Variabili.PnlSX;
            // #1
            CmbApp1.BackColor = Variabili.PnlDX;
            CmbApp1.BorderColor = Variabili.Scritte;
            CmbApp1.IconColor = Variabili.Scritte;
            CmbApp1.ListBackColor = Variabili.PnlSX;
            // #2
            CmbApp2.BackColor = Variabili.PnlDX;
            CmbApp2.BorderColor = Variabili.Scritte;
            CmbApp2.IconColor = Variabili.Scritte;
            CmbApp2.ListBackColor = Variabili.PnlSX;
            // #3
            CmbApp3.BackColor = Variabili.PnlDX;
            CmbApp3.BorderColor = Variabili.Scritte;
            CmbApp3.IconColor = Variabili.Scritte;
            CmbApp3.ListBackColor = Variabili.PnlSX;
            // #4
            CmbApp4.BackColor = Variabili.PnlDX;
            CmbApp4.BorderColor = Variabili.Scritte;
            CmbApp4.IconColor = Variabili.Scritte;
            CmbApp4.ListBackColor = Variabili.PnlSX;
            ////////////////// radio button
            /////////trasparenza
            RdbTrasparenzaAttiva.BackColor = Variabili.PnlDX;
            RdbTrasparenzaAttiva.ForeColor = Variabili.Scritte;

            RdbTrasparenzaDisattivata.BackColor = Variabili.PnlDX;
            RdbTrasparenzaDisattivata.ForeColor = Variabili.Scritte;

            RdbTrasparenzaAttiva.CheckedColor = Variabili.RdbCheckControl;
            RdbTrasparenzaAttiva.UnCheckedColor = Variabili.RdbUnCheckControl;

            RdbTrasparenzaDisattivata.CheckedColor = Variabili.RdbCheckControl;
            RdbTrasparenzaDisattivata.UnCheckedColor = Variabili.RdbUnCheckControl;
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
            string Colore = CmbColoreLauncher.Texts;
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
                BtnRiordinaApps.Image = Resources.ListAppsNero;
                BtnAvvia.Image = Resources.AvviaNero;
                BtnRegistraGioco.Image = Resources.DbNero;
                bool check = false;
                BtncheckImageEXE(check);
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
                BtnRiordinaApps.Image = Resources.ListAppsNero;
                BtnAvvia.Image = Resources.AvviaNero;
                BtnRegistraGioco.Image = Resources.DbNero;
                bool check = false;
                BtncheckImageEXE(check);
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
                BtnRiordinaApps.Image = Resources.ListApps;
                BtnAvvia.Image = Resources.Avvia;
                BtnRegistraGioco.Image = Resources.database;
                bool check = true;
                BtncheckImageEXE(check);
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
                BtnRiordinaApps.Image = Resources.ListAppsNero;
                BtnAvvia.Image = Resources.AvviaNero;
                BtnRegistraGioco.Image = Resources.DbNero;
                bool check = false;
                BtncheckImageEXE(check);
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

            if (logo == "")
            {
                Logo = true;
            }
        }

        private void BtncheckImageEXE(bool check)
        {
            bool check1 = check; // per farlo passare all'altro sotto programma
            bool Checkapp1, Checkapp2, Checkapp3, Checkapp4;

            Checkapp1 = ImageComparer.IsImageEqualToAny(BtnApp1.Image, Resources.App, Resources.appNero);
            Checkapp2 = ImageComparer.IsImageEqualToAny(BtnApp2.Image, Resources.App, Resources.appNero);
            Checkapp3 = ImageComparer.IsImageEqualToAny(BtnApp3.Image, Resources.App, Resources.appNero);
            Checkapp4 = ImageComparer.IsImageEqualToAny(BtnApp4.Image, Resources.App, Resources.appNero);

            ColoreAppNoLogo(check1, Checkapp1, Checkapp2, Checkapp3, Checkapp4);
        }

        private void ColoreAppNoLogo(bool check, bool Checkapp1, bool Checkapp2, bool Checkapp3, bool Checkapp4)
        {
            if (check)
            {
                ColoreApp = Resources.App;
            }
            else
            {
                ColoreApp = Resources.appNero;
            }
            if (Variabili.Pass >= 1)
            {
                string Colore = CmbColoreLauncher.Texts;

                if (Colore == "Arancione")
                {
                    if (Checkapp1) { BtnApp1.Image = ColoreApp; }
                    if (Checkapp2) { BtnApp2.Image = ColoreApp; }
                    if (Checkapp3) { BtnApp3.Image = ColoreApp; }
                    if (Checkapp4) { BtnApp4.Image = ColoreApp; }
                }
                else if (Colore == "Verde")
                {
                    if (Checkapp1) { BtnApp1.Image = ColoreApp; }
                    if (Checkapp2) { BtnApp2.Image = ColoreApp; }
                    if (Checkapp3) { BtnApp3.Image = ColoreApp; }
                    if (Checkapp4) { BtnApp4.Image = ColoreApp; }
                }
                else if (Colore == "Blu")
                {
                    if (Checkapp1) { BtnApp1.Image = ColoreApp; }
                    if (Checkapp2) { BtnApp2.Image = ColoreApp; }
                    if (Checkapp3) { BtnApp3.Image = ColoreApp; }
                    if (Checkapp4) { BtnApp4.Image = ColoreApp; }
                }
                else if (Colore == "Dark Mode")
                { // quando faccio logo bianco devo cambiare
                    if (Checkapp1) { BtnApp1.Image = ColoreApp; }
                    if (Checkapp2) { BtnApp2.Image = ColoreApp; }
                    if (Checkapp3) { BtnApp3.Image = ColoreApp; }
                    if (Checkapp4) { BtnApp4.Image = ColoreApp; }
                }
                else
                {
                    MessageBox.Show($"Errore nella scelta del colore, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private async void CheckPrimoStart()
        {
            // guardo se è il primo start
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string connect, query;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();
            if (Variabili.Pass == 1)
            {
                // skip
            }
            else
            {
                await Task.Delay(500); // aspetto mezzo secondo per lasciare il tempo al db di modificare i dati
            }
            query = "SELECT Configurazione " +
                "FROM PrimoAccesso " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(query, cn);
            da = new OleDbDataAdapter(cmd);
            tabella = new DataTable();
            da.Fill(tabella);
            cn.Close();
            bool primoAccesso = Convert.ToBoolean(tabella.Rows[0]["Configurazione"]);
            if (!primoAccesso)
            {
                FrmPrimoStart frmPrimoStart = new FrmPrimoStart();
                frmPrimoStart.Show(this);
                this.BeginInvoke((Action)(() => this.Hide()));
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
        private void RefreshTrasparenzaRDB(string Query, OleDbConnection cn, OleDbCommand cmd, OleDbDataAdapter da, DataTable Tabella)
        {
            // carica trasparenza del form
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
                RdbTrasparenzaAttiva.Checked = true;
            }
            else
            {
                RdbTrasparenzaDisattivata.Checked = true;
            }
        }
        private void RefreshTrasparenza(string Query, OleDbConnection cn, OleDbCommand cmd, OleDbDataAdapter da, DataTable Tabella)
        {
            // carica trasparenza del form
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
        }
        private void RefreshSettingOrdina(string Query, OleDbConnection cn, OleDbCommand cmd, OleDbDataAdapter da, DataTable Tabella, int Apps)
        {
            // rende utilizzabili i bottoni necessari per riordinare
            Query = "SELECT * " +
                    "FROM Path ";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            Apps = Tabella.Rows.Count;
            switch (Apps)
            {
                case 1:
                    // nulla
                    break;
                case 2:
                    CmbApp1.Enabled = true;
                    CmbApp2.Enabled = true;
                    break;
                case 3:
                    CmbApp1.Enabled = true;
                    CmbApp2.Enabled = true;
                    CmbApp3.Enabled = true;
                    break;
                case 4:
                    CmbApp1.Enabled = true;
                    CmbApp2.Enabled = true;
                    CmbApp3.Enabled = true;
                    CmbApp4.Enabled = true;
                    break;
            }
        }
        private void CaricaComboBoxSettings(string Query, OleDbConnection cn, OleDbCommand cmd, OleDbDataAdapter da, DataTable Tabella)
        {
            // carica la combobox per ciascun app posizion 
            Query = "SELECT ID " +
                    "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            righe = Tabella.Rows.Count;
            for (int i = 0; i <= righe - 1; i++)
            {
                string id = Tabella.Rows[i]["ID"].ToString();
                CmbApp1.Items.Add(id);
                CmbApp2.Items.Add(id);
                CmbApp3.Items.Add(id);
                CmbApp4.Items.Add(id);
            }
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
            CmbColoreLauncher.Texts = colore;
        }
        private void CaricaRdbSettingsUscitaAuto(string Query, OleDbConnection cn, OleDbCommand cmd, OleDbDataAdapter da, DataTable Tabella)
        {
            // inserisce il check per rdb uscita auto richiesta dall'utente registrata nel db
            Query = "SELECT UscitaAuto " +
                    "FROM Utente " +
                    "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            bool UscitaAuto = Convert.ToBoolean(Tabella.Rows[0]["UscitaAuto"]);
            if (UscitaAuto)
            {
                RdbUscitaAutomaticaAttivato.Checked = true;
            }
            else
            {
                RdbUscitaAutomaticaDisattivata.Checked = true;
            }
        }
        private void InizializzazioneElementi()
        {
            AppNoLogo1 = false;
            AppNoLogo2 = false;
            AppNoLogo3 = false;
            AppNoLogo4 = false;
            app1 = false;
            app2 = false;
            app3 = false;
            app4 = false;
            BtnApp1.Visible = false;
            BtnApp2.Visible = false;
            BtnApp3.Visible = false;
            BtnApp4.Visible = false;
            LblNotificaImage.Visible = false;
            PcbMain.Visible = false;
            BtnAvvia.Visible = false;
            BtnRegistraGioco.Visible = false;
            LblDescSettingsUser.Visible = false;
            BtnSettingsLogoUsername.Visible = false;
            BtnFaqUscitaAutomatica.Visible = false;
            LblDescRiordina.Visible = false;
            LblDescSettingsOrdine1.Visible = false;
            LblDescSettingsOrdine2.Visible = false;
            LblDescSettingsOrdine3.Visible = false;
            LblDescSettingsOrdine4.Visible = false;
            LblDescColoreLauncher.Visible = false;
            CmbColoreLauncher.Visible = false;
            CmbApp1.Visible = false;
            CmbApp2.Visible = false;
            CmbApp3.Visible = false;
            CmbApp4.Visible = false;
            CmbApp1.Enabled = false;
            CmbApp2.Enabled = false;
            CmbApp3.Enabled = false;
            CmbApp4.Enabled = false;
            PnlSettingsTrasparenza.Visible = false;
            PnlSettingsUscitaAuto.Visible = false;
            BtnRiordinaApps.Visible = false;
            BtnSettingDisinstalla.Visible = false;
            PcbMain.Location = new Point(188, 43);
        }
        private void BtnAllineamentoImage()
        {
            //int Max = 28;
            //while (BtnApp1.Text.Length < Max)
            //{
            //    BtnApp1.Text += " ";
            //}
            //while (BtnApp2.Text.Length < Max)
            //{
            //    BtnApp2.Text += " ";
            //}
            //while (BtnApp3.Text.Length < Max)
            //{
            //    BtnApp3.Text += " ";
            //}
            //while (BtnApp4.Text.Length < Max)
            //{
            //    BtnApp4.Text += " ";
            //}
        }
    }
}
