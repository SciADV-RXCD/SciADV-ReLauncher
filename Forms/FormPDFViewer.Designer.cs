namespace SciADV_ReLauncher.Forms
{
    partial class FormPDFViewer
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
            pdfViewer1 = new Patagames.Pdf.Net.Controls.WinForms.PdfViewer();
            pdfToolStripPages1 = new Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripPages();
            SuspendLayout();
            // 
            // pdfViewer1
            // 
            pdfViewer1.BackColor = SystemColors.ControlDark;
            pdfViewer1.CurrentIndex = -1;
            pdfViewer1.CurrentPageHighlightColor = Color.FromArgb(170, 70, 130, 180);
            pdfViewer1.Document = null;
            pdfViewer1.FormHighlightColor = Color.Transparent;
            pdfViewer1.FormsBlendMode = Patagames.Pdf.Enums.BlendTypes.FXDIB_BLEND_MULTIPLY;
            pdfViewer1.LoadingIconText = "Loading...";
            pdfViewer1.Location = new Point(13, 12);
            pdfViewer1.Margin = new Padding(4, 3, 4, 3);
            pdfViewer1.MouseMode = Patagames.Pdf.Net.Controls.WinForms.MouseModes.Default;
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.OptimizedLoadThreshold = 1000;
            pdfViewer1.Padding = new Padding(12, 12, 12, 12);
            pdfViewer1.PageAlign = ContentAlignment.MiddleCenter;
            pdfViewer1.PageAutoDispose = true;
            pdfViewer1.PageBackColor = Color.White;
            pdfViewer1.PageBorderColor = Color.Black;
            pdfViewer1.PageMargin = new Padding(10);
            pdfViewer1.PageSeparatorColor = Color.Gray;
            pdfViewer1.RenderFlags = Patagames.Pdf.Enums.RenderFlags.FPDF_LCD_TEXT | Patagames.Pdf.Enums.RenderFlags.FPDF_NO_CATCH;
            pdfViewer1.ShowCurrentPageHighlight = true;
            pdfViewer1.ShowLoadingIcon = true;
            pdfViewer1.ShowPageSeparator = true;
            pdfViewer1.Size = new Size(758, 763);
            pdfViewer1.SizeMode = Patagames.Pdf.Net.Controls.WinForms.SizeModes.FitToWidth;
            pdfViewer1.TabIndex = 0;
            pdfViewer1.TextSelectColor = Color.FromArgb(70, 70, 130, 180);
            pdfViewer1.TilesCount = 2;
            pdfViewer1.UseProgressiveRender = true;
            pdfViewer1.ViewMode = Patagames.Pdf.Net.Controls.WinForms.ViewModes.SinglePage;
            pdfViewer1.Zoom = 1F;
            pdfViewer1.CurrentPageChanged += pdfViewer1_CurrentPageChanged;
            // 
            // pdfToolStripPages1
            // 
            pdfToolStripPages1.Dock = DockStyle.Bottom;
            pdfToolStripPages1.Location = new Point(0, 778);
            pdfToolStripPages1.Name = "pdfToolStripPages1";
            pdfToolStripPages1.PdfViewer = pdfViewer1;
            pdfToolStripPages1.RightToLeft = RightToLeft.No;
            pdfToolStripPages1.Size = new Size(784, 27);
            pdfToolStripPages1.TabIndex = 1;
            pdfToolStripPages1.Text = "pdfToolStripPages1";
            pdfToolStripPages1.SizeChanged += pdfToolStripPages1_SizeChanged;
            // 
            // FormPDFViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 805);
            Controls.Add(pdfToolStripPages1);
            Controls.Add(pdfViewer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPDFViewer";
            ShowIcon = false;
            Text = "PDF Viewer";
            Load += FormPDFViewer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfViewer1;
        private Patagames.Pdf.Net.Controls.WinForms.ToolBars.PdfToolStripPages pdfToolStripPages1;
    }
}