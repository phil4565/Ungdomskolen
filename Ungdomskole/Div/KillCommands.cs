using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ungdomskole.Div.DMX;
using static Ungdomskole.Div.Declaration;
using static Ungdomskole.Shows.CosmosShows;

namespace Ungdomskole.Div
{
    class KillCommands
    {
        public static void CosmoKillCommand()
        {
            OpenDMX.setDmxValue(Cosmos1_Turn, 0);
            OpenDMX.setDmxValue(Cosmos1_Control_All_Led, 1);
            OpenDMX.setDmxValue(Cosmos1_Continues_Roll, 0);
            OpenDMX.setDmxValue(Cosmos1_Auto, 0);

            CosmoShow1Started = false;
            CosmoShow4Started = false;
        }
    }
}
