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
    class ProfilShows
    {
        public static void ProfilShow1_thread()
        {
            while (true)
            {
                
                OpenDMX.setDmxValue(Profil1_Intensity, 255);
                OpenDMX.setDmxValue(Profil1_Pan, 127);
                OpenDMX.setDmxValue(Profil1_Tilt, 127);

                Thread.Sleep(2000);

                OpenDMX.setDmxValue(Profil1_Pan, 0);
                OpenDMX.setDmxValue(Profil1_Tilt, 0);

                Thread.Sleep(2000);
            }
        }

        public static void ProfilShow2_thread()
        {
            while (true)
            {
                OpenDMX.setDmxValue(Profil1_Color, 255);
                OpenDMX.setDmxValue(Profil1_Strope, 255);
                OpenDMX.setDmxValue(Profil1_Intensity, 255);

                OpenDMX.setDmxValue(Profil1_Pan, 255);
                OpenDMX.setDmxValue(Profil1_Tilt, 255);

                OpenDMX.setDmxValue(Profil2_Color, 255);
                OpenDMX.setDmxValue(Profil2_Strope, 255);
                OpenDMX.setDmxValue(Profil2_Intensity, 255);

                OpenDMX.setDmxValue(Profil2_Pan, 255);
                OpenDMX.setDmxValue(Profil2_Tilt, 255);

                Thread.Sleep(2000);

                OpenDMX.setDmxValue(Profil1_Pan, 0);
                OpenDMX.setDmxValue(Profil1_Tilt, 0);


                OpenDMX.setDmxValue(Profil2_Pan, 0);
                OpenDMX.setDmxValue(Profil2_Tilt, 0);

                Thread.Sleep(2000);
            }
        }
    }
}
