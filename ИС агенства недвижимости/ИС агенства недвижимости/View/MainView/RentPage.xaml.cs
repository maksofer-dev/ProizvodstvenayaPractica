using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
using ИС_агенства_недвижимости.Models;
using ИС_агенства_недвижимости.View.MainView;

namespace ИС_агенства_недвижимости
{
    /// <summary>
    /// Логика взаимодействия для RentPage.xaml
    /// </summary>
    public partial class RentPage : Page
    {
        public MainWindow mainWindow;
                
        ContextDB db;
        public propertyListing propList;
        public RentPage(propertyListing _propList)
        {
            InitializeComponent();
            propList = _propList;
            db = new ContextDB();
            db.rentsInfo.Load();
            rentsGrid.ItemsSource = db.rentsInfo.Local.ToBindingList();
            //LoadRents();
        }

        private void delBN_Click(object sender, RoutedEventArgs e)
        {
            if (rentsGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < rentsGrid.SelectedItems.Count; i++)
                {
                    RentsInfo rtInfo = rentsGrid.SelectedItems[i] as RentsInfo;
                    if (rtInfo != null)
                    {
                        db.rentsInfo.Remove(rtInfo);
                    }
                }
            }
            db.SaveChanges();
        }

        private void addBN_Click(object sender, RoutedEventArgs e)
        {
            AddRentInfo addRentInfo = new AddRentInfo();
            addRentInfo.ShowDialog();
        }

        private void barcodeBN_Click(object sender, RoutedEventArgs e)
        {
            BarCodeWindow barCodeWindow = new BarCodeWindow(51);
            barCodeWindow.ShowDialog();
        }
    }
}
