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
            useFunctions.ReadConfigFile();
        }

        public static string ChaosGatePath;
        public static string ChaosChatPath;
        public static string CHLoveChuChuPath;

        Functions useFunctions = new Functions();

        private void button1_Click(object sender, EventArgs e)
        {
            FormCHNSideConfig CHNSideConfig = new FormCHNSideConfig();
            CHNSideConfig.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CHAOS;GATE
            if (!File.Exists(@$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf"))
            {
                File.Copy(ChaosGatePath, @$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf");
            }
            else
            {
                File.Delete(@$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf");
                File.Copy(ChaosGatePath, @$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf");
            }

            Process ChaosGatePDF = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{AppContext.BaseDirectory}\\Tools\\TextReader\\nw.exe",
                    Arguments = "main.pdf",
                    WorkingDirectory = @$"{AppContext.BaseDirectory}\\Tools\\TextReader",
                }
            };
            ChaosGatePDF.Start();

            Console.WriteLine("\nCHAOS;GATE Launched!");
            this.Close();
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
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CHAOS;CHAT
            if (!File.Exists(@$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf"))
            {
                File.Copy(ChaosChatPath, @$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf");
            }
            else
            {
                File.Delete(@$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf");
                File.Copy(ChaosChatPath, @$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf");
            }

            Process ChaosChatPDF = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{AppContext.BaseDirectory}\\Tools\\TextReader\\nw.exe",
                    Arguments = "main.pdf",
                    WorkingDirectory = @$"{AppContext.BaseDirectory}\\Tools\\TextReader",
                }
            };
            ChaosChatPDF.Start();

            Console.WriteLine("\nCHAOS;CHAT Launched!");
            this.Close();
        }
    }
}
