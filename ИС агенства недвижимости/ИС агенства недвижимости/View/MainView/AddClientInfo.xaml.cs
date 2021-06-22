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
    /// Логика взаимодействия для AddClientInfo.xaml
    /// </summary>
    public partial class AddClientInfo : Window
    {
        SqlCommands command = new SqlCommands();
        public AddClientInfo()
        {
            InitializeComponent();
        }

        private void addBN_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt_user = command.Select("SELECT * FROM [dbo].[ClientsInfoes]");
            command.Select("INSERT INTO [dbo].[ClientsInfoes] (id, address, telephone, Dogovor, FIO, NomerPasporta, Email, NomerDogovora) VALUES ('" + (Convert.ToString(dt_user.Rows.Count) + 1) + "','" + addressBox.Text + "','" + telBox.Text + "','" + clipPathLBL.Content + "','" + fioBox.Text + "','" + numPassBox.Text + "','" + emailBox.Text + "','" + numDogBox.Text + "')");
            this.Close();
        }

        private void cancelBN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
    }
}
