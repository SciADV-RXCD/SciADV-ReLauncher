using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SciADV_ReLauncher.Forms
{
    public partial class FormToolDownloader : Form
    {
        public FormToolDownloader()
        {
            InitializeComponent();
        }

        private void FormToolDownloader_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Download a file using WebClient
            using (WebClient wc_locale = new WebClient())
            {
                wc_locale.DownloadProgressChanged += wc_locale_DownloadProgressChangedLocaleEmulator;
                wc_locale.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri("https://github.com/SciADV-RXCD/SciADV-ReLauncher/releases/download/0.0.0/LocaleEmulator.zip"),
                    // Param2 = Path to save
                    AppContext.BaseDirectory + "LocaleEmulator.zip"
                );
                wc_locale.DownloadFileCompleted += (s, ev) =>
                {
                    if (ev.Error != null)
                    {
                        MessageBox.Show("Error downloading file: " + ev.Error.Message);
                    }
                    else
                    {
                        // Optionally, you can extract the downloaded zip file here
                        System.IO.Compression.ZipFile.ExtractToDirectory(AppContext.BaseDirectory + "LocaleEmulator.zip", AppContext.BaseDirectory + "Tools\\LocaleEmulator");
                        System.IO.File.Delete(AppContext.BaseDirectory + "LocaleEmulator.zip"); // Delete the zip file after extraction
                        label1.Visible = true;
                        button2.Enabled = false;
                    }
                };
            }
        }
        // Event to track the progress
        void wc_locale_DownloadProgressChangedLocaleEmulator(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Download a file using WebClient
            using (WebClient wc_locale = new WebClient())
            {
                wc_locale.DownloadProgressChanged += wc_locale_DownloadProgressChangedTextReader;
                wc_locale.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri("https://github.com/SciADV-RXCD/SciADV-ReLauncher/releases/download/0.0.0/TextReader.zip"),
                    // Param2 = Path to save
                    AppContext.BaseDirectory + "TextReader.zip"
                );
                wc_locale.DownloadFileCompleted += (s, ev) =>
                {
                    if (ev.Error != null)
                    {
                        MessageBox.Show("Error downloading file: " + ev.Error.Message);
                    }
                    else
                    {
                        // Optionally, you can extract the downloaded zip file here
                        System.IO.Compression.ZipFile.ExtractToDirectory(AppContext.BaseDirectory + "TextReader.zip", AppContext.BaseDirectory + "Tools\\TextReader");
                        System.IO.File.Delete(AppContext.BaseDirectory + "TextReader.zip"); // Delete the zip file after extraction
                        label3.Visible = true;
                        button1.Enabled = false;
                    }
                };
            }
        }
        // Event to track the progress
        void wc_locale_DownloadProgressChangedTextReader(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
