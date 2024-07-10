using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RoyaleLauncher
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OleDbConnection cn;
            string Connessione;
            try // check connessione del db
            {
                Connessione = $@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={Application.StartupPath}\Launcher.accdb";
                cn = new OleDbConnection(Connessione);
                cn.Open();
                cn.Close();
            }
            catch (OleDbException ex) when ((uint)ex.ErrorCode == 0x80004005) // errore per chi non ha i driver installati o per chi ha spostato l'app
            {
                MessageBox.Show($"Errore 0x80004005: si prega di verificare se il database (Launcher.accdb) sia nella cartella con l'applicazione. \n \n !!!SE IL PROBLEMA PERSISTE PERFAVORE CONTATTARE IL CREATORE!!!", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                string url = "https://www.microsoft.com/it-it/download/details.aspx?id=54920";
                Clipboard.SetText(url);
                MessageBox.Show($"Errore: {ex.Message} {Environment.NewLine} \n \n E' stato copiato nei appunti il link per il sito dei driver, accedi al tuo browser incollalo e installa i driver. \n \n  !!!SE IL PROBLEMA PERSISTE PERFAVORE CONTATTARE IL CREATORE!!!", "Status: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Application.Run(new FrmMain());
        }
    }
}
