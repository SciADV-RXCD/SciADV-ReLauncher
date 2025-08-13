using SciADV_ReLauncher.Forms;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SciADV_ReLauncher
{
    internal static class Program
    {
        [DllImport("kernel32.dll")] static extern bool AllocConsole();
        [DllImport("kernel32.dll")] static extern bool AttachConsole(int pw);

        public static bool _hasConsole, _keepConsoleOpen;
        static public void EnsureConsole()
        {
            _hasConsole = _hasConsole || AttachConsole(-1);
            _keepConsoleOpen = !_hasConsole || _keepConsoleOpen;
            _hasConsole = _hasConsole || AllocConsole();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        internal static string[] Args;
        [STAThread]
        static void Main(string[] args)
        {
            if (Directory.Exists("Config") == false)
            {
                Directory.CreateDirectory("Config");
            }
            if (Directory.Exists("Tools") == false)
            {
                Directory.CreateDirectory("Tools");
                //Directory.CreateDirectory("Tools\\TextReader");
                //Directory.CreateDirectory("Tools\\VideoPlayer");
                Directory.CreateDirectory("Tools\\LocaleEmulator");
            }

            if (File.Exists("Config\\quotes.txt"))
            {
                File.Delete("Config\\quotes.txt");
            }
            File.Move("quotes.txt", "Config\\quotes.txt");

            Args = args;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var splash = new SplashScreen();
            splash.Show();

            // I call DoEvents here to make sure that the splash-screen is properly shown.
            Application.DoEvents();

            // Just a sleep to mimick your load or init procedure
            Thread.Sleep(2000);

            splash.Close();
            DebugModeEnabler();

            [ConditionalAttribute("DEBUG")]
            static void DebugModeEnabler()
            {
                MessageBox.Show("Debug mode enabled.", "Debug Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnsureConsole();

                if (_keepConsoleOpen)
                {
                    Console.WriteLine("##################################");
                    Console.WriteLine("#####   SciADV  ReLauncher   #####");
                    Console.WriteLine("#####   DEBUG MODE ENABLED   #####");
                    Console.WriteLine("##################################");
                    SendKeys.SendWait("{ENTER}");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("##################################");
                    Console.WriteLine("#####   SciADV  ReLauncher   #####");
                    Console.WriteLine("#####   DEBUG MODE ENABLED   #####");
                    Console.WriteLine("##################################");
                    SendKeys.SendWait("{ENTER}");
                    Console.Read();
                }
            }
            Application.Run(new FormMain());
        }
    }
}