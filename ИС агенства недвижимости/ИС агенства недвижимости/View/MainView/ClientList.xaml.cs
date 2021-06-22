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
    /// Логика взаимодействия для ClientList.xaml
    /// </summary>
    public partial class ClientList : Page
    {
        public MainWindow2 mnwnd2;
        ContextDB db;
        
        public ClientList(MainWindow2 _mainWindow2)
        {
            InitializeComponent();
            mnwnd2 = _mainWindow2;
            db = new ContextDB();
            db.clientsInfo.Load();
            clientsGrid.ItemsSource = db.clientsInfo.Local.ToBindingList();
            //LoadClients();
        }

        private void HomeItem_GotFocus(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
            mnwnd2.OpenPage(MainWindow2.pages.welcomePage1);
        }

        private void addItem_GotFocus(object sender, RoutedEventArgs e)
        {
            AddClientInfo addClientInfo = new AddClientInfo();
            addClientInfo.ShowDialog();


        }
        private void deleteItem_GotFocus(object sender, RoutedEventArgs e)
        {
            if (clientsGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < clientsGrid.SelectedItems.Count; i++)
                {
                    ClientsInfo clInfo = clientsGrid.SelectedItems[i] as ClientsInfo;
                    if (clInfo != null)
                    {
                        db.clientsInfo.Remove(clInfo);
                    }
                }
            }
            db.SaveChanges();
        }

        private void delBN_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void closeButt_Click(object sender, RoutedEventArgs e)
        {
            mnwnd2.Close();
        }
    }
}
