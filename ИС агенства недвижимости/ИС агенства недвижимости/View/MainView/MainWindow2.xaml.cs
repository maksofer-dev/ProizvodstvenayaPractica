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
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.Windows.Threading;
using ИС_агенства_недвижимости.Models;

namespace ИС_агенства_недвижимости
{
    /// <summary>
    /// Логика взаимодействия для MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public DispatcherTimer timer = new DispatcherTimer();
        int interv = 0;
        int minute = 10;
        public MainWindow2()
        {
            InitializeComponent();
            OpenPage(pages.welcomePage1);
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        public enum pages
        {
            welcomePage1, realEstateListWindow, clientPage
        }
        public void OpenPage(pages pages)
        {
            if(pages == pages.welcomePage1)
            {
                frame2.Navigate(new welcomePage(this));
            }
            if(pages == pages.realEstateListWindow)
            {
                frame2.Navigate(new propertyListing(this));
            }
            if (pages == pages.clientPage)
            {
                frame2.Navigate(new ClientList(this));
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timeLbl.Content = minute + ":" + interv;
            if (interv == 0 && minute > 0)
            {
                if (minute == 5)
                {
                    MessageBox.Show("Внимание: до окончания сеанса остается 5 минут");
                }
                minute--;
                interv = 59;                                                         
            }
            else
            {
                if(interv == 0 && minute == 0)
                {
                    MainWindow mnwnd = new MainWindow();  
                    mnwnd.Show();
                    mnwnd.inter = 60;
                    mnwnd.timer.Start();
                    
                    this.Close();
                    timer.Stop();
                }
                else
                {
                    interv--;
                }
                            
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void mainPageLabel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void MainWindowBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
