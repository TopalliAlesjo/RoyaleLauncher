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
    public partial class FrmApplicazioni : Form
    {
        int Apps;
        bool Logo = false,DarkMode = false;
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

        public FrmApplicazioni()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            RefreshUsernameLogo();
            RefreshTrasparenza();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            Variabili.Pass2 += 1;
            Variabili.FrmAppsPassaggioBtnHome = false; // inizializzo var

            RefreshTrasparenza(); // carica trasparenza form
            CaricaVariabiliColori(); // carica stile di colore del form
            RefreshBottoni();
        }
        private void RefreshBottoni()
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connect, Query;


            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();

            //////////////////////////////////////////////////
            // carico tutta la tabella path sulla [Tabella] e prende numero di apps
            Query = "SELECT * " +
                    "FROM Path ";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            Apps = Tabella.Rows.Count;
            ////////////////////////////////////

            ////////////////////////// imposta location X in base ai pannelli
            if (Apps > 6)
            {
                BtnEsci.Location = new Point(580, 7);
            }
            else
            {
                BtnEsci.Location = new Point(765, 7);
            }
            //////////////////////////

            // rende visibili i bottoni necessari
            ShowBtnNecessari();

            // carica i bottini
            CaricaBtnApps(Query, cn, cmd, da, Tabella);

        }
        private void ShowBtnNecessari()
        {
            switch (Apps)
            {
                // prima dello spazio = Bottoni ATTIVI
                // dopo lo spazio = bottono NON ATTIVI
                case 1:
                    PnlMenu.Visible = true;
                    BtnApp1.Visible = true;

                    PnlMenu2.Visible = false;
                    BtnApp2.Visible = false;
                    BtnApp3.Visible = false;
                    BtnApp4.Visible = false;
                    BtnApp5.Visible = false;
                    BtnApp6.Visible = false;
                    BtnApp7.Visible = false;
                    BtnApp8.Visible = false;
                    BtnApp9.Visible = false;
                    BtnApp10.Visible = false;
                    BtnApp11.Visible = false;
                    BtnApp12.Visible = false;

                    break;
                case 2:
                    PnlMenu.Visible = true;
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;

                    PnlMenu2.Visible = false;
                    BtnApp3.Visible = false;
                    BtnApp4.Visible = false;
                    BtnApp5.Visible = false;
                    BtnApp6.Visible = false;
                    BtnApp7.Visible = false;
                    BtnApp8.Visible = false;
                    BtnApp9.Visible = false;
                    BtnApp10.Visible = false;
                    BtnApp11.Visible = false;
                    BtnApp12.Visible = false;
                    break;
                case 3:
                    PnlMenu.Visible = true;
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;
                    BtnApp3.Visible = true;

                    PnlMenu2.Visible = false;
                    BtnApp4.Visible = false;
                    BtnApp5.Visible = false;
                    BtnApp6.Visible = false;
                    BtnApp7.Visible = false;
                    BtnApp8.Visible = false;
                    BtnApp9.Visible = false;
                    BtnApp10.Visible = false;
                    BtnApp11.Visible = false;
                    BtnApp12.Visible = false;
                    break;
                case 4:
                    PnlMenu.Visible = true;
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;
                    BtnApp3.Visible = true;
                    BtnApp4.Visible = true;

                    PnlMenu2.Visible = false;
                    BtnApp5.Visible = false;
                    BtnApp6.Visible = false;
                    BtnApp7.Visible = false;
                    BtnApp8.Visible = false;
                    BtnApp9.Visible = false;
                    BtnApp10.Visible = false;
                    BtnApp11.Visible = false;
                    BtnApp12.Visible = false;
                    break;
                case 5:
                    PnlMenu.Visible = true;
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;
                    BtnApp3.Visible = true;
                    BtnApp4.Visible = true;
                    BtnApp5.Visible = true;

                    PnlMenu2.Visible = false;
                    BtnApp6.Visible = false;
                    BtnApp7.Visible = false;
                    BtnApp8.Visible = false;
                    BtnApp9.Visible = false;
                    BtnApp10.Visible = false;
                    BtnApp11.Visible = false;
                    BtnApp12.Visible = false;
                    break;
                case 6:
                    PnlMenu.Visible = true;
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;
                    BtnApp3.Visible = true;
                    BtnApp4.Visible = true;
                    BtnApp5.Visible = true;
                    BtnApp6.Visible = true;

                    PnlMenu2.Visible = false;
                    BtnApp7.Visible = false;
                    BtnApp8.Visible = false;
                    BtnApp9.Visible = false;
                    BtnApp10.Visible = false;
                    BtnApp11.Visible = false;
                    BtnApp12.Visible = false;
                    break;
                case 7:
                    PnlMenu.Visible = true;
                    PnlMenu2.Visible = true;
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;
                    BtnApp3.Visible = true;
                    BtnApp4.Visible = true;
                    BtnApp5.Visible = true;
                    BtnApp6.Visible = true;
                    BtnApp7.Visible = true;

                    BtnApp8.Visible = false;
                    BtnApp9.Visible = false;
                    BtnApp10.Visible = false;
                    BtnApp11.Visible = false;
                    BtnApp12.Visible = false;
                    break;
                case 8:
                    PnlMenu.Visible = true;
                    PnlMenu2.Visible = true;
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;
                    BtnApp3.Visible = true;
                    BtnApp4.Visible = true;
                    BtnApp5.Visible = true;
                    BtnApp6.Visible = true;
                    BtnApp7.Visible = true;
                    BtnApp8.Visible = true;

                    BtnApp9.Visible = false;
                    BtnApp10.Visible = false;
                    BtnApp11.Visible = false;
                    BtnApp12.Visible = false;
                    break;
                case 9:
                    PnlMenu.Visible = true;
                    PnlMenu2.Visible = true;
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;
                    BtnApp3.Visible = true;
                    BtnApp4.Visible = true;
                    BtnApp5.Visible = true;
                    BtnApp6.Visible = true;
                    BtnApp7.Visible = true;
                    BtnApp8.Visible = true;
                    BtnApp9.Visible = true;

                    BtnApp10.Visible = false;
                    BtnApp11.Visible = false;
                    BtnApp12.Visible = false;
                    break;
                case 10:
                    PnlMenu.Visible = true;
                    PnlMenu2.Visible = true;
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;
                    BtnApp3.Visible = true;
                    BtnApp4.Visible = true;
                    BtnApp5.Visible = true;
                    BtnApp6.Visible = true;
                    BtnApp7.Visible = true;
                    BtnApp8.Visible = true;
                    BtnApp9.Visible = true;
                    BtnApp10.Visible = true;

                    BtnApp11.Visible = false;
                    BtnApp12.Visible = false;
                    break;
                case 11:
                    PnlMenu.Visible = true;
                    PnlMenu2.Visible = true;
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;
                    BtnApp3.Visible = true;
                    BtnApp4.Visible = true;
                    BtnApp5.Visible = true;
                    BtnApp6.Visible = true;
                    BtnApp7.Visible = true;
                    BtnApp8.Visible = true;
                    BtnApp9.Visible = true;
                    BtnApp10.Visible = true;
                    BtnApp11.Visible = true;

                    BtnApp12.Visible = false;
                    break;
                case 12:
                    BtnApp1.Visible = true;
                    BtnApp2.Visible = true;
                    BtnApp3.Visible = true;
                    BtnApp4.Visible = true;
                    BtnApp5.Visible = true;
                    BtnApp6.Visible = true;
                    BtnApp7.Visible = true;
                    BtnApp8.Visible = true;
                    BtnApp9.Visible = true;
                    BtnApp10.Visible = true;
                    BtnApp11.Visible = true;
                    BtnApp12.Visible = true;
                    break;
            }
        }
        private void CaricaBtnApps(string Query, OleDbConnection cn, OleDbCommand cmd, OleDbDataAdapter da, DataTable Tabella)
        {
            string id = "", start2 = "", fileExtension = "";
            switch (Apps)
            {
                case 5:
                    ///////////////////////////////////////// prende ID #1
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;
                    ///////////////////////////////////////// prende Start #1
                    start2 = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;
                    ///////////////////////////////////////// prende ID #2
                    id = Tabella.Rows[1]["ID"].ToString();
                    BtnApp2.Text = id;
                    ///////////////////////////////////////// prende Start #2
                    start2 = Tabella.Rows[1]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;
                    ///////////////////////////////////////// prende ID #3
                    id = Tabella.Rows[2]["ID"].ToString();
                    BtnApp3.Text = id;
                    ///////////////////////////////////////// prende Start #3
                    start2 = Tabella.Rows[2]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp3.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp3.Image = ColoreApp;
                    }
                    BtnApp3.Visible = true;
                    ///////////////////////////////////////// prende ID #4
                    id = Tabella.Rows[3]["ID"].ToString();
                    BtnApp4.Text = id;
                    ///////////////////////////////////////// prende Start #4
                    start2 = Tabella.Rows[3]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp4.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp4.Image = ColoreApp;
                    }
                    BtnApp4.Visible = true;
                    ///////////////////////////////////////// prende ID #5
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp5.Text = id;
                    ///////////////////////////////////////// prende Start #5
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp5.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp5.Image = ColoreApp;
                    }
                    BtnApp5.Visible = true;
                    break;
                case 6:
                    ///////////////////////////////////////// prende ID #1
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;
                    ///////////////////////////////////////// prende Start #1
                    start2 = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;
                    ///////////////////////////////////////// prende ID #2
                    id = Tabella.Rows[1]["ID"].ToString();
                    BtnApp2.Text = id;
                    ///////////////////////////////////////// prende Start #2
                    start2 = Tabella.Rows[1]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;
                    ///////////////////////////////////////// prende ID #3
                    id = Tabella.Rows[2]["ID"].ToString();
                    BtnApp3.Text = id;
                    ///////////////////////////////////////// prende Start #3
                    start2 = Tabella.Rows[2]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp3.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp3.Image = ColoreApp;
                    }
                    BtnApp3.Visible = true;
                    ///////////////////////////////////////// prende ID #4
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp4.Text = id;
                    ///////////////////////////////////////// prende Start #4
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp4.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp4.Image = ColoreApp;
                    }
                    BtnApp4.Visible = true;
                    ///////////////////////////////////////// prende ID #5
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp5.Text = id;
                    ///////////////////////////////////////// prende Start #5
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp5.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp5.Image = ColoreApp;
                    }
                    BtnApp5.Visible = true;
                    ///////////////////////////////////////// prende ID #6
                    id = Tabella.Rows[5]["ID"].ToString();
                    BtnApp6.Text = id;
                    ///////////////////////////////////////// prende Start #6
                    start2 = Tabella.Rows[5]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp6.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp6.Image = ColoreApp;
                    }
                    BtnApp6.Visible = true;
                    break;
                case 7:
                    ///////////////////////////////////////// prende ID #1
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;
                    ///////////////////////////////////////// prende Start #1
                    start2 = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;
                    ///////////////////////////////////////// prende ID #2
                    id = Tabella.Rows[1]["ID"].ToString();
                    BtnApp2.Text = id;
                    ///////////////////////////////////////// prende Start #2
                    start2 = Tabella.Rows[1]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;
                    ///////////////////////////////////////// prende ID #3
                    id = Tabella.Rows[2]["ID"].ToString();
                    BtnApp3.Text = id;
                    ///////////////////////////////////////// prende Start #3
                    start2 = Tabella.Rows[2]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp3.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp3.Image = ColoreApp;
                    }
                    BtnApp3.Visible = true;
                    ///////////////////////////////////////// prende ID #4
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp4.Text = id;
                    ///////////////////////////////////////// prende Start #4
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp4.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp4.Image = ColoreApp;
                    }
                    BtnApp4.Visible = true;
                    ///////////////////////////////////////// prende ID #5
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp5.Text = id;
                    ///////////////////////////////////////// prende Start #5
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp5.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp5.Image = ColoreApp;
                    }
                    BtnApp5.Visible = true;
                    ///////////////////////////////////////// prende ID #6
                    id = Tabella.Rows[5]["ID"].ToString();
                    BtnApp6.Text = id;
                    ///////////////////////////////////////// prende Start #6
                    start2 = Tabella.Rows[5]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp6.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp6.Image = ColoreApp;
                    }
                    BtnApp6.Visible = true;
                    ///////////////////////////////////////// prende ID #7
                    id = Tabella.Rows[6]["ID"].ToString();
                    BtnApp7.Text = id;
                    ///////////////////////////////////////// prende Start #7
                    start2 = Tabella.Rows[6]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp7.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp7.Image = ColoreApp;
                    }
                    BtnApp7.Visible = true;
                    break;
                case 8:
                    ///////////////////////////////////////// prende ID #1
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;
                    ///////////////////////////////////////// prende Start #1
                    start2 = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;
                    ///////////////////////////////////////// prende ID #2
                    id = Tabella.Rows[1]["ID"].ToString();
                    BtnApp2.Text = id;
                    ///////////////////////////////////////// prende Start #2
                    start2 = Tabella.Rows[1]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;
                    ///////////////////////////////////////// prende ID #3
                    id = Tabella.Rows[2]["ID"].ToString();
                    BtnApp3.Text = id;
                    ///////////////////////////////////////// prende Start #3
                    start2 = Tabella.Rows[2]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp3.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp3.Image = ColoreApp;
                    }
                    BtnApp3.Visible = true;
                    ///////////////////////////////////////// prende ID #4
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp4.Text = id;
                    ///////////////////////////////////////// prende Start #4
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp4.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp4.Image = ColoreApp;
                    }
                    BtnApp4.Visible = true;
                    ///////////////////////////////////////// prende ID #5
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp5.Text = id;
                    ///////////////////////////////////////// prende Start #5
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp5.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp5.Image = ColoreApp;
                    }
                    BtnApp5.Visible = true;
                    ///////////////////////////////////////// prende ID #6
                    id = Tabella.Rows[5]["ID"].ToString();
                    BtnApp6.Text = id;
                    ///////////////////////////////////////// prende Start #6
                    start2 = Tabella.Rows[5]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp6.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp6.Image = ColoreApp;
                    }
                    BtnApp6.Visible = true;
                    ///////////////////////////////////////// prende ID #7
                    id = Tabella.Rows[6]["ID"].ToString();
                    BtnApp7.Text = id;
                    ///////////////////////////////////////// prende Start #7
                    start2 = Tabella.Rows[6]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp7.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp7.Image = ColoreApp;
                    }
                    BtnApp7.Visible = true;
                    ///////////////////////////////////////// prende ID #8
                    id = Tabella.Rows[7]["ID"].ToString();
                    BtnApp8.Text = id;
                    ///////////////////////////////////////// prende Start #8
                    start2 = Tabella.Rows[7]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp8.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp8.Image = ColoreApp;
                    }
                    BtnApp8.Visible = true;
                    break;
                case 9:
                    ///////////////////////////////////////// prende ID #1
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;
                    ///////////////////////////////////////// prende Start #1
                    start2 = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;
                    ///////////////////////////////////////// prende ID #2
                    id = Tabella.Rows[1]["ID"].ToString();
                    BtnApp2.Text = id;
                    ///////////////////////////////////////// prende Start #2
                    start2 = Tabella.Rows[1]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;
                    ///////////////////////////////////////// prende ID #3
                    id = Tabella.Rows[2]["ID"].ToString();
                    BtnApp3.Text = id;
                    ///////////////////////////////////////// prende Start #3
                    start2 = Tabella.Rows[2]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp3.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp3.Image = ColoreApp;
                    }
                    BtnApp3.Visible = true;
                    ///////////////////////////////////////// prende ID #4
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp4.Text = id;
                    ///////////////////////////////////////// prende Start #4
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp4.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp4.Image = ColoreApp;
                    }
                    BtnApp4.Visible = true;
                    ///////////////////////////////////////// prende ID #5
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp5.Text = id;
                    ///////////////////////////////////////// prende Start #5
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp5.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp5.Image = ColoreApp;
                    }
                    BtnApp5.Visible = true;
                    ///////////////////////////////////////// prende ID #6
                    id = Tabella.Rows[5]["ID"].ToString();
                    BtnApp6.Text = id;
                    ///////////////////////////////////////// prende Start #6
                    start2 = Tabella.Rows[5]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp6.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp6.Image = ColoreApp;
                    }
                    BtnApp6.Visible = true;
                    ///////////////////////////////////////// prende ID #7
                    id = Tabella.Rows[6]["ID"].ToString();
                    BtnApp7.Text = id;
                    ///////////////////////////////////////// prende Start #7
                    start2 = Tabella.Rows[6]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp7.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp7.Image = ColoreApp;
                    }
                    BtnApp7.Visible = true;
                    ///////////////////////////////////////// prende ID #8
                    id = Tabella.Rows[7]["ID"].ToString();
                    BtnApp8.Text = id;
                    ///////////////////////////////////////// prende Start #8
                    start2 = Tabella.Rows[7]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp8.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp8.Image = ColoreApp;
                    }
                    BtnApp8.Visible = true;
                    ///////////////////////////////////////// prende ID #9
                    id = Tabella.Rows[8]["ID"].ToString();
                    BtnApp9.Text = id;
                    ///////////////////////////////////////// prende Start #9
                    start2 = Tabella.Rows[8]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp9.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp9.Image = ColoreApp;
                    }
                    BtnApp9.Visible = true;
                    break;
                case 10:
                    ///////////////////////////////////////// prende ID #1
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;
                    ///////////////////////////////////////// prende Start #1
                    start2 = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;
                    ///////////////////////////////////////// prende ID #2
                    id = Tabella.Rows[1]["ID"].ToString();
                    BtnApp2.Text = id;
                    ///////////////////////////////////////// prende Start #2
                    start2 = Tabella.Rows[1]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;
                    ///////////////////////////////////////// prende ID #3
                    id = Tabella.Rows[2]["ID"].ToString();
                    BtnApp3.Text = id;
                    ///////////////////////////////////////// prende Start #3
                    start2 = Tabella.Rows[2]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp3.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp3.Image = ColoreApp; ;
                    }
                    BtnApp3.Visible = true;
                    ///////////////////////////////////////// prende ID #4
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp4.Text = id;
                    ///////////////////////////////////////// prende Start #4
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp4.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp4.Image = ColoreApp;
                    }
                    BtnApp4.Visible = true;
                    ///////////////////////////////////////// prende ID #5
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp5.Text = id;
                    ///////////////////////////////////////// prende Start #5
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp5.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp5.Image = ColoreApp;
                    }
                    BtnApp5.Visible = true;
                    ///////////////////////////////////////// prende ID #6
                    id = Tabella.Rows[5]["ID"].ToString();
                    BtnApp6.Text = id;
                    ///////////////////////////////////////// prende Start #6
                    start2 = Tabella.Rows[5]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp6.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp6.Image = ColoreApp;
                    }
                    BtnApp6.Visible = true;
                    ///////////////////////////////////////// prende ID #7
                    id = Tabella.Rows[6]["ID"].ToString();
                    BtnApp7.Text = id;
                    ///////////////////////////////////////// prende Start #7
                    start2 = Tabella.Rows[6]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp7.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp7.Image = ColoreApp;
                    }
                    BtnApp7.Visible = true;
                    ///////////////////////////////////////// prende ID #8
                    id = Tabella.Rows[7]["ID"].ToString();
                    BtnApp8.Text = id;
                    ///////////////////////////////////////// prende Start #8
                    start2 = Tabella.Rows[7]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp8.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp8.Image = ColoreApp;
                    }
                    BtnApp8.Visible = true;
                    ///////////////////////////////////////// prende ID #9
                    id = Tabella.Rows[8]["ID"].ToString();
                    BtnApp9.Text = id;
                    ///////////////////////////////////////// prende Start #9
                    start2 = Tabella.Rows[8]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp9.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp9.Image = ColoreApp; ;
                    }
                    BtnApp9.Visible = true;
                    ///////////////////////////////////////// prende ID #10
                    id = Tabella.Rows[9]["ID"].ToString();
                    BtnApp10.Text = id;
                    ///////////////////////////////////////// prende Start #10
                    start2 = Tabella.Rows[9]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp10.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp10.Image = ColoreApp;
                    }
                    BtnApp10.Visible = true;
                    break;
                case 11:
                    ///////////////////////////////////////// prende ID #1
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;
                    ///////////////////////////////////////// prende Start #1
                    start2 = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;
                    ///////////////////////////////////////// prende ID #2
                    id = Tabella.Rows[1]["ID"].ToString();
                    BtnApp2.Text = id;
                    ///////////////////////////////////////// prende Start #2
                    start2 = Tabella.Rows[1]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;
                    ///////////////////////////////////////// prende ID #3
                    id = Tabella.Rows[2]["ID"].ToString();
                    BtnApp3.Text = id;
                    ///////////////////////////////////////// prende Start #3
                    start2 = Tabella.Rows[2]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp3.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp3.Image = ColoreApp;
                    }
                    BtnApp3.Visible = true;
                    ///////////////////////////////////////// prende ID #4
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp4.Text = id;
                    ///////////////////////////////////////// prende Start #4
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp4.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp4.Image = ColoreApp;
                    }
                    BtnApp4.Visible = true;
                    ///////////////////////////////////////// prende ID #5
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp5.Text = id;
                    ///////////////////////////////////////// prende Start #5
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp5.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp5.Image = ColoreApp;
                    }
                    BtnApp5.Visible = true;
                    ///////////////////////////////////////// prende ID #6
                    id = Tabella.Rows[5]["ID"].ToString();
                    BtnApp6.Text = id;
                    ///////////////////////////////////////// prende Start #6
                    start2 = Tabella.Rows[5]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp6.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp6.Image = ColoreApp;
                    }
                    BtnApp6.Visible = true;
                    ///////////////////////////////////////// prende ID #7
                    id = Tabella.Rows[6]["ID"].ToString();
                    BtnApp7.Text = id;
                    ///////////////////////////////////////// prende Start #7
                    start2 = Tabella.Rows[6]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp7.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp7.Image = ColoreApp;
                    }
                    BtnApp7.Visible = true;
                    ///////////////////////////////////////// prende ID #8
                    id = Tabella.Rows[7]["ID"].ToString();
                    BtnApp8.Text = id;
                    ///////////////////////////////////////// prende Start #8
                    start2 = Tabella.Rows[7]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp8.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp8.Image = ColoreApp;
                    }
                    BtnApp8.Visible = true;
                    ///////////////////////////////////////// prende ID #9
                    id = Tabella.Rows[8]["ID"].ToString();
                    BtnApp9.Text = id;
                    ///////////////////////////////////////// prende Start #9
                    start2 = Tabella.Rows[8]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp9.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp9.Image = ColoreApp;
                    }
                    BtnApp9.Visible = true;
                    ///////////////////////////////////////// prende ID #10
                    id = Tabella.Rows[9]["ID"].ToString();
                    BtnApp10.Text = id;
                    ///////////////////////////////////////// prende Start #10
                    start2 = Tabella.Rows[9]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp10.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp10.Image = ColoreApp;
                    }
                    BtnApp10.Visible = true;
                    ///////////////////////////////////////// prende ID #11
                    id = Tabella.Rows[10]["ID"].ToString();
                    BtnApp11.Text = id;
                    ///////////////////////////////////////// prende Start #11
                    start2 = Tabella.Rows[10]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp11.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp11.Image = ColoreApp;
                    }
                    BtnApp11.Visible = true;
                    break;
                case 12:
                    ///////////////////////////////////////// prende ID #1
                    id = Tabella.Rows[0]["ID"].ToString();
                    BtnApp1.Text = id;
                    ///////////////////////////////////////// prende Start #1
                    start2 = Tabella.Rows[0]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp1.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp1.Image = ColoreApp;
                    }
                    BtnApp1.Visible = true;
                    ///////////////////////////////////////// prende ID #2
                    id = Tabella.Rows[1]["ID"].ToString();
                    BtnApp2.Text = id;
                    ///////////////////////////////////////// prende Start #2
                    start2 = Tabella.Rows[1]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp2.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp2.Image = ColoreApp;
                    }
                    BtnApp2.Visible = true;
                    ///////////////////////////////////////// prende ID #3
                    id = Tabella.Rows[2]["ID"].ToString();
                    BtnApp3.Text = id;
                    ///////////////////////////////////////// prende Start #3
                    start2 = Tabella.Rows[2]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp3.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp3.Image = ColoreApp;
                    }
                    BtnApp3.Visible = true;
                    ///////////////////////////////////////// prende ID #4
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp4.Text = id;
                    ///////////////////////////////////////// prende Start #4
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp4.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp4.Image = ColoreApp;
                    }
                    BtnApp4.Visible = true;
                    ///////////////////////////////////////// prende ID #5
                    id = Tabella.Rows[4]["ID"].ToString();
                    BtnApp5.Text = id;
                    ///////////////////////////////////////// prende Start #5
                    start2 = Tabella.Rows[4]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp5.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp5.Image = ColoreApp;
                    }
                    BtnApp5.Visible = true;
                    ///////////////////////////////////////// prende ID #6
                    id = Tabella.Rows[5]["ID"].ToString();
                    BtnApp6.Text = id;
                    ///////////////////////////////////////// prende Start #6
                    start2 = Tabella.Rows[5]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp6.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp6.Image = ColoreApp;
                    }
                    BtnApp6.Visible = true;
                    ///////////////////////////////////////// prende ID #7
                    id = Tabella.Rows[6]["ID"].ToString();
                    BtnApp7.Text = id;
                    ///////////////////////////////////////// prende Start #7
                    start2 = Tabella.Rows[6]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp7.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp7.Image = ColoreApp;
                    }
                    BtnApp7.Visible = true;
                    ///////////////////////////////////////// prende ID #8
                    id = Tabella.Rows[7]["ID"].ToString();
                    BtnApp8.Text = id;
                    ///////////////////////////////////////// prende Start #8
                    start2 = Tabella.Rows[7]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp8.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp8.Image = ColoreApp;
                    }
                    BtnApp8.Visible = true;
                    ///////////////////////////////////////// prende ID #9
                    id = Tabella.Rows[8]["ID"].ToString();
                    BtnApp9.Text = id;
                    ///////////////////////////////////////// prende Start #9
                    start2 = Tabella.Rows[8]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp9.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp9.Image = ColoreApp;
                    }
                    BtnApp9.Visible = true;
                    ///////////////////////////////////////// prende ID #10
                    id = Tabella.Rows[9]["ID"].ToString();
                    BtnApp10.Text = id;
                    ///////////////////////////////////////// prende Start #10
                    start2 = Tabella.Rows[9]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp10.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp10.Image = ColoreApp;
                    }
                    BtnApp10.Visible = true;
                    ///////////////////////////////////////// prende ID #11
                    id = Tabella.Rows[10]["ID"].ToString();
                    BtnApp11.Text = id;
                    ///////////////////////////////////////// prende Start #11
                    start2 = Tabella.Rows[10]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp11.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp11.Image = ColoreApp;
                    }
                    BtnApp11.Visible = true;
                    ///////////////////////////////////////// prende ID #12
                    id = Tabella.Rows[11]["ID"].ToString();
                    BtnApp12.Text = id;
                    ///////////////////////////////////////// prende Start #12
                    start2 = Tabella.Rows[11]["start"].ToString();
                    fileExtension = System.IO.Path.GetExtension(start2);
                    if (fileExtension.ToLower() == ".exe")
                    {
                        Icon appIcon = Icon.ExtractAssociatedIcon(start2);
                        Image BtnImage = appIcon.ToBitmap();
                        BtnApp12.Image = BtnImage;
                    }
                    else
                    {
                        BtnApp12.Image = ColoreApp;
                    }
                    BtnApp12.Visible = true;
                    break;
                default:
                    MessageBox.Show($"Errore nell'avvio dell'app, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        /// <riassuntoBtnApp>
        ///  si connette al db
        ///  seleziona il path
        ///  e avvia il processo interessato
        ///  QUESTA SPIEGAZIONE VALE PER TUTTI E 12 BtnApp
        /// </riassuntoBtnApp>

        private void BtnApp1_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[0]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }

        private void BtnApp2_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[1]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }

        private void BtnApp3_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[2]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }




        private void BtnApp4_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[3]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }

        private void BtnApp5_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[4]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }

        private void BtnApp6_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[5]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }

        private void BtnApp7_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[6]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }

        private void BtnApp8_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[7]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }

        private void BtnApp9_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[8]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }

        private void BtnApp10_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[9]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }

        private void BtnApp11_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[10]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }

        private void BtnApp12_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Connetti, Query, path;

            Connetti = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connetti);
            cn.Open();

            Query = "SELECT start " +
                "FROM Path";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);

            tabella = new DataTable();
            da.Fill(tabella);
            path = tabella.Rows[11]["start"].ToString();

            cn.Close();

            Process.Start(path);
            UscitaAutomatica();
        }
        public void BtnHome_Click(object sender, EventArgs e)
        {
            //  inizializzo-modifico variabili
            Variabili.AperturaDB = false;
            Variabili.FrmAppsPassaggioBtnHome = true;
            // apro frmMiddleman
            FrmMiddleMan frmMiddleMan = new FrmMiddleMan();
            frmMiddleMan.Show();
            // starto i timer check
            TmrCheckChiusura.Start();
            TmrCheckUsernameLogo.Start();
        }
        private void TmrCheckChiusura_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed) // se frmApplicazioni è stato eliminato stoppare timers
            {
                StopTmrCheckChiusura();
                StopTmrCheckUsernameLogo();
                return;
            }
            if (Variabili.AperturaDB) // se frmDatabase è stato aperto nascondere questo e stoppare timers
            {
                StopTmrCheckChiusura();
                StopTmrCheckUsernameLogo();
                RefreshTrasparenza();
                this.Hide();
            }
            if (Variabili.FrmMiddleManSettings) // se è stato chiuso frmMiddleMan stoppare timer e refreshare trasparenza
            {
                StopTmrCheckChiusura();
                StopTmrCheckUsernameLogo();
                RefreshTrasparenza();
            }
        }

        private async void TmrCheckUsernameLogo_Tick(object sender, EventArgs e)
        {
            if (Variabili.FrmUsernamePERapps) // se è stato chiuso frmModificaUsername stoppare timers e refreshare logo
            {
                StopTmrCheckChiusura();
                StopTmrCheckUsernameLogo();
                await Task.Delay(100);
                RefreshUsernameLogo();
                RefreshTrasparenza();
            }
        }
        private void StopTmrCheckChiusura() // sottoprogramma per stoppare timer oppure non si ferma con il ciclo del timer
        {
            TmrCheckChiusura.Stop();
        }
        private void StopTmrCheckUsernameLogo() // sottoprogramma per stoppare timer oppure non si ferma con il ciclo del timer
        {
            TmrCheckUsernameLogo.Stop();
        }
        private void BtnEsci_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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
                } else
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
        private void RefreshTrasparenza()
        {
            // carica trasparenza del form
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connect, Query;

            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();

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

        private void PnlToolBar_MouseDown(object sender, MouseEventArgs e) // trascinare finestra
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void UscitaAutomatica()
        {
            // sotto programma che controlla se l'uscita è automatica per tutte le app
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable tabella;
            string Query, Connect;

            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);

            Query = "SELECT UscitaAuto " +
                   "FROM Utente " +
                  "WHERE ID = 1";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            tabella = new DataTable();
            da.Fill(tabella);
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

        private void FrmApplicazioni_VisibleChanged(object sender, EventArgs e)
        {
            if (Variabili.Pass2 > 1 || Variabili.FrmAppsPassaggioMainDatabase)
            {
                RefreshBottoni();
                Variabili.FrmAppsPassaggioMainDatabase = false; // inizializzo cosi da poterlo riutilizzare
            }
        }
        private void CaricaVariabiliColori()
        {
            DarkMode = false;
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
            // assegno i colori nelle variabili in base alla scelta poichè è un form load di pilastro allo start


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
                Variabili.BtnAttivo = Color.FromArgb(255, 140, 0);
                Variabili.BtnDisattivo = Color.FromArgb(255, 110, 0);
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
            ///// username-online
            LblUsername.ForeColor = Variabili.Scritte;
            LblDescUsername.ForeColor = Variabili.Online;
            // pannelli
            PnlMenu.BackColor = Variabili.PnlSX;
            PnlMenu2.BackColor = Variabili.PnlSX;
            PnlHome.BackColor = Variabili.PnlSX;

            this.BackColor = Variabili.PnlDX;
            // bottoni pnlSX back color
            BtnHome.BackColor = Variabili.PnlSX;
            BtnApp1.BackColor = Variabili.PnlSX;
            BtnApp2.BackColor = Variabili.PnlSX;
            BtnApp3.BackColor = Variabili.PnlSX;
            BtnApp4.BackColor = Variabili.PnlSX;
            BtnApp5.BackColor = Variabili.PnlSX;
            BtnApp6.BackColor = Variabili.PnlSX;
            BtnApp7.BackColor = Variabili.PnlSX;
            BtnApp8.BackColor = Variabili.PnlSX;
            BtnApp9.BackColor = Variabili.PnlSX;
            BtnApp10.BackColor = Variabili.PnlSX;
            BtnApp11.BackColor = Variabili.PnlSX;
            BtnApp12.BackColor = Variabili.PnlSX;
            // bottoni pnlSX fore color
            BtnHome.ForeColor = Variabili.Scritte;
            BtnApp1.ForeColor = Variabili.Scritte;
            BtnApp2.ForeColor = Variabili.Scritte;
            BtnApp3.ForeColor = Variabili.Scritte;
            BtnApp4.ForeColor = Variabili.Scritte;
            BtnApp5.ForeColor = Variabili.Scritte;
            BtnApp6.ForeColor = Variabili.Scritte;
            BtnApp7.ForeColor = Variabili.Scritte;
            BtnApp8.ForeColor = Variabili.Scritte;
            BtnApp9.ForeColor = Variabili.Scritte;
            BtnApp10.ForeColor = Variabili.Scritte;
            BtnApp11.ForeColor = Variabili.Scritte;
            BtnApp12.ForeColor = Variabili.Scritte;
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
                BtnHome.Image = Resources.HomeNero;
                bool check = false;
                ColoreAppNoLogo(check, Colore);
            }
            else if (Colore == "Verde")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnHome.Image = Resources.HomeNero;
                bool check = false;
                ColoreAppNoLogo(check, Colore);
            }
            else if (Colore == "Blu")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.ospite;
                }
                BtnHome.Image = Resources.home;
                bool check = true;
                ColoreAppNoLogo(check, Colore);
            }
            else if (Colore == "Dark Mode")
            {
                if (Logo)
                {
                    PcbLogo.Image = Resources.OspiteNero;
                }
                BtnHome.Image = Resources.HomeDarkMode;
                bool check = false;
                ColoreAppNoLogo(check, Colore);
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
        private void ColoreAppNoLogo(bool check, string Colore)
        {
            // carica logo username
            if (check)
            {
                ColoreApp = Resources.App;
            }
            else
            {
                ColoreApp = Resources.appNero;
            }
            // carica icona dei btnApp in base al colore
            if (Variabili.Pass >= 1) 
            {
                if (Colore == "Arancione")
                {
                    BtnApp1.Image = ColoreApp;
                    BtnApp2.Image = ColoreApp;
                    BtnApp3.Image = ColoreApp;
                    BtnApp4.Image = ColoreApp;
                    BtnApp5.Image = ColoreApp;
                    BtnApp6.Image = ColoreApp;
                    BtnApp7.Image = ColoreApp;
                    BtnApp8.Image = ColoreApp;
                    BtnApp9.Image = ColoreApp;
                    BtnApp10.Image = ColoreApp;
                    BtnApp11.Image = ColoreApp;
                    BtnApp12.Image = ColoreApp;
                }
                else if (Colore == "Verde")
                {
                    BtnApp1.Image = ColoreApp;
                    BtnApp2.Image = ColoreApp;
                    BtnApp3.Image = ColoreApp;
                    BtnApp4.Image = ColoreApp;
                    BtnApp5.Image = ColoreApp;
                    BtnApp6.Image = ColoreApp;
                    BtnApp7.Image = ColoreApp;
                    BtnApp8.Image = ColoreApp;
                    BtnApp9.Image = ColoreApp;
                    BtnApp10.Image = ColoreApp;
                    BtnApp11.Image = ColoreApp;
                    BtnApp12.Image = ColoreApp;
                }
                else if (Colore == "Blu")
                {
                    BtnApp1.Image = ColoreApp;
                    BtnApp2.Image = ColoreApp;
                    BtnApp3.Image = ColoreApp;
                    BtnApp4.Image = ColoreApp;
                    BtnApp5.Image = ColoreApp;
                    BtnApp6.Image = ColoreApp;
                    BtnApp7.Image = ColoreApp;
                    BtnApp8.Image = ColoreApp;
                    BtnApp9.Image = ColoreApp;
                    BtnApp10.Image = ColoreApp;
                    BtnApp11.Image = ColoreApp;
                    BtnApp12.Image = ColoreApp;
                }
                else if (Colore == "Dark Mode")
                {
                    BtnApp1.Image = ColoreApp;
                    BtnApp2.Image = ColoreApp;
                    BtnApp3.Image = ColoreApp;
                    BtnApp4.Image = ColoreApp;
                    BtnApp5.Image = ColoreApp;
                    BtnApp6.Image = ColoreApp;
                    BtnApp7.Image = ColoreApp;
                    BtnApp8.Image = ColoreApp;
                    BtnApp9.Image = ColoreApp;
                    BtnApp10.Image = ColoreApp;
                    BtnApp11.Image = ColoreApp;
                    BtnApp12.Image = ColoreApp;
                }
                else
                {
                    MessageBox.Show($"Errore nella scelta del colore, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CaricaVarColoriSecondario()
        { // carica i colori appena tornato dal main e middleman quindi con possibile cambiamento di colori
            if (Variabili.Pass >= 2 || Variabili.FrmMiddleManSettings)
            {
                CaricaVariabiliColori();
            }
        }

        private void FrmApplicazioni_Activated(object sender, EventArgs e)
        {   
            OleDbConnection cn;
            OleDbCommand cmd;
            OleDbDataAdapter da;
            DataTable Tabella;
            string Connect, Query;


            Connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(Connect);
            cn.Open();

            //////////////////////////////////////////////////
            // carico tutta la tabella path sulla [Tabella] e prende numero di apps
            Query = "SELECT * " +
                    "FROM Path ";
            cmd = new OleDbCommand(Query, cn);
            da = new OleDbDataAdapter(cmd);
            Tabella = new DataTable();
            da.Fill(Tabella);
            Apps = Tabella.Rows.Count;
            CaricaVarColoriSecondario();
            ShowBtnNecessari();
            CaricaBtnApps(Query,cn,cmd,da,Tabella);
        }
    }
}

