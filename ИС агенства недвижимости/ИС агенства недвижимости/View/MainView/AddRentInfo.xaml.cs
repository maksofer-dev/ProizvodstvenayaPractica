using Microsoft.Win32;
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
using System.Windows.Shapes;
using ИС_агенства_недвижимости.Models;

namespace ИС_агенства_недвижимости.View.MainView
{
    /// <summary>
    /// Логика взаимодействия для AddRentInfo.xaml
    /// </summary>
    public partial class AddRentInfo : Window
    {
        SqlCommands command = new SqlCommands();

        public AddRentInfo()
        {
            InitializeComponent();
        }

        private void addImaage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() == true)
            {                
                clipPathLBL.Content = openDialog.FileName;
            }
        }

        private void addBN_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt_user = command.Select("SELECT * FROM [dbo].[RentsInfoes]");
            command.Select("INSERT INTO [dbo].[RentsInfoes] (id, Cost, address, telephone, owner, photo, kolvoKomnat, Etajnost, Plosad) VALUES ('" + (Convert.ToString(dt_user.Rows.Count) + 1) + "','" + costBox.Text + "','" + addressBox.Text + "','" + telBox.Text + "','" + fioBox.Text + "','" + clipPathLBL.Content + "','" + kolvoBox.Text + "','" +  etajBox.Text + "','" + plosBox.Text + "')");
            this.Close();
        }

        private void cancelBN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
