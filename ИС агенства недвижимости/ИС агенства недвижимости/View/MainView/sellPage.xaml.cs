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
    /// Логика взаимодействия для sellPage.xaml
    /// </summary>
    public partial class sellPage : Page
    {
        
        
        
        ContextDB db;
        public propertyListing propList;
        public sellPage(propertyListing _propList)
        {
            InitializeComponent();
            propList = _propList;
            db = new ContextDB();
            db.sellingInfo.Load();
            sellingGrid.ItemsSource = db.sellingInfo.Local.ToBindingList();
            //this.Closing += afterLogWindow_Closing;
            //LoadSells();
        }

        private void delBN_Click(object sender, RoutedEventArgs e)
        {
            if (sellingGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < sellingGrid.SelectedItems.Count; i++)
                {
                    SellingInfo sellInfo = sellingGrid.SelectedItems[i] as SellingInfo;
                    if (sellInfo != null)
                    {
                        db.sellingInfo.Remove(sellInfo);
                    }
                }
            }   
            db.SaveChanges();
        }

        private void addBN_Click(object sender, RoutedEventArgs e)
        {
            AddSellInfo addSellInfo = new AddSellInfo();
            addSellInfo.ShowDialog();
        }

        private void barcodeBN_Click(object sender, RoutedEventArgs e)
        {
            
            BarCodeWindow barCodeWindow = new BarCodeWindow(49);
            barCodeWindow.ShowDialog();
        }
    }
}
