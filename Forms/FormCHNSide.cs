using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyINIController;

namespace SciADV_ReLauncher.Forms
{
    public partial class FormCHNSide : Form
    {
        public FormCHNSide()
        {
            InitializeComponent();
        }

        private void FormCHNSide_Load(object sender, EventArgs e)
        {
            ReadConfigFile();
        }

        public static string ChaosGatePath;
        public static string ChaosChatPath;
        public static string CHLoveChuChuPath;

        public void ReadConfigFile()
        {
            IniFile mainSettings = new IniFile("Config\\mainSettings.ini");

            ChaosGatePath = mainSettings.Read("ChaosGate", "CHNSideEntries");
            ChaosChatPath = mainSettings.Read("ChaosChat", "CHNSideEntries");
            CHLoveChuChuPath = mainSettings.Read("CHLoveChuChu", "CHNSideEntries");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCHNSideConfig CHNSideConfig = new FormCHNSideConfig();
            CHNSideConfig.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CHAOS;GATE
            FormPDFViewer CHAOSGATEViewer = new FormPDFViewer();
            FormPDFViewer.PDFfilepathFinal = ChaosGatePath;
            CHAOSGATEViewer.Show();
            Console.WriteLine("\nCHAOS;GATE Launched!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CHAOS;HEAD Love ChuChu
            IniFile mainSettings = new IniFile("Config\\mainSettings.ini");

            Process CHLoveChuChuGame = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{CHLoveChuChuPath}\\impacto.exe",
                }
            };

            Directory.SetCurrentDirectory($@"{CHLoveChuChuPath}");
            CHLoveChuChuGame.Start();
            Console.WriteLine("\nCHAOS;HEAD Love Chu☆Chu! Launched!");
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CHAOS;CHAT
            FormPDFViewer CHAOSCHATViewer = new FormPDFViewer();
            FormPDFViewer.PDFfilepathFinal = ChaosChatPath;
            CHAOSCHATViewer.Show();
            Console.WriteLine("\nCHAOS;CHAT Launched!");
        }
    }
}
