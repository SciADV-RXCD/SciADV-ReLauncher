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
    public partial class FormSGSideConfig : Form
    {
        public FormSGSideConfig()
        {
            InitializeComponent();
        }

        private void FormSGSideConfig_Load(object sender, EventArgs e)
        {
            IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");
        }
    }
}
