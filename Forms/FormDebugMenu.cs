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
    public partial class FormDebugMenu : Form
    {
        public FormDebugMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPDFViewer PDFViewer = new FormPDFViewer();
            FormPDFViewer.PDFfilepathFinal = @"C:\Users\RubyX_Coded\Documents\taxDeclaration2024.pdf";
            PDFViewer.ShowDialog();
        }
    }
}
