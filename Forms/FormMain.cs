using SciADV_ReLauncher.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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

        //Common Tool Paths
        string LocaleEmulatorToolPath = "Tools\\LocaleEmulator\\LEProc.exe";

        //Currently unused, but kept for alternative use
        string VideoPlayerToolPath = "Tools\\VideoPlayer\\mpv.exe";
        string TextReaderToolPath = "Tools\\TextReader\\nw.exe";

        private void FormMain_Load(object sender, EventArgs e)
        {
            DebugModeEnablerPart2ANDRandomQuotesTitle();
            RandomQuotesTitle();

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



        private void button1_Click(object sender, EventArgs e)
        {
            //CHAOS;HEAD
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CHAOS;HEAD Side Entries
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //STEINS;GATE
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //STEINS;GATE Side Entries
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ROBOTICS;NOTES
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //RBOTICS;NOTES Side Entries
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //CHAOS;CHILD
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //CHAOS;CHILD Side Entries
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //STEINS;GATE 0
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //STEINS;GATE 0 Side Entries
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //ROBOTICS;NOTES DaSH
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //ROBOTICS;NOTES DaSH Side Entries
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //OCCULTIC;NINE
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //ANONYMOUS;CODE
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
