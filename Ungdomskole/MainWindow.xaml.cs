using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Ungdomskole.Div.DMX;
using static Ungdomskole.Shows.ProfilShows;
using static Ungdomskole.Shows.WashShows;
using static Ungdomskole.Shows.StropeShows;
using static Ungdomskole.Shows.LedParShows;
using static Ungdomskole.Shows.CosmosShows;
using static Ungdomskole.Div.KillCommands;

namespace Ungdomskole
{
    public partial class MainWindow : Window
    {
        public static Thread CS1;
        public MainWindow()
        {
            InitializeComponent();

            OpenDMX.start();
            Thread t = new Thread(DataThread);
            t.Start();

            EnttecStatus();
        }

        void DataThread()
        {
            while (true)
            {
                OpenDMX.writeData();
                Thread.Sleep(50);
            }
        }

        private void EnttecStatus()
        {
            try
            {
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                {
                    Statusbox.Text = "No Enttec USB Device Found";
                }
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    Statusbox.Text = "Found DMX on USB";
                }
                else
                    Statusbox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                Statusbox.Text = "Error Connecting to Enttec USB Device";
            }
        }


        public void ProfilShow1_Button_Click(object sender, RoutedEventArgs e)
        {
            EnttecStatus();

            Thread PS1 = new Thread(ProfilShow1_thread);
            PS1.Start();
        }

        private void ProfilShow2_Button_Click(object sender, RoutedEventArgs e)
        {
            EnttecStatus();

            Thread PS2 = new Thread(ProfilShow2_thread);
            PS2.Start();
        }

        private void WashShow1_Button_Click(object sender, RoutedEventArgs e)
        {
            EnttecStatus();

            Thread WS1 = new Thread(WashShow1_thread);

            WS1.Start();
        }

        private void StropeShow1_Button_Click(object sender, RoutedEventArgs e)
        {
            EnttecStatus();

            Thread SS1 = new Thread(StropeShow1_thread);

            SS1.Start();
        }

        private void LedShow1_Button_Click(object sender, RoutedEventArgs e)
        {
            EnttecStatus();

            Thread LS1 = new Thread(LedParShow1_thread);

            LS1.Start();
        }

        private void CosmosShow1_Button_Click(object sender, RoutedEventArgs e)
        {
            CosmoKillCommand();

            EnttecStatus();

            CS1 = new Thread(CosmosShow1_thread);
            CS1.Start();
        }

        private void CosmosShow4_Button_Click(object sender, RoutedEventArgs e)
        {
            CosmoKillCommand();

            EnttecStatus();

            Thread CS4 = new Thread(CosmosShow4_thread);
            CS4.Start();
        }

        private void CosmoOff_Button_Click(object sender, RoutedEventArgs e)
        {
            CosmoKillCommand();
        }
    }
}
