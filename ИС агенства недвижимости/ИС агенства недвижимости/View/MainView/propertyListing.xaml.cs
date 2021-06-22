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

namespace ИС_агенства_недвижимости
{
    /// <summary>
    /// Логика взаимодействия для propertyListing.xaml
    /// </summary>
    public partial class propertyListing : Page
    {
        public MainWindow2 mnwnd2;
        public propertyListing(MainWindow2 _mainWindow2)
        {
            InitializeComponent();
            mnwnd2 = _mainWindow2;
            
        }

        public enum pages
        {
            rentPage, sellPg
        }
        public void OpenPage(pages pages)
        {
            if (pages == pages.rentPage)
            {
                frame3.Navigate(new RentPage(this));
            }
            if (pages == pages.sellPg)
            {
                frame3.Navigate(new sellPage(this));
            }

        }

        private void HomeItem_GotFocus(object sender, RoutedEventArgs e)
        {
            mnwnd2.OpenPage(MainWindow2.pages.welcomePage1);
        }

        private void rentItem_GotFocus(object sender, RoutedEventArgs e)
        {
            OpenPage(pages.rentPage);
        }

        private void sellItem_GotFocus(object sender, RoutedEventArgs e)
        {
            OpenPage(pages.sellPg);
        }

        private void closeButt_Click(object sender, RoutedEventArgs e)
        {
            mnwnd2.Close();
        }
    }
}
