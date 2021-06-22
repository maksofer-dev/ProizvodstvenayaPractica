using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
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

namespace ИС_агенства_недвижимости.View.MainView
{
    /// <summary>
    /// Логика взаимодействия для BarCodeWindow.xaml
    /// </summary>
    public partial class BarCodeWindow : Window
    {
        DateTime date = DateTime.Now;
        System.Drawing.Image img;
        public BarCodeWindow(int service)
        {
            InitializeComponent();
            Random ran = new Random();

            string gener = Convert.ToString(service) + date.Day + date.Month + date.Year + ran.Next(100001, 999991);
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            img = b.Encode(BarcodeLib.TYPE.EAN13, gener, System.Drawing.Color.Black, System.Drawing.Color.White, 290, 120);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);//save image in memory
            byte[] buffer = ms.GetBuffer();
            MemoryStream bufferPasser = new MemoryStream(buffer);
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = bufferPasser;
            bitmap.EndInit();
            barCodeIMG.Source = bitmap;
            barCodeLBL.Content = gener;
            
            
        }

        private void genBarCodeBN_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void saveBarCodeBN_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Сохранить штрих-код как...";
            save.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (save.ShowDialog() == true)
            {
                img.Save(save.FileName);
            }
        }

        private void closeButt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
