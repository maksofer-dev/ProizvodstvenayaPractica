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
using ИС_агенства_недвижимости.Models;

namespace ИС_агенства_недвижимости
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public MainWindow mainWindow;
        
        public Reg(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            
        }
        private void AccButt_Click(object sender, RoutedEventArgs e)
        {
            if (logBox.Text.Length > 0)
            {
                if (passBox.Password.Length > 0)
                {
                    if (passBox.Password.Length > 0)
                    {
                        if (passBox.Password.Length >= 6 && passBox.Password.Length <= 16)
                        {
                            bool en = true;
                            bool symbol = false;
                            bool number = false;
                            for (int i = 0; i < passBox.Password.Length; i++) // перебираем символы
                            {
                                if ((passBox.Password[i] >= 'А' && passBox.Password[i] <= 'Я') || (passBox.Password[i] >= 'а' && passBox.Password[i] <= 'я')) en = false; // если русская раскладка                             
                                if (passBox.Password[i] >= '0' && passBox.Password[i] <= '9') number = true; // если цифры
                                if (passBox.Password[i] == '_' || passBox.Password[i] == '-' || passBox.Password[i] == '!') symbol = true; // если символ
                            }
                            if (en == true)
                            {
                                if (!symbol)
                                {
                                    if (number == true)
                                    {
                                        if (passBox.Password == passBox2.Password)
                                        {
                                            SqlCommands command = new SqlCommands();
                                            DataTable dt_user = command.Select("SELECT * FROM [dbo].[Logins] WHERE [Login] = '" + logBox.Text + "'");
                                            if (dt_user.Rows.Count > 0) // если такая запись существует       
                                            {
                                                warningBox.Text = "Пользователь с таким логином уже зарегестрирован";
                                            }
                                            else
                                            {
                                                command.Select("INSERT INTO [dbo].[Logins] VALUES ('" + logBox.Text + "','" + passBox.Password + "')");
                                                warningBox.Text = "Пользователь зарегестрирован";
                                            }
                                        }
                                        else
                                        {
                                            warningBox.Text = "Пароли не совпадают";
                                        }
                                    }
                                    else
                                    {
                                        warningBox.Text = "В пароле должна содержаться хотя бы одна цифра!";
                                    }
                                }
                                else
                                {
                                    warningBox.Text = "Символы недопустимы!";
                                }
                            }
                            else
                            {
                                warningBox.Text = "Доступна только английская раскладка!";
                            }
                        }
                        else
                        {
                            warningBox.Text = "Пароль должен содержать не больше 16 и не меньше 6 символов символов.";
                        }                                                  
                    }
                    else
                    {
                        {
                            warningBox.Text = "Повторите пароль!";
                        }
                    }
                }
                else
                {
                    warningBox.Text = "Укажите пароль!";
                }
            }
            else
            {
                warningBox.Text = "Укажите логин!";
            }
        }
       

        private void logClearButt_Click(object sender, RoutedEventArgs e)
        {
            logBox.Clear();
        }

        private void showPass2_Click(object sender, RoutedEventArgs e)
        {
            if (showPassIcon2.Kind == MaterialDesignThemes.Wpf.PackIconKind.EyeOff)
            {
                passBox2.Visibility = Visibility.Visible;
                showPassBox2.Visibility = Visibility.Hidden;
                showPassIcon2.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;
            }
            else
            {
                showPassBox2.Text = passBox.Password;
                passBox2.Visibility = Visibility.Hidden;
                showPassBox2.Visibility = Visibility.Visible;
                showPassIcon2.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;
            }
        }

        private void showPass_Click(object sender, RoutedEventArgs e)
        {
            if (showPassIcon.Kind == MaterialDesignThemes.Wpf.PackIconKind.EyeOff)
            {
                passBox.Visibility = Visibility.Visible;
                showPassBox.Visibility = Visibility.Hidden;
                showPassIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;
            }
            else
            {
                showPassBox.Text = passBox.Password;
                passBox.Visibility = Visibility.Hidden;
                showPassBox.Visibility = Visibility.Visible;
                showPassIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;
            }
            
            
        }

        private void signButt_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.loginPage);
        }

        private void showPassBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            passBox.Password = showPassBox.Text;
        }

        private void showPassBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            passBox2.Password = showPassBox2.Text;
        }
    }
}

