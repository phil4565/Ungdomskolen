using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ungdomskole.Div.DMX;
using static Ungdomskole.Div.Declaration;
using System.Threading;

namespace Ungdomskole.Shows
{
    class LedParShows
    {
        public static void LedParShow1_thread()
        {
            while (true)
            {
                OpenDMX.setDmxValue(LED1_Blue, 0);
                OpenDMX.setDmxValue(LED1_Intensity, 255);
                OpenDMX.setDmxValue(LED1_Red, 255);

                Thread.Sleep(2000);

                OpenDMX.setDmxValue(LED1_Red, 0);
                OpenDMX.setDmxValue(LED1_Green, 255);

                Thread.Sleep(2000);

                OpenDMX.setDmxValue(LED1_Green, 0);
                OpenDMX.setDmxValue(LED1_Blue, 255);

                Thread.Sleep(2000);
            }
        }
    }
}
