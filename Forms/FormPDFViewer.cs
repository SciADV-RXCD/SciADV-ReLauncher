using LibVLCSharp.Shared;
using Patagames.Pdf.Net;
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
    public partial class FormPDFViewer : Form
    {
        public FormPDFViewer()
        {
            InitializeComponent();
            FormClosed += FormPDFViewer_FormClosed;
        }

        private void FormPDFViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            pdfViewer1.Dispose();
            // Optionally, you can also dispose of any other resources if needed
        }

        public static string PDFfilepathFinal;

        private void FormPDFViewer_Load(object sender, EventArgs e)
        {
            pdfViewer1.LoadDocument(PDFfilepathFinal);
            pdfViewer1.PageAutoDispose = true; // Automatically dispose of pages when they are not visible
        }

        private void pdfToolStripPages1_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void pdfViewer1_CurrentPageChanged(object sender, EventArgs e)
        {
            pdfViewer1.VerticalScroll.Value = 0; // Reset vertical scroll position to the top
        }
    }
}
