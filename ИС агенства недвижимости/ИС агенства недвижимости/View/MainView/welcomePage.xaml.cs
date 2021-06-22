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

namespace ИС_агенства_недвижимости
{
    /// <summary>
    /// Логика взаимодействия для welcomePage.xaml
    /// </summary>
    public partial class welcomePage : Page
    {
        public MainWindow2 mnwnd2;
        
        public welcomePage(MainWindow2 _mainWindow2)
        {
            InitializeComponent();
            mnwnd2 = _mainWindow2;
            
        }

        private void RealEstateListButt_Click(object sender, RoutedEventArgs e)
        {
            mnwnd2.OpenPage(MainWindow2.pages.realEstateListWindow);
        }

        private void clientListButt_Click(object sender, RoutedEventArgs e)
        {           
            mnwnd2.OpenPage(MainWindow2.pages.clientPage);
        }

        private void closeButt_Click(object sender, RoutedEventArgs e)
        {
            mnwnd2.Close();
        }
    }
}
