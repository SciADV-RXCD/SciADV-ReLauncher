namespace SciADV_ReLauncher.Forms
{
    partial class FormToolDownloader
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
            label1 = new Label();
            progressBar2 = new ProgressBar();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(233, 33);
            label1.TabIndex = 10;
            label1.Text = "Completed!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Visible = false;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 90);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(233, 23);
            progressBar2.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(12, 42);
            button2.Name = "button2";
            button2.Size = new Size(233, 42);
            button2.TabIndex = 8;
            button2.Text = "Download";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(233, 30);
            label2.TabIndex = 7;
            label2.Text = "Locale Emulator";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(301, 116);
            label3.Name = "label3";
            label3.Size = new Size(233, 33);
            label3.TabIndex = 14;
            label3.Text = "Completed!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(301, 90);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(233, 23);
            progressBar1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(301, 42);
            button1.Name = "button1";
            button1.Size = new Size(233, 42);
            button1.TabIndex = 12;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(301, 9);
            label4.Name = "label4";
            label4.Size = new Size(233, 30);
            label4.TabIndex = 11;
            label4.Text = "Text Reader";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormToolDownloader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 158);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(progressBar2);
            Controls.Add(button2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormToolDownloader";
            ShowIcon = false;
            Text = "Tool Downloader";
            Load += FormToolDownloader_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ProgressBar progressBar2;
        private Button button2;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private Button button1;
        private Label label4;
    }
}