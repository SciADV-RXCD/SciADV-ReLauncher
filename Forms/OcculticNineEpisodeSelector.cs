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
    public partial class OcculticNineEpisodeSelector : Form
    {
        public OcculticNineEpisodeSelector()
        {
            InitializeComponent();
        }

        private void FormVideoEpisodeSelector_Load(object sender, EventArgs e)
        {

        }
        
        public static string OCanimePath;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 01.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 02.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 03.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 04.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 05.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 06.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 07.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 08.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 09.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 10.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 11.mkv";
            VideoPlayer.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();

            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

            FormVideoPlayer VideoPlayer = new FormVideoPlayer();
            FormVideoPlayer.VideoFilepathFinal = $@"{mainSettings.Read("OCanime", "general")}\\Episode 12.mkv";
            VideoPlayer.ShowDialog();
        }
    }
}
