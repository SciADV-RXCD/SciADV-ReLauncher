using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyINIController;

//using static SciADV_ReLauncher.ClassJSONConfig;

namespace SciADV_ReLauncher.Forms
{
    public partial class FormMainConfig : Form
    {
        public FormMainConfig()
        {
            InitializeComponent();
            
        }

        private void FormMainConfig_Load(object sender, EventArgs e)
        {
            if (File.Exists("Config\\mainSettings.ini") == true)
            {
                IniFile mainSettings = new IniFile("Config\\mainSettings.ini");

                if (mainSettings.KeyExists("CHNgame", "general") == true)
                {
                    textBox1.Text = mainSettings.Read("CHNgame", "general");
                }

                if (mainSettings.KeyExists("SGgame", "general") == true)
                {
                    textBox2.Text = mainSettings.Read("SGgame", "general");
                }

                if (mainSettings.KeyExists("RNEgame", "general") == true)
                {
                    textBox3.Text = mainSettings.Read("RNEgame", "general");
                }

                if (mainSettings.KeyExists("CCgame", "general") == true)
                {
                    textBox4.Text = mainSettings.Read("CCgame", "general");
                }

                if (mainSettings.KeyExists("SG0game", "general") == true)
                {
                    textBox5.Text = mainSettings.Read("SG0game", "general");
                }

                if (mainSettings.KeyExists("RNDgame", "general") == true)
                {
                    textBox6.Text = mainSettings.Read("RNDgame", "general");
                }

                if (mainSettings.KeyExists("OCanime", "general") == true)
                {
                    textBox7.Text = mainSettings.Read("OCanime", "general");
                }

                if (mainSettings.KeyExists("ACgame", "general") == true)
                {
                    textBox8.Text = mainSettings.Read("ACgame", "general");
                }
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            IniFile mainSettings = new IniFile("Config\\mainSettings.ini");
            //CHAOS;HEAD NOAH
            FolderBrowserDialog CHNMainGame = new FolderBrowserDialog();
            if (CHNMainGame.ShowDialog() == DialogResult.OK)
            {
                //Check if the Selected Folder has the right name AND the executable, making it only possible to selected the game's root folder
                if (CHNMainGame.SelectedPath.Contains("CHAOS;HEAD NOAH") && File.Exists($@"{CHNMainGame.SelectedPath}\\Game_Steam.exe"))
                {
                    textBox1.Text = CHNMainGame.SelectedPath;
                    mainSettings.Write("CHNgame", CHNMainGame.SelectedPath, "general");
                    Console.WriteLine(mainSettings.Read("CHNgame", "general"));
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder named \"CHAOS;HEAD NOAH\" from your SteamLibrary Folder.");
                    mainSettings.Write("CHNgame", "NONE", "general");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //STEINS;GATE
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ROBOTICS;NOTES ELITE
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CHAOS;CHILD
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //STEINS;GATE 0
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ROBOTICS;NOTES DaSH
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //OCCULTIC;NINE
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //ANONYMOUS;CODE
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SAVE CONFIGURATION
            //NOT NEEDED FOR NOW???
            button1.Enabled = false;
            button1.Visible = false;
        }
    }
}
