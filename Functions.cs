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
                FormSGSide.OkabeRintaroBirthdaySpecialPath = mainSettings.Read("OkabeRintaroBirthdaySpecial", "SGSideEntries");

                //RNE SIDE ENTRIES
                FormRNESide.TheHomeOfOurDreamsPath = mainSettings.Read("TheHomeOfOurDreams", "RNESideEntries");
                FormRNESide.WinterSkyRocketPath = mainSettings.Read("WinterSkyRocket", "RNESideEntries");
                FormRNESide.MapsTheRainAndMacaronsPath = mainSettings.Read("MapsTheRainAndMacarons", "RNESideEntries");
                FormRNESide.TheUnpublishedMemoirsOfSenomiyaMisakiPath = mainSettings.Read("TheUnpublishedMemoirsOfSenomiyaMisaki", "RNESideEntries");
                FormRNESide.TomorrowInTheBoxPath = mainSettings.Read("TomorrowInTheBox", "RNESideEntries");
                FormRNESide.MerryChristmalsPath = mainSettings.Read("MerryChristmas", "RNESideEntries");
                FormRNESide.SGLinearBoundedPhenogramPath = mainSettings.Read("SGLinearBoundedPhenogram", "RNESideEntries");

                //CC SIDE ENTRIES
                FormCCSide.TheWrongSiderMemoirsPath = mainSettings.Read("TheWrongSiderMemoirs", "CCSideEntries");
                FormCCSide.WishPath = mainSettings.Read("Wish", "CCSideEntries");
                FormCCSide.SlumberingFoolsPath = mainSettings.Read("SlumberingFools", "CCSideEntries");
                FormCCSide.ChildrensCollapsePath = mainSettings.Read("ChildrensCollapse", "CCSideEntries");
                FormCCSide.ChildrensCollapseFirstTimeGoingOutPath = mainSettings.Read("ChildrensCollapseFirstTimeGoingOut", "CCSideEntries");
                FormCCSide.CCLoveChuChuPath = mainSettings.Read("CCLoveChuChu", "CCSideEntries");
                FormCCSide.ChildrensRevivePath = mainSettings.Read("ChildrensRevive", "CCSideEntries");
                FormCCSide.DreamPath = mainSettings.Read("Dream", "CCSideEntries");
                FormCCSide.MaidInUkiPath = mainSettings.Read("MaidInUki", "CCSideEntries");
                FormCCSide.ChaosSisterPath = mainSettings.Read("ChaosSister", "CCSideEntries");

                //SG0 SIDE ENTRIES
                FormSG0Side.TwentyThreeBetaDivideByZeroPath = mainSettings.Read("23BetaDivideByZero", "SG0SideEntries");
                FormSG0Side.SG0AnimePath = mainSettings.Read("SG0Anime", "SG0SideEntries");
                FormSG0Side.ParadiseLostInAdaptiveRadiationPath = mainSettings.Read("ParadiseLostInAdaptiveRadiation", "SG0SideEntries");
                FormSG0Side.FeastOfTheValkriesPath = mainSettings.Read("FeastOfTheValkyries", "SG0SideEntries");
                FormSG0Side.DaruPart1TheHashidaFamilysLoveAndAffectionPath = mainSettings.Read("DaruPart1TheHashidaFamilysLoveAndAffection", "SG0SideEntries");
                FormSG0Side.DaruPart2ThePerpetuallyInfiniteHashidaConcertoPath = mainSettings.Read("DaruPart2ThePerpetuallyInfiniteHashidaConcerto", "SG0SideEntries");
                FormSG0Side.DaruPart3TheDogDaysOfHashidaComimaPath = mainSettings.Read("DaruPart3TheDogDaysOfHashidaComima", "SG0SideEntries");
                FormSG0Side.TimeLongAgoPath = mainSettings.Read("TimeLongAgo", "SG0SideEntries");
                FormSG0Side.EpigraphBonusShortPath = mainSettings.Read("EpigraphBonusShort", "SG0SideEntries");

                //RND SIDE ENTRIES
                FormRNDSide.NextBatonPath = mainSettings.Read("NextBaton", "RNDSideEntries");

                //AC SIDE ENTRIES
                FormACSide.ACGuideBookPath = mainSettings.Read("ACGuideBook", "ACSideEntries");
                FormACSide.MAGESFES2023HackersCrosstalkPath = mainSettings.Read("MAGESFES2023HackersCrosstalk", "ACSideEntries");
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
                mainSettings.Write("OkabeRintaroBirthdaySpecial", "NONE", "SGSideEntries");

                //RNE SIDE ENTRIES
                mainSettings.Write("TheHomeOfOurDreams", "NONE", "RNESideEntries");
                mainSettings.Write("WinterSkyRocket", "NONE", "RNESideEntries");
                mainSettings.Write("MapsTheRainAndMacarons", "NONE", "RNESideEntries");
                mainSettings.Write("TheUnpublishedMemoirsOfSenomiyaMisaki", "NONE", "RNESideEntries");
                mainSettings.Write("TomorrowInTheBox", "NONE", "RNESideEntries");
                mainSettings.Write("MerryChristmas", "NONE", "RNESideEntries");
                mainSettings.Write("SGLinearBoundedPhenogram", "NONE", "RNESideEntries");

                //CC SIDE ENTRIES
                mainSettings.Write("TheWrongSiderMemoirs", "NONE", "CCSideEntries");
                mainSettings.Write("Wish", "NONE", "CCSideEntries");
                mainSettings.Write("SlumberingFools", "NONE", "CCSideEntries");
                mainSettings.Write("ChildrensCollapse", "NONE", "CCSideEntries");
                mainSettings.Write("ChildrensCollapseFirstTimeGoingOut", "NONE", "CCSideEntries");
                mainSettings.Write("CCLoveChuChu", "NONE", "CCSideEntries");
                mainSettings.Write("ChildrensRevive", "NONE", "CCSideEntries");
                mainSettings.Write("Dream", "NONE", "CCSideEntries");
                mainSettings.Write("MaidInUki", "NONE", "CCSideEntries");
                mainSettings.Write("ChaosSister", "NONE", "CCSideEntries");

                //SG0 SIDE ENTRIES
                mainSettings.Write("23BetaDivideByZero", "NONE", "SG0SideEntries");
                mainSettings.Write("SG0Anime", "NONE", "SG0SideEntries");
                mainSettings.Write("ParadiseLostInAdaptiveRadiation", "NONE", "SG0SideEntries");
                mainSettings.Write("FeastOfTheValkyries", "NONE", "SG0SideEntries");
                mainSettings.Write("DaruPart1TheHashidaFamilysLoveAndAffection", "NONE", "SG0SideEntries");
                mainSettings.Write("DaruPart2ThePerpetuallyInfiniteHashidaConcerto", "NONE", "SG0SideEntries");
                mainSettings.Write("DaruPart3TheDogDaysOfHashidaComima", "NONE", "SG0SideEntries");
                mainSettings.Write("TimeLongAgo", "NONE", "SG0SideEntries");
                mainSettings.Write("EpigraphBonusShort", "NONE", "SG0SideEntries");

                //RND SIDE ENTRIES
                mainSettings.Write("NextBaton", "NONE", "RNDSideEntries");

                //AC SIDE ENTRIES
                mainSettings.Write("ACGuideBook", "NONE", "ACSideEntries");
                mainSettings.Write("MAGESFES2023HackersCrosstalk", "NONE", "ACSideEntries");
            }
        }
    }
}
