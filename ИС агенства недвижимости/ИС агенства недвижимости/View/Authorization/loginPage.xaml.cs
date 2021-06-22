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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using ИС_агенства_недвижимости.Models;
using ИС_агенства_недвижимости.View.Authorization;

namespace ИС_агенства_недвижимости
{
    /// <summary>
    /// Логика взаимодействия для loginPage.xaml
    /// </summary>
    public partial class loginPage : Page
    {
        
       
        public MainWindow mainWindow;
        public loginPage(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.timer.Interval = new TimeSpan(0, 0, 1);
            mainWindow.timer.Tick += timer_Tick;

            
        }

        
        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            

            if (logBox.Text.Length > 0 && passBox.Password.Length > 0)
            {
                if (Convert.ToString(genCaptchaBox.Content) == "" || Convert.ToString(genCaptchaBox.Content) == captchaBox.Text)      
                {
                    // ищем в базе данных пользователя с такими данными         
                    SqlCommands command = new SqlCommands();
                    DataTable dt_user = command.Select("SELECT * FROM [dbo].[StaffInfo] WHERE [Login] = '" + logBox.Text + "' AND [Password] = '" + passBox.Password + "'");
                    if (dt_user.Rows.Count > 0) // если такая запись существует       
                    {
                        DataTable dt_users = command.Select("SELECT * FROM [dbo].[StaffInfo]");
                        for (int i = 0; i < dt_users.Rows.Count; i++) // перебираем данные  
                        {
                            if (logBox.Text == dt_users.Rows[i][0].ToString())
                            {                                
                                mainWindow.staff.FIO = dt_users.Rows[i][2].ToString();
                                mainWindow.staff.Position = dt_users.Rows[i][3].ToString();
                                mainWindow.staff.Photo = dt_users.Rows[i][5].ToString();                               
                            }
                        }
                        mainWindow.OpenPage(MainWindow.pages.employeePage);

                    }
                    else
                    {
                        if (Convert.ToString(genCaptchaBox.Content) != "")
                        {
                            CaptchaChecker();
                        }
                        else
                        {
                            CaptchaGenerator();
                        }
                        
                        MessageBox.Show("Пользователя не найден");
                    }
                        
                }
                else
                {
                    if (Convert.ToString(genCaptchaBox.Content) != "")
                    {
                        CaptchaChecker();
                    }
                    else
                    {
                        CaptchaGenerator();
                    }
                    MessageBox.Show("Не правильно введена капча");
                }
                   
            }
            else
            {
                if (Convert.ToString(genCaptchaBox.Content) != "")
                {
                    CaptchaChecker();
                }
                else
                {
                    CaptchaGenerator();
                }
                MessageBox.Show("Не введен логин или пароль!");
            }

        }

        void CaptchaGenerator()
        {
            if(captchaBorder.IsVisible == false)
            {
                Grid.SetRow(logButton, 3);
                Grid.SetRow(regPanel, 4);
                captchaBorder.Visibility = Visibility.Visible;
            }

            char[] chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789".ToCharArray();
            string randomString = "";
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                randomString += chars[ran.Next(0, chars.Length)];
            }
            genCaptchaBox.Content = randomString;
        }
        private void regButt_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.Reg);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            inputBlockBox.Visibility = Visibility.Visible;
            logPanel.Visibility = Visibility.Hidden;
            inputBlockBox.Text = "Блокировка авторизации сек " + mainWindow.inter.ToString();
            if (mainWindow.inter == 0)
            {
                inputBlockBox.Visibility = Visibility.Hidden;
                logPanel.Visibility = Visibility.Visible;
                mainWindow.timer.Stop();
                CaptchaGenerator();
                mainWindow.inter = 10;
            }
            else
            {
                mainWindow.inter--;
            }
        }
        void CaptchaChecker()
        {
            if (Convert.ToString(genCaptchaBox.Content) != captchaBox.Text)
            {
                MessageBox.Show("Неправильно введена капча!");
                
                genCaptchaBox.Content = "";
                mainWindow.timer.Start();
            }
        }

        private void refreshCaptchaButton_Click(object sender, RoutedEventArgs e)
        {
            CaptchaGenerator();
        }

        private void logClearButt_Click(object sender, RoutedEventArgs e)
        {
            logBox.Clear();
        }

        private void showPass_Click(object sender, RoutedEventArgs e)
        {
            passBox2.Text = passBox.Password;
            passBox.Visibility = Visibility.Hidden;
            passBox2.Visibility = Visibility.Visible;
            showPassIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.EyeOff;
            Button btn = sender as Button;
            btn.Click -= new RoutedEventHandler(showPass_Click);
            btn.Click += new RoutedEventHandler(showPass_Click_1);
        }
        private void showPass_Click_1(object sender, RoutedEventArgs e)
        {

            passBox.Password = passBox2.Text;
            passBox.Visibility = Visibility.Visible;
            passBox2.Visibility = Visibility.Hidden;
            showPassIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Eye;
            Button btn = sender as Button;
            btn.Click -= new RoutedEventHandler(showPass_Click_1);
            btn.Click += new RoutedEventHandler(showPass_Click);
        }

    }
}
