using SciADV_ReLauncher.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyINIController;

namespace SciADV_ReLauncher
{
    internal class Functions
    {
        public void ReadConfigFile()
        {
            if (File.Exists(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini"))
            {
                IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");

                FormMain.CHNmainGamePath = mainSettings.Read("CHNgame", "general");
                FormMain.SGmainGamePath = mainSettings.Read("SGgame", "general");
                FormMain.RNEmainGamePath = mainSettings.Read("RNEgame", "general");
                FormMain.CCmainGamePath = mainSettings.Read("CCgame", "general");
                FormMain.SG0mainGamePath = mainSettings.Read("SG0game", "general");
                FormMain.RNDmainGamePath = mainSettings.Read("RNDgame", "general");
                FormMain.OCanimePath = mainSettings.Read("OCanime", "general");
                FormMain.ACmainGamePath = mainSettings.Read("ACgame", "general");

                FormCHNSide.ChaosGatePath = mainSettings.Read("ChaosGate", "CHNSideEntries");
                FormCHNSide.ChaosChatPath = mainSettings.Read("ChaosChat", "CHNSideEntries");
                FormCHNSide.CHLoveChuChuPath = mainSettings.Read("CHLoveChuChu", "CHNSideEntries");
            }
            else if (File.Exists(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini") == false)
            {
                File.Create(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini").Close();
                IniFile mainSettings = new IniFile(@$"{AppContext.BaseDirectory}\\Config\\mainSettings.ini");
                mainSettings.Write("CHNgame", "NONE", "general");
                mainSettings.Write("SGgame", "NONE", "general");
                mainSettings.Write("RNEgame", "NONE", "general");
                mainSettings.Write("CCgame", "NONE", "general");
                mainSettings.Write("SG0game", "NONE", "general");
                mainSettings.Write("RNDgame", "NONE", "general");
                mainSettings.Write("OCanime", "NONE", "general");
                mainSettings.Write("ACgame", "NONE", "general");

                //CHN SIDE ENTRIES
                mainSettings.Write("ChaosGate", "NONE", "CHNSideEntries");
                mainSettings.Write("ChaosChat", "NONE", "CHNSideEntries");
                mainSettings.Write("CHLoveChuChu", "NONE", "CHNSideEntries");
            }
        }
    }
}
