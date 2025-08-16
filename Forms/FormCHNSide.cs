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
            if (File.Exists(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini"))
            {
                IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

                FormMain.CHNmainGamePath = mainSettings.Read("CHNgame", "general");
                FormMain.SGmainGamePath = mainSettings.Read("SGgame", "general");
                FormMain.RNEmainGamePath = mainSettings.Read("RNEgame", "general");
                FormMain.CCmainGamePath = mainSettings.Read("CCgame", "general");
                FormMain.SG0mainGamePath = mainSettings.Read("SG0game", "general");
                FormMain.RNDmainGamePath = mainSettings.Read("RNDgame", "general");
                FormMain.OCanimePath = mainSettings.Read("OCanime", "general");
                FormMain.ACmainGamePath = mainSettings.Read("ACgame", "general");

                FormCHNSide.ChaosGatePath = mainSettings.Read("ChaosGate", "CHNSideEntries");
                FormCHNSide.ChaosChatPath = mainSettings.Read("ChaosChat", "CHNSideEntries");
                FormCHNSide.CHLoveChuChuPath = mainSettings.Read("CHLoveChuChu", "CHNSideEntries");
            }
            else if (File.Exists(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini") == false)
            {
                File.Create(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini").Close();
                IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");
                mainSettings.Write("CHNgame", "NONE", "general");
                mainSettings.Write("SGgame", "NONE", "general");
                mainSettings.Write("RNEgame", "NONE", "general");
                mainSettings.Write("CCgame", "NONE", "general");
                mainSettings.Write("SG0game", "NONE", "general");
                mainSettings.Write("RNDgame", "NONE", "general");
                mainSettings.Write("OCanime", "NONE", "general");
                mainSettings.Write("ACgame", "NONE", "general");

                //CHN SIDE ENTRIES
                mainSettings.Write("ChaosGate", "NONE", "CHNSideEntries");
                mainSettings.Write("ChaosChat", "NONE", "CHNSideEntries");
                mainSettings.Write("CHLoveChuChu", "NONE", "CHNSideEntries");
            }
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
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            Process CHLoveChuChuGame = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{CHLoveChuChuPath}\\impacto.exe",
                    Arguments = "chlcc",
                    WorkingDirectory = CHLoveChuChuPath,
                }
            };

            //ReadConfigFile();
            //Directory.SetCurrentDirectory($@"{CHLoveChuChuPath}");
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
