namespace SciADV_ReLauncher.Forms
{
    partial class FormVideoPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(12, 12);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(1240, 605);
            videoView1.TabIndex = 0;
            videoView1.Text = "videoView1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(12, 623);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(168, 623);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 2;
            button2.Text = "Pause";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.Location = new Point(324, 623);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 3;
            button3.Text = "Stop";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(1118, 624);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(134, 45);
            trackBar1.TabIndex = 4;
            trackBar1.Value = 70;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(480, 624);
            label1.Name = "label1";
            label1.Size = new Size(420, 45);
            label1.TabIndex = 5;
            label1.Text = "PRESS PLAY! <3";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.Location = new Point(906, 624);
            button4.Name = "button4";
            button4.Size = new Size(100, 46);
            button4.TabIndex = 6;
            button4.Text = "-5s";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button5.Location = new Point(1012, 624);
            button5.Name = "button5";
            button5.Size = new Size(100, 46);
            button5.TabIndex = 7;
            button5.Text = "+5s";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FormVideoPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(videoView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormVideoPlayer";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Video Player";
            Load += FormVideoPlayer_Load;
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TrackBar trackBar1;
        private Label label1;
        private Button button4;
        private Button button5;
    }
}