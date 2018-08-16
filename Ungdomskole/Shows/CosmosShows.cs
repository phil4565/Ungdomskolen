using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Ungdomskole.Div.DMX;
using static Ungdomskole.Div.Declaration;

namespace Ungdomskole.Shows
{
    class CosmosShows
    {
        public static bool CosmoShow1Started = false;
        public static bool CosmoShow2Started = false;
        public static bool CosmoShow3Started = false;
        public static bool CosmoShow4Started = false;

        public static void CosmosShow1_thread()
        {
            int antal = 2;
            CosmoShow1Started = true;
            while (CosmoShow1Started)
            {
                for (int i = 0; i <= antal; i++)
                {
                    OpenDMX.setDmxValue(Cosmos1_Intensity, 255);
                    OpenDMX.setDmxValue(Cosmos1_Continues_Roll, 75);
                    OpenDMX.setDmxValue(Cosmos1_Control_All_Led, 5);
                    OpenDMX.setDmxValue(Cosmos1_Turn, 255);
                    Thread.Sleep(2500);
                    if (CosmoShow1Started == false) { break; }

                    OpenDMX.setDmxValue(Cosmos1_Turn, 0);
                    Thread.Sleep(2500);
                    if (CosmoShow1Started == false) { break; }
                }

                if (CosmoShow1Started == false) { break; }

                for (int i = 0; i <= antal; i++)
                {
                    OpenDMX.setDmxValue(Cosmos1_Control_All_Led, 11);
                    OpenDMX.setDmxValue(Cosmos1_Turn, 255);
                    Thread.Sleep(2500);
                    if (CosmoShow1Started == false) { break; }

                    OpenDMX.setDmxValue(Cosmos1_Turn, 0);
                    Thread.Sleep(2500);
                    if (CosmoShow1Started == false) { break; }
                }

                if (CosmoShow1Started == false) { break; }

                for (int i = 0; i <= antal; i++)
                {
                    OpenDMX.setDmxValue(Cosmos1_Control_All_Led, 17);
                    OpenDMX.setDmxValue(Cosmos1_Turn, 255);
                    Thread.Sleep(2500);
                    if (CosmoShow1Started == false) { break; }

                    OpenDMX.setDmxValue(Cosmos1_Turn, 0);
                    Thread.Sleep(2500);
                    if (CosmoShow1Started == false) { break; }
                }

                if (CosmoShow1Started == false) { break; }

                for (int i = 0; i <= antal; i++)
                {
                    OpenDMX.setDmxValue(Cosmos1_Control_All_Led, 23);
                    OpenDMX.setDmxValue(Cosmos1_Turn, 255);
                    Thread.Sleep(2500);
                    if (CosmoShow1Started == false) { break; }

                    OpenDMX.setDmxValue(Cosmos1_Turn, 0);
                    Thread.Sleep(2500);
                    if (CosmoShow1Started == false) { break; }
                }

                if (CosmoShow1Started == false) { break; }
            }
        }

        public static void CosmosShow4_thread()
        {
            CosmoShow4Started = true;

            while (CosmoShow4Started)
            {
                OpenDMX.setDmxValue(Cosmos1_Intensity, 255);
                OpenDMX.setDmxValue(Cosmos1_Auto, 255);
            }
            OpenDMX.setDmxValue(Cosmos1_Auto, 0);
        }
    }
}
