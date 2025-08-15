using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SciADV_ReLauncher.Forms
{
    public partial class FormVideoPlayer : Form
    {
        public LibVLC _libVLC;
        public MediaPlayer _mp;

        public FormVideoPlayer()
        {
            InitializeComponent();
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mp;
            FormClosed += FormVideoPlayer_FormClosed;
        }

        private void FormVideoPlayer_Load(object sender, EventArgs e)
        {

        }

        private void FormVideoPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mp.Stop();
            _mp.Dispose();
            _libVLC.Dispose();
        }

        public static string VideoFilepathFinal;

        private void button1_Click(object sender, EventArgs e)
        {
            var media = new Media(_libVLC, VideoFilepathFinal);
            _mp.Play(media);
            media.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_mp.IsPlaying)
            {
                _mp.Pause();
                button2.Text = "Continue";
            }
            else
            {
                _mp.Play();
                button2.Text = "Pause";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _mp.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Backwards
            _mp.Time -= 5000; // Subtracts 5 seconds from the current playback time
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Forwards 5sec
            _mp.Time += 5000; // Adds 5 seconds to the current playback time
        }
    }
}
