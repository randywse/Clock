using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Windows.Threading;
using System.Globalization;

namespace CU_Direct_Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        TimeZone localZone = TimeZone.CurrentTimeZone;
        public MainWindow()
        {
            InitializeComponent();
           

        }
        private void LoadTime(object sender, RoutedEventArgs e)
        {
             timer = new System.Windows.Threading.DispatcherTimer();
             timer.Interval = new TimeSpan(0,0,1);   
             timer.Tick += new EventHandler(timer_Tick);
             timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
             EasternTime.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")).ToString("MM/dd/yyyy") + "\t" + TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")).ToString("HH:mm:ss");
             CentralTime.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time")).ToString("MM/dd/yyyy") + "\t" + TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time")).ToString("HH:mm:ss");
             MountainTime.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time")).ToString("MM/dd/yyyy") + "\t" + TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Mountain Standard Time")).ToString("HH:mm:ss");
             PacificTime.Text = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")).ToString("MM/dd/yyyy") + "\t" + TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")).ToString("HH:mm:ss");
             SystemTime.Text = "Current Timezone is " + "\t" + localZone.DaylightName;
        
        
        }

    }
}
