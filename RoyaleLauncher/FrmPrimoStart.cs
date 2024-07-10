using System;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace RoyaleLauncher
{
    public partial class FrmPrimoStart : Form
    {
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

        public FrmPrimoStart()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void CkbLogoBase_CheckedChanged(object sender, EventArgs e)
        {
            // sceglie se vuole il logo base o meno
            if (CkbLogoBase.Checked)
            {
                BtnApriDialogoFileRgLogo.Enabled = false;
            }
            else
            {
                BtnApriDialogoFileRgLogo.Enabled = true;
            }
        }

        private void BtnApriDialogoFileRgLogo_Click(object sender, EventArgs e)
        {
            // apre l'exlorer da c:\\ e fa scegliere l'app desiderata
            OfdFileLogo.Title = "Seleziona File .png o .jpg";
            OfdFileLogo.InitialDirectory = "c:\\";
            OfdFileLogo.Filter = "Foto png (*.png)|*.png|Foto jpg (*.jpg)|*.jpg";
            OfdFileLogo.FilterIndex = 1;
            OfdFileLogo.RestoreDirectory = true;
            if (OfdFileLogo.ShowDialog() == DialogResult.OK) // se è andato a buonfine la scelta dell'app si inserisce nella txt
            {
                string path = OfdFileLogo.FileName;
                TxtFotoRegistra.Texts = path;
            }

        }

        private void BtnFine_Click(object sender, EventArgs e)
        {
            if (TxtNomeUtente.Texts.Length > 12) // controlla se non sono stati superati i caratteri massimi
            {
                MessageBox.Show("Errore hai superato il max dei 12 caratteri, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TxtNomeUtente.Texts.Trim() == "") // controlla che non sia un nome nullo
            {
                MessageBox.Show("Errore inserisci il tuo Username, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TxtFotoRegistra.Texts == "Seleziona File" && !CkbLogoBase.Checked) // controlla che il logo non sia nullo
            {
                MessageBox.Show("Errore seleziona il logo oppure il logo base, Se il problema persiste perfavore contattare il creatore", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OleDbConnection cn;
            OleDbCommand cmd;
            string connect, query;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();
            if (!CkbLogoBase.Checked) // se logo base non è checkato -->
            {
                // scrivo nome e path logo
                query = "UPDATE Utente " +
                    "SET Nome = @nome, Logo = @pathlogo " +
                    "WHERE ID = 1";
                cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("@nome", TxtNomeUtente.Texts);
                cmd.Parameters.AddWithValue("@pathlogo", TxtFotoRegistra.Texts);
                cmd.ExecuteNonQuery();
            }
            else
            {
                // scrivo solo nome 
                query = "UPDATE Utente " +
                    "SET Nome = @nome " +
                    "WHERE ID = 1";
                cmd = new OleDbCommand(query, cn);
                cmd.Parameters.AddWithValue("@nome", TxtNomeUtente.Texts);
                cmd.ExecuteNonQuery();
            }

            // cambio value della bool
            query = "UPDATE PrimoAccesso " +
                "SET Configurazione = True " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(query, cn);
            cmd.ExecuteNonQuery();
            cn.Close();

            Variabili.FrmPrimoStartToMain = true; // rendo vero il passaggio per il load del main
            this.Close();
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
        }

        private void BtnFaqModalitàOspite_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FAQ: la modalità ospite è utilizzata principalmente da chi non vuole immettere username e logo per usufruire del laucher, ma possono essere cambiati dai settings del launcher, una volta cambiati username e logo dai settings non si può tornare a quelli 'ospite'", "FAQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnModalitàOspite_Click(object sender, EventArgs e)
        {
            OleDbConnection cn;
            OleDbCommand cmd;
            string connect, query;

            connect = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
            cn = new OleDbConnection(connect);
            cn.Open();

            // cambio nome utente in ospite
            query = "UPDATE Utente " +
                "SET Nome = 'Ospite' " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(query, cn);
            cmd.ExecuteNonQuery();

            // cambio value della bool
            query = "UPDATE PrimoAccesso " +
                "SET Configurazione = True " +
                "WHERE ID = 1";
            cmd = new OleDbCommand(query, cn);
            cmd.ExecuteNonQuery();
            cn.Close();

            Variabili.FrmPrimoStartToMain = true; // rendo vero il passaggio per il load del main

            this.Close();
            FrmMain frmMain = new FrmMain();
            frmMain.Show();

        }

        private void PnlToolBar_MouseDown(object sender, MouseEventArgs e) // trascinare finestra
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}


