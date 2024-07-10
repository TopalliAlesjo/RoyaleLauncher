using System.Drawing;

namespace RoyaleLauncher
{
    public class Variabili
    {
        public static bool FrmDatabasePassaggioBtnEsci { get; set; } = false; // apre il passaggio su FrmMain da FrmDatabase
        public static bool FrmAppsPassaggioBtnHome { get; set; } = false; // apre il passaggio su FrmMain da FrmApplicazioni
        public static bool FrmSettingsPassaggioEsci { get; set; } = false; // apre il passaggio su FrmMain da FrmSettingDatabase
        public static bool FrmPrimoStartToMain { get; set; } = false; // apre il passaggio su FrmMain da FrmPrimoStart

        public static FrmApplicazioni Form = new FrmApplicazioni(); // rende veloce il reindirizzamento su FrmApplicazioni
        public static bool AperturaDB { get; set; } = false;  // check se è stato aperto FrmDatabase per FrmApplicazioni
        public static bool FrmUsernamePERapps { get; set; } = false; // check se è stato aperto FrmSettingDatabase per FrmApplicazioni
        public static int Pass { get; set; } = 0; // contatore giri in FrmMain
        public static int Pass2 { get; set; } = 0; // contatore giri in FrmApplicazioni
        public static bool FrmAppsPassaggioMainDatabase { get; set; } = false; // check se è stato aperto FrmMain da FrmDatabase e passa dinuovo per FrmApplicazioni quindi refresha i btn
        public static bool FrmMiddleManSettings { get; set; } = false; // check se è stato chiuso FrmMiddleMan per FrmApplicazioni

        // VARIABILE COLORI
        public static Color Online { get; set; }
        public static Color PnlSX { get; set; }
        public static Color PnlDX { get; set; }
        public static Color Scritte { get; set; }
        public static Color RdbCheckControl { get; set; }
        public static Color RdbUnCheckControl { get; set; }
        public static Color BtnAttivo { get; set; }
        public static Color BtnDisattivo { get; set; }





    }
}
