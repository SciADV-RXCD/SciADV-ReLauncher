using SciADV_ReLauncher.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using TinyINIController;

namespace SciADV_ReLauncher
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        //Common Strings
        string LocaleEmulatorToolPath = "Tools\\LocaleEmulator\\LEProc.exe";

        //Currently unused, but kept for alternative use
        string VideoPlayerToolPath = "Tools\\VideoPlayer\\mpv.exe";
        string TextReaderToolPath = "Tools\\TextReader\\nw.exe";

        private void FormMain_Load(object sender, EventArgs e)
        {
            DebugModeEnablerPart2ANDRandomQuotesTitle();
            RandomQuotesTitle();

            ReadConfigFile();

            if (File.Exists(LocaleEmulatorToolPath) == false)
            {
                MessageBox.Show("Locale Emulator is missing!\nPlease let the Launcher Download and configure it!");
                FormToolDownloader ToolDownloader = new FormToolDownloader();
                ToolDownloader.ShowDialog();
            }
        }



        /// <summary>
        /// DIFFERENT CODE BLOCKS DEPENDING ON THE BUILD CONFIGURATION!!!!!
        /// </summary>

        [ConditionalAttribute("DEBUG")]
        public void DebugModeEnablerPart2ANDRandomQuotesTitle()
        {
            if (GetConsoleWindow() != IntPtr.Zero)
            {
                string[] quotes = File.ReadAllLines("Config\\quotes.txt");

                Random rndQuotes = new Random();

                int randomQuotes = rndQuotes.Next(quotes.Length);

                this.Text = "[D] SciADV ReLauncher - " + quotes[randomQuotes];

                this.Refresh();
                Console.WriteLine("F I S H");
                Console.Title = "[DEBUG] SciADV ReLauncher";
            }
        }

        [ConditionalAttribute("RELEASE")]
        public void RandomQuotesTitle()
        {
            string[] quotes = File.ReadAllLines("Config\\quotes.txt");

            Random rndQuotes = new Random();

            int randomQuotes = rndQuotes.Next(quotes.Length);

            this.Text = "SciADV-ReLauncher - " + quotes[randomQuotes];
        }

        [ConditionalAttribute("DEBUG")]
        public void DebugMenu()
        {
            FormDebugMenu debugMenu = new FormDebugMenu();
            debugMenu.Show();
        }

        [ConditionalAttribute("RELEASE")]
        public void EasterEgg()
        {
            MessageBox.Show("El Psy Kongroo!");
        }

        /// <summary>
        /// DIFFERENT CODE BLOCKS DEPENDING ON THE BUILD CONFIGURATION!!!!!
        /// </summary>




        public void ReadConfigFile()
        {
            if (File.Exists("Config\\mainSettings.ini"))
            {
                IniFile mainSettings = new IniFile("Config\\mainSettings.ini");

                CHNmainGamePath = mainSettings.Read("CHNgame", "general");
                SGmainGamePath = mainSettings.Read("SGgame", "general");
                RNEmainGamePath = mainSettings.Read("RNEgame", "general");
                CCmainGamePath = mainSettings.Read("CCgame", "general");
                SG0mainGamePath = mainSettings.Read("SG0game", "general");
                RNDmainGamePath = mainSettings.Read("RNDgame", "general");
                OCanimePath = mainSettings.Read("OCanime", "general");
                ACmainGamePath = mainSettings.Read("ACgame", "general");
            }
            else if (File.Exists("Config\\mainSettings.ini") == false) 
            {
                File.Create("Config\\mainSettings.ini").Close();
                IniFile mainSettings = new IniFile("Config\\mainSettings.ini");
                mainSettings.Write("CHNgame", "NONE", "general");
                mainSettings.Write("SGgame", "NONE", "general");
                mainSettings.Write("RNEgame", "NONE", "general");
                mainSettings.Write("CCgame", "NONE", "general");
                mainSettings.Write("SG0game", "NONE", "general");
                mainSettings.Write("RNDgame", "NONE", "general");
                mainSettings.Write("OCanime", "NONE", "general");
                mainSettings.Write("ACgame", "NONE", "general");
            }
        }

        public static string CHNmainGamePath;
        public static string SGmainGamePath;
        public static string RNEmainGamePath;
        public static string CCmainGamePath;
        public static string SG0mainGamePath;
        public static string RNDmainGamePath;
        public static string OCanimePath;
        public static string ACmainGamePath;

        private void button1_Click(object sender, EventArgs e)
        {
            //CHAOS;HEAD
            IniFile mainSettings = new IniFile("Config\\mainSettings.ini");

            Process CHNmainGame = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{CHNmainGamePath}\\Game_Steam.exe",
                }
            };

            Directory.SetCurrentDirectory($@"{CHNmainGamePath}");
            CHNmainGame.Start();
            Console.WriteLine("\nCHAOS;HEAD NoAH Launched!");
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CHAOS;HEAD Side Entries
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //STEINS;GATE
            IniFile mainSettings = new IniFile("Config\\mainSettings.ini");

            Process SGmainGame = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{SGmainGamePath}\\LauncherC0.exe",
                }
            };

            //Directory.SetCurrentDirectory(AppContext.BaseDirectory);

            Directory.SetCurrentDirectory($@"{SGmainGamePath}");
            SGmainGame.Start();
            Console.WriteLine("\nSTEINS;GATE Launched!");
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //STEINS;GATE Side Entries
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ROBOTICS;NOTES
            IniFile mainSettings = new IniFile("Config\\mainSettings.ini");

            Process RNEmainGame = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{RNEmainGamePath}\\LauncherC0.exe",
                }
            };

            Directory.SetCurrentDirectory($@"{RNEmainGamePath}");
            RNEmainGame.Start();
            Console.WriteLine("\nROBOTICS;NOTES ELITE Launched!");
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //RBOTICS;NOTES Side Entries
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //CHAOS;CHILD
            IniFile mainSettings = new IniFile("Config\\mainSettings.ini");

            Process CCmainGame = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{CCmainGamePath}\\LauncherC0.exe",
                }
            };

            Directory.SetCurrentDirectory($@"{CCmainGamePath}");
            CCmainGame.Start();
            Console.WriteLine("\nCHAOS;CHILD Launched!");
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //CHAOS;CHILD Side Entries
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //STEINS;GATE 0
            IniFile mainSettings = new IniFile("Config\\mainSettings.ini");
            Process SG0mainGame = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{SG0mainGamePath}\\LauncherC0.exe",
                }
            };

            Directory.SetCurrentDirectory($@"{SG0mainGamePath}");
            SG0mainGame.Start();
            Console.WriteLine("\nSTEINS;GATE 0 Launched!");
            this.WindowState = FormWindowState.Minimized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //STEINS;GATE 0 Side Entries
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //ROBOTICS;NOTES DaSH
            IniFile mainSettings = new IniFile("Config\\mainSettings.ini");
            Process RNDmainGame = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{RNDmainGamePath}\\LauncherC0.exe",
                }
            };

            Directory.SetCurrentDirectory($@"{RNDmainGamePath}");
            RNDmainGame.Start();
            Console.WriteLine("\nROBOTICS;NOTES DaSH Launched!");
            this.WindowState = FormWindowState.Minimized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //ROBOTICS;NOTES DaSH Side Entries
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //OCCULTIC;NINE
            OcculticNineEpisodeSelector OCepisodeSelector = new OcculticNineEpisodeSelector();
            OcculticNineEpisodeSelector.OCanimePath = OCanimePath;
            OCepisodeSelector.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //ANONYMOUS;CODE
            IniFile mainSettings = new IniFile("Config\\mainSettings.ini");
            Process ACmainGame = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{ACmainGamePath}\\MAGESgamelauncher.exe",
                }
            };
            Directory.SetCurrentDirectory($@"{ACmainGamePath}");
            ACmainGame.Start();
            Console.WriteLine("\nANONYMOUS;CODE Launched!");
            this.WindowState = FormWindowState.Minimized;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //ANONYMOUS;CODE Side Entries
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //If Debug Mode
            DebugMenu();

            //If Release Mode
            EasterEgg();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FormMainConfig mainConfig = new FormMainConfig();
            mainConfig.ShowDialog();
        }
    }
}
