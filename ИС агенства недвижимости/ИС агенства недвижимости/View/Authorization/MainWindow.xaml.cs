using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using ИС_агенства_недвижимости.View.Authorization;

namespace ИС_агенства_недвижимости
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer timer = new DispatcherTimer();
        public int inter = 10;
        public Staff staff = new Staff();
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(pages.loginPage);
        }
        public enum pages 
        {
            employeePage, loginPage, Reg
        }
        public void OpenPage(pages pages)
        {
            if (pages == pages.employeePage)
            {
                frame.Navigate(new EmployeeInfo(this));
            }
            if (pages == pages.loginPage)
            {
                frame.Navigate(new loginPage(this));
            }
            if(pages == pages.Reg)
            {
                frame.Navigate(new Reg(this));
            }
            

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MainWindowBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

       

        private void closeButt_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void mainWIndowBorder_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
