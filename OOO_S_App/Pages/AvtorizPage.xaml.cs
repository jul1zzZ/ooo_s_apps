using OOO_S_App.Base;
using OOO_S_App.Class;
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

namespace OOO_S_App.Pages
{
    /// <summary>
    /// Логика взаимодействия для AvtorizPage.xaml
    /// </summary>
    public partial class AvtorizPage : Page
    {
        short _attempts;
        public AvtorizPage()
        {
            InitializeComponent();
            _attempts = 0;
        }

        private void gost_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("*Режим ГОСТЬ включен*");
            NavigationService.Navigate(new Pages.GostPage());
        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _attempts++;

                User user = TradeEntities.GetContext().Users.FirstOrDefault(u => u.U_Login == TB.Text && u.U_Pass == PB.Password);

                if (user != null)
                {
                    if (user.U_Role_ID == 1)
                    {
                        Auth.U_Familya = user.U_Familya;
                        Auth.U_Imya = user.U_Imya;
                        Auth.U_Otchestvo = user.U_Otchestvo;
                        MessageBox.Show("*Вы вошли в систему под ролью - Клиент*");
                        NavigationService.Navigate(new Pages.ClientPage());
                    }
                    else if (user.U_Role_ID == 2)
                    {
                        Auth.U_Familya = user.U_Familya;
                        Auth.U_Imya = user.U_Imya;
                        Auth.U_Otchestvo = user.U_Otchestvo;
                        MessageBox.Show("*Вы вошли в систему под ролью - Админ*");
                        NavigationService.Navigate(new Pages.AdminPage());
                    }
                    else if (user.U_Role_ID == 3)
                    {
                        Auth.U_Familya = user.U_Familya;
                        Auth.U_Imya = user.U_Imya;
                        Auth.U_Otchestvo = user.U_Otchestvo;
                        MessageBox.Show("*Вы вошли в систему под ролью - Менеджер*");
                        NavigationService.Navigate(new Pages.ManagerPage());
                    }
                }

                else
                {
                    if (_attempts < 2)
                    {
                        MessageBox.Show("*Неверный логин или пароль*");
                    }
                    else
                    {
                        NavigationService.Navigate(new Pages.CaptchaPage());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void omena_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
