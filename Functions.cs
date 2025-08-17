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

                //MAIN GAME ENTRIES
                FormMain.CHNmainGamePath = mainSettings.Read("CHNgame", "general");
                FormMain.SGmainGamePath = mainSettings.Read("SGgame", "general");
                FormMain.RNEmainGamePath = mainSettings.Read("RNEgame", "general");
                FormMain.CCmainGamePath = mainSettings.Read("CCgame", "general");
                FormMain.SG0mainGamePath = mainSettings.Read("SG0game", "general");
                FormMain.RNDmainGamePath = mainSettings.Read("RNDgame", "general");
                FormMain.OCanimePath = mainSettings.Read("OCanime", "general");
                FormMain.ACmainGamePath = mainSettings.Read("ACgame", "general");

                //CHN SIDE ENTRIES
                FormCHNSide.ChaosGatePath = mainSettings.Read("ChaosGate", "CHNSideEntries");
                FormCHNSide.CHLoveChuChuPath = mainSettings.Read("CHLoveChuChu", "CHNSideEntries");
                FormCHNSide.ChaosChatPath = mainSettings.Read("ChaosChat", "CHNSideEntries");

                //SG SIDE ENTRIES
                FormSGSide.HolyDayOfTheCalamitousBirthPath = mainSettings.Read("HolyDayOfTheCalamitousBirth", "SGSideEntries");
                FormSGSide.EgoisticPoriomaniaPath = mainSettings.Read("EgoisticPoriomania", "SGSideEntries");
                FormSGSide.LoadRegionOfDejaVuPath = mainSettings.Read("LoadRegionOfDejaVu", "SGSideEntries");
                FormSGSide.AnAPosterioriExistencePath = mainSettings.Read("AnAPosterioriExistence", "SGSideEntries");
                FormSGSide.SGVariantSpaceOctetPath = mainSettings.Read("SGVariantSpaceOctet", "SGSideEntries");
                FormSGSide.SGMyDarlingsEmbracePath = mainSettings.Read("SGMyDarlingsEmbrace", "SGSideEntries");
                FormSGSide.BabelOfTheGrievedMazePath = mainSettings.Read("BabelOfTheGrievedMaze", "SGSideEntries");
                FormSGSide.ArcLightOfThePointAtInfinityPath = mainSettings.Read("ArcLightOfThePointAtInfinity", "SGSideEntries");
                FormSGSide.HydeOfTheDarkDimensionPath = mainSettings.Read("HydeOfTheDarkDimension", "SGSideEntries");
                FormSGSide.RebellionOfTheMissingRingPath = mainSettings.Read("RebellionOfTheMissingRing", "SGSideEntries");
                FormSGSide.TheDistantValhallaPath = mainSettings.Read("TheDistantValhalla", "SGSideEntries");
                FormSGSide.BraunianMotionOfLoveAndHatePath = mainSettings.Read("BraunianMotionOfLoveAndHate", "SGSideEntries");

                //RNE SIDE ENTRIES

                //CC SIDE ENTRIES

                //SG0 SIDE ENTRIES

                //RND SIDE ENTRIES

                //AC SIDE ENTRIES
                //FormACSide.ACGuideBookPath = mainSettings.Read("ACGuideBook", "ACSideEntries");
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
                mainSettings.Write("CHLoveChuChu", "NONE", "CHNSideEntries");
                mainSettings.Write("ChaosChat", "NONE", "CHNSideEntries");

                //SG SIDE ENTRIES
                mainSettings.Write("HolyDayOfTheCalamitousBirth", "NONE", "SGSideEntries");
                mainSettings.Write("EgoisticPoriomania", "NONE", "SGSideEntries");
                mainSettings.Write("LoadRegionOfDejaVu", "NONE", "SGSideEntries");
                mainSettings.Write("AnAPosterioriExistence", "NONE", "SGSideEntries");
                mainSettings.Write("SGVariantSpaceOctet", "NONE", "SGSideEntries");
                mainSettings.Write("SGMyDarlingsEmbrace", "NONE", "SGSideEntries");
                mainSettings.Write("BabelOfTheGrievedMaze", "NONE", "SGSideEntries");
                mainSettings.Write("ArcLightOfThePointAtInfinity", "NONE", "SGSideEntries");
                mainSettings.Write("HydeOfTheDarkDimension", "NONE", "SGSideEntries");
                mainSettings.Write("RebellionOfTheMissingRing", "NONE", "SGSideEntries");
                mainSettings.Write("TheDistantValhalla", "NONE", "SGSideEntries");
                mainSettings.Write("BraunianMotionOfLoveAndHate", "NONE", "SGSideEntries");

                //RNE SIDE ENTRIES

                //CC SIDE ENTRIES

                //SG0 SIDE ENTRIES

                //RND SIDE ENTRIES

                //AC SIDE ENTRIES
                //mainSettings.Write("ACGuideBook", "NONE", "ACSideEntries");
            }
        }
    }
}
