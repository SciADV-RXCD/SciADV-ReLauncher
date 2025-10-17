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
    public partial class FormSGSide : Form
    {
        public FormSGSide()
        {
            InitializeComponent();
        }

        private void FormSGSide_Load(object sender, EventArgs e)
        {
            useFunctions.ReadConfigFile();
        }

        Functions useFunctions = new Functions();

        //13 Buttons btw - Babel of Grieved Maze wird zsm zu einem button

        public static string HolyDayOfTheCalamitousBirthPath;       //Novella - PDF
        public static string EgoisticPoriomaniaPath;                //Anime - MP4/MKV
        public static string LoadRegionOfDejaVuPath;                //Anime - MP4/MKV
        public static string AnAPosterioriExistencePath;            //Drama CD - MP4/MKV
        public static string SGVariantSpaceOctetPath;               //Game - EXE
        public static string SGMyDarlingsEmbracePath;               //Game - EXE
        public static string BabelOfTheGrievedMazeMangaPath;        //Manga - PDF
        public static string BabelOfTheGrievedMazeDramaCDPath;      //Drama CD - MP4/MKV
        public static string ArcLightOfThePointAtInfinityPath;      //Drama CD - MP4/MKV
        public static string HydeOfTheDarkDimensionPath;            //Drama CD - MP4/MKV
        public static string RebellionOfTheMissingRingPath;         //Manga - PDF
        public static string TheDistantValhallaPath;                //Novella - PDF
        public static string BraunianMotionOfLoveAndHatePath;       //Manga - PDF
        public static string OkabeRintaroBirthdaySpecialPath;       //Novella - PDF

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf"))
            {
                File.Copy(HolyDayOfTheCalamitousBirthPath, @$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf");
            }
            else
            {
                File.Delete(@$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf");
                File.Copy(HolyDayOfTheCalamitousBirthPath, @$"{AppContext.BaseDirectory}\\Tools\\TextReader\\main.pdf");
            }

            Process HolyDayOfTheCalamitousBirthPDF = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{AppContext.BaseDirectory}\\Tools\\TextReader\\nw.exe",
                    Arguments = "main.pdf",
                    WorkingDirectory = @$"{AppContext.BaseDirectory}\\Tools\\TextReader",
                }
            };
            HolyDayOfTheCalamitousBirthPDF.Start();

            Console.WriteLine("\nHoly Day of the Calamitous Birth Launched!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Single File Selection in FormSGSideConfig.cs
            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = EgoisticPoriomaniaPath;
            VideoPlayer.Show();
            Console.WriteLine("\nEgoistic Poriomania Launched!");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Single File Selection in FormSGSideConfig.cs
            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = LoadRegionOfDejaVuPath;
            VideoPlayer.Show();
            Console.WriteLine("\nLoad Region of Déjà Vu Launched!");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Single File Selection in FormSGSideConfig.cs
            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = AnAPosterioriExistencePath;
            VideoPlayer.Show();
            Console.WriteLine("\nAn A Posteriori Existence Launched!");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            Process SGVariantSpaceOctetGame = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = $@"{SGVariantSpaceOctetPath}\\sg8bit.exe",
                    WorkingDirectory = SGVariantSpaceOctetPath,
                }
            };
            SGVariantSpaceOctetGame.Start();

            Console.WriteLine("\nSTEINS;GATE: Variant Space Octet Launched!");
            this.Close();
        }
    }
}
