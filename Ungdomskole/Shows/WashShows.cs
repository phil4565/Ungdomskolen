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
    class WashShows
    {
        public static void WashShow1_thread()
        {
            while (true)
            {
                OpenDMX.setDmxValue(Wash1_Green, 0);
                OpenDMX.setDmxValue(Wash1_Intensity, 255);
                OpenDMX.setDmxValue(Wash1_Red, 255);

                OpenDMX.setDmxValue(Wash1_Pan, 255);
                OpenDMX.setDmxValue(Wash1_Tilt, 255);


                OpenDMX.setDmxValue(Wash2_Green, 0);
                OpenDMX.setDmxValue(Wash2_Intensity, 255);
                OpenDMX.setDmxValue(Wash2_Red, 255);

                OpenDMX.setDmxValue(Wash2_Pan, 255);
                OpenDMX.setDmxValue(Wash2_Tilt, 255);

                Thread.Sleep(2000);

                OpenDMX.setDmxValue(Wash1_Red, 0);
                OpenDMX.setDmxValue(Wash1_Pan, 0);
                OpenDMX.setDmxValue(Wash1_Tilt, 0);

                OpenDMX.setDmxValue(Wash1_Green, 255);

                OpenDMX.setDmxValue(Wash2_Red, 0);
                OpenDMX.setDmxValue(Wash2_Pan, 0);
                OpenDMX.setDmxValue(Wash2_Tilt, 0);

                OpenDMX.setDmxValue(Wash2_Green, 255);

                Thread.Sleep(2000);
            }
        }
    }
}
