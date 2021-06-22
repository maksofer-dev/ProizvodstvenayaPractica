using System;
using System.Collections.Generic;
using System.Data;
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
using ИС_агенства_недвижимости.Models;

namespace ИС_агенства_недвижимости.View.Authorization
{
    /// <summary>
    /// Логика взаимодействия для EmployeeInfo.xaml
    /// </summary>
    public partial class EmployeeInfo : Page
    {
        int interv = 2;
        public MainWindow mainWindow;
        DispatcherTimer timer = new DispatcherTimer();
        public EmployeeInfo(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            fioLbl.Content = mainWindow.staff.FIO;
            posLbl.Content = mainWindow.staff.Position;
            employeeImage.Source = new BitmapImage(new Uri(mainWindow.staff.Photo));
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start(); 

        }

        void timer_Tick(object sender, EventArgs e)
        {     
            if (interv != 0)
            {
                interv--;                
            }
            else
            {
                
                MainWindow2 mainWindow2 = new MainWindow2();
                mainWindow2.Owner = this.mainWindow;
                mainWindow2.Show();
                
                this.mainWindow.Hide();
                timer.Stop();

            }
        }

    }
}
