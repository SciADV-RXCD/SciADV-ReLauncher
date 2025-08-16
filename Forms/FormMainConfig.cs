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

namespace SciADV_ReLauncher.Forms
{
    public partial class FormMainConfig : Form
    {
        public FormMainConfig()
        {
            InitializeComponent();
        }

        Functions useFunctions = new Functions();

        private void FormMainConfig_Load(object sender, EventArgs e)
        {
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            textBox1.Text = mainSettings.Read("CHNgame", "general");
            textBox2.Text = mainSettings.Read("SGgame", "general");
            textBox3.Text = mainSettings.Read("RNEgame", "general");
            textBox4.Text = mainSettings.Read("CCgame", "general");
            textBox5.Text = mainSettings.Read("SG0game", "general");
            textBox6.Text = mainSettings.Read("RNDgame", "general");
            textBox7.Text = mainSettings.Read("OCanime", "general");
            textBox8.Text = mainSettings.Read("ACgame", "general");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            //CHAOS;HEAD NOAH

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");
            
            FolderBrowserDialog CHNMainGame = new FolderBrowserDialog();
            if (CHNMainGame.ShowDialog() == DialogResult.OK)
            {
                //Check if the Selected Folder has the right name AND the executable, making it only possible to selected the game's root folder
                if (CHNMainGame.SelectedPath.Contains("CHAOS;HEAD NOAH") && File.Exists($@"{CHNMainGame.SelectedPath}\\Game_Steam.exe"))
                {
                    textBox1.Text = CHNMainGame.SelectedPath;
                    mainSettings.Write("CHNgame", CHNMainGame.SelectedPath, "general");
                    Console.WriteLine(mainSettings.Read("CHNgame", "general"));
                    useFunctions.ReadConfigFile();
                    Console.WriteLine("CHAOS;HEAD NOAH Saved and Config Reloaded!");
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

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FolderBrowserDialog SGMainGame = new FolderBrowserDialog();
            if (SGMainGame.ShowDialog() == DialogResult.OK)
            {
                //Check if the Selected Folder has the right name AND the executable, making it only possible to selected the game's root folder
                if (SGMainGame.SelectedPath.Contains("STEINS;GATE") && File.Exists($@"{SGMainGame.SelectedPath}\\LauncherC0.exe"))
                {
                    textBox2.Text = SGMainGame.SelectedPath;
                    mainSettings.Write("SGgame", SGMainGame.SelectedPath, "general");
                    Console.WriteLine(mainSettings.Read("SGgame", "general"));
                    useFunctions.ReadConfigFile();
                    Console.WriteLine("STEINS;GATE Saved and Config Reloaded!");
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder named \"STEINS;GATE\" from your SteamLibrary Folder.");
                    mainSettings.Write("SGgame", "NONE", "general");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ROBOTICS;NOTES ELITE

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FolderBrowserDialog RNEMainGame = new FolderBrowserDialog();
            if (RNEMainGame.ShowDialog() == DialogResult.OK)
            {
                if (RNEMainGame.SelectedPath.Contains("ROBOTICS;NOTES ELITE") && File.Exists($@"{RNEMainGame.SelectedPath}\\LauncherC0.exe"))
                {
                    textBox3.Text = RNEMainGame.SelectedPath;
                    mainSettings.Write("RNEgame", RNEMainGame.SelectedPath, "general");
                    Console.WriteLine(mainSettings.Read("RNEgame", "general"));
                    useFunctions.ReadConfigFile();
                    Console.WriteLine("ROBOTICS;NOTES ELITE Saved and Config Reloaded!");
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder named \"ROBOTICS;NOTES ELITE\" from your SteamLibrary Folder.");
                    mainSettings.Write("RNEgame", "NONE", "general");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CHAOS;CHILD
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");
            FolderBrowserDialog CCMainGame = new FolderBrowserDialog();
            if (CCMainGame.ShowDialog() == DialogResult.OK)
            {
                //Check if the Selected Folder has the right name AND the executable, making it only possible to selected the game's root folder
                if (CCMainGame.SelectedPath.Contains("CHAOS;CHILD") && File.Exists($@"{CCMainGame.SelectedPath}\\LauncherC0.exe"))
                {
                    textBox4.Text = CCMainGame.SelectedPath;
                    mainSettings.Write("CCgame", CCMainGame.SelectedPath, "general");
                    Console.WriteLine(mainSettings.Read("CCgame", "general"));
                    useFunctions.ReadConfigFile();
                    Console.WriteLine("CHAOS;CHILD Saved and Config Reloaded!");
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder named \"CHAOS;CHILD\" from your SteamLibrary Folder.");
                    mainSettings.Write("CCgame", "NONE", "general");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //STEINS;GATE 0
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");
            FolderBrowserDialog SG0MainGame = new FolderBrowserDialog();
            if (SG0MainGame.ShowDialog() == DialogResult.OK)
            {
                //Check if the Selected Folder has the right name AND the executable, making it only possible to selected the game's root folder
                if (SG0MainGame.SelectedPath.Contains("STEINS;GATE 0") && File.Exists($@"{SG0MainGame.SelectedPath}\\LauncherC0.exe"))
                {
                    textBox5.Text = SG0MainGame.SelectedPath;
                    mainSettings.Write("SG0game", SG0MainGame.SelectedPath, "general");
                    Console.WriteLine(mainSettings.Read("SG0game", "general"));
                    useFunctions.ReadConfigFile();
                    Console.WriteLine("STEINS;GATE 0 Saved and Config Reloaded!");
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder named \"STEINS;GATE 0\" from your SteamLibrary Folder.");
                    mainSettings.Write("SG0game", "NONE", "general");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ROBOTICS;NOTES DaSH
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");
            FolderBrowserDialog RNDMainGame = new FolderBrowserDialog();
            if (RNDMainGame.ShowDialog() == DialogResult.OK)
            {
                //Check if the Selected Folder has the right name AND the executable, making it only possible to selected the game's root folder
                if (RNDMainGame.SelectedPath.Contains("ROBOTICS;NOTES DaSH") && File.Exists($@"{RNDMainGame.SelectedPath}\\LauncherC0.exe"))
                {
                    textBox6.Text = RNDMainGame.SelectedPath;
                    mainSettings.Write("RNDgame", RNDMainGame.SelectedPath, "general");
                    Console.WriteLine(mainSettings.Read("RNDgame", "general"));
                    useFunctions.ReadConfigFile();
                    Console.WriteLine("ROBOTICS;NOTES DaSH Saved and Config Reloaded!");
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder named \"ROBOTICS;NOTES DaSH\" from your SteamLibrary Folder.");
                    mainSettings.Write("RNDgame", "NONE", "general");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //OCCULTIC;NINE
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");
            FolderBrowserDialog OCmainAnime = new FolderBrowserDialog();
            if (OCmainAnime.ShowDialog() == DialogResult.OK)
            {
                //Check if the Selected Folder has the right name AND the executable, making it only possible to selected the game's root folder
                if (OCmainAnime.SelectedPath.Contains("OCCULTIC;NINE") && File.Exists($@"{OCmainAnime.SelectedPath}\\Episode 01.mkv"))
                {
                    textBox7.Text = OCmainAnime.SelectedPath;
                    mainSettings.Write("OCanime", OCmainAnime.SelectedPath, "general");
                    Console.WriteLine(mainSettings.Read("OCanime", "general"));
                    useFunctions.ReadConfigFile();
                    Console.WriteLine("OCCULTIC;NINE Saved and Config Reloaded!");
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder named \"OCCULTIC;NINE\" containing all 12 Episodes\nstarting with \"Episode 01.mkv\".");
                    mainSettings.Write("OCanime", "NONE", "general");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //ANONYMOUS;CODE
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");
            FolderBrowserDialog ACMainGame = new FolderBrowserDialog();
            if (ACMainGame.ShowDialog() == DialogResult.OK)
            {
                //Check if the Selected Folder has the right name AND the executable, making it only possible to selected the game's root folder
                if (ACMainGame.SelectedPath.Contains("AC") && File.Exists($@"{ACMainGame.SelectedPath}\\MAGESgamelauncher.exe"))
                {
                    textBox8.Text = ACMainGame.SelectedPath;
                    mainSettings.Write("ACgame", ACMainGame.SelectedPath, "general");
                    Console.WriteLine(mainSettings.Read("ACgame", "general"));
                    useFunctions.ReadConfigFile();
                    Console.WriteLine("ANONYMOUS;CODE Saved and Config Reloaded!");
                }
                else
                {
                    MessageBox.Show("The selected Directory is invalid, please select the Folder named \"AC\" from your SteamLibrary Folder.");
                    mainSettings.Write("ACgame", "NONE", "general");
                }
            }
        }
    }
}
