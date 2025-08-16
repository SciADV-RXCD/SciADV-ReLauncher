using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyINIController;

namespace SciADV_ReLauncher.Forms
{
    public partial class FormCHNSideConfig : Form
    {
        public FormCHNSideConfig()
        {
            InitializeComponent();
        }

        private void FormCHNSideConfig_Load(object sender, EventArgs e)
        {
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            textBox1.Text = mainSettings.Read("ChaosGate", "CHNSideEntries");
            textBox2.Text = mainSettings.Read("CHLoveChuChu", "CHNSideEntries");
            textBox3.Text = mainSettings.Read("ChaosChat", "CHNSideEntries");
        }

        public void ReadConfigFile()
        {
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormCHNSide.ChaosGatePath = mainSettings.Read("ChaosGate", "CHNSideEntries");
            FormCHNSide.ChaosChatPath = mainSettings.Read("ChaosChat", "CHNSideEntries");
            FormCHNSide.CHLoveChuChuPath = mainSettings.Read("CHLoveChuChu", "CHNSideEntries");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CHAOS;GATE
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            OpenFileDialog chaosGatePDF = new OpenFileDialog
            {
                Title = "Select CHAOS;GATE PDF",
                Filter = "PDF Files (*.pdf)|*.pdf",
                FilterIndex = 1,
                Multiselect = false
            };
            if (chaosGatePDF.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = chaosGatePDF.FileName;
                mainSettings.Write("ChaosGate", chaosGatePDF.FileName, "CHNSideEntries");
                Console.WriteLine(mainSettings.Read("ChaosGate", "CHNSideEntries"));
                ReadConfigFile();
                Console.WriteLine("CHAOS;GATE Saved and Config Reloaded!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CHAOS;HEAD Love ChuChu
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FolderBrowserDialog CHLoveChuChuGame = new FolderBrowserDialog();
            if (CHLoveChuChuGame.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists($@"{CHLoveChuChuGame.SelectedPath}\\impacto.exe"))
                {
                    textBox2.Text = CHLoveChuChuGame.SelectedPath;
                    mainSettings.Write("CHLoveChuChu", CHLoveChuChuGame.SelectedPath, "CHNSideEntries");
                    Console.WriteLine(mainSettings.Read("CHLoveChuChu", "CHNSideEntries"));
                    ReadConfigFile();
                    Console.WriteLine("CHAOS;HEAD Love Chu☆Chu! Saved and Config Reloaded!");
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder that contains the \"impacto.exe\".");
                    mainSettings.Write("CHLoveChuChu", "NONE", "CHNSideEntries");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CHAOS;CHAT
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            OpenFileDialog chaosChatPDF = new OpenFileDialog
            {
                Title = "Select CHAOS;CHAT PDF",
                Filter = "PDF Files (*.pdf)|*.pdf",
                FilterIndex = 1,
                Multiselect = false
            };
            if (chaosChatPDF.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = chaosChatPDF.FileName;
                mainSettings.Write("ChaosChat", chaosChatPDF.FileName, "CHNSideEntries");
                Console.WriteLine(mainSettings.Read("ChaosChat", "CHNSideEntries"));
                ReadConfigFile();
                Console.WriteLine("CHAOS;CHAT Saved and Config Reloaded!");
            }
        }
    }
}
