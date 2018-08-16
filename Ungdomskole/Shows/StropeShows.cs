using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ungdomskole.Div.DMX;
using static Ungdomskole.Div.Declaration;

namespace Ungdomskole.Shows
{
    class StropeShows
    {
        public static void StropeShow1_thread()
        {
            while (true)
            {
                OpenDMX.setDmxValue(Strope_Intensity, 255);
                OpenDMX.setDmxValue(Strope_Strope, 250);

                OpenDMX.setDmxValue(Strope_White, 255);
            }
        }
    }
}
