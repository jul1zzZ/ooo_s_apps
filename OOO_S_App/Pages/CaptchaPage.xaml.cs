using OOO_S_App.Class;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOO_S_App.Pages
{
    /// <summary>
    /// Логика взаимодействия для CaptchaPage.xaml
    /// </summary>
    public partial class CaptchaPage : Page
    {
        string _correctCaptcha { get; set; }
        public bool _isCorrect { get; set; } = false;
        public CaptchaPage()
        {
            InitializeComponent();
            _correctCaptcha = Captcha.CreateCaptcha();

            CaptchaImage.Source = new BitmapImage(new Uri($@"{Directory.GetCurrentDirectory()}\Image\{_correctCaptcha}.png"));
        }

        private void CheckCaptcha_Click(object sender, RoutedEventArgs e)
        {
            if (_correctCaptcha != CaptchaTb.Text)
            {
                MessageBox.Show("Каптча введена не верно");
                NavigationService.Navigate(new Pages.CaptchaPage());
            }

            _isCorrect = true;
            if (_correctCaptcha == CaptchaTb.Text)
            {
                NavigationService.Navigate(new Pages.AvtorizPage());
            }
        }
    }
}
