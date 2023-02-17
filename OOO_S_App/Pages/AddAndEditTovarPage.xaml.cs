using OOO_S_App.Base;
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
using Microsoft.Win32;

namespace OOO_S_App.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddAndEditTovarPage.xaml
    /// </summary>
    public partial class AddAndEditTovarPage : Page
    {
        private Tovar _currentZakazchik = new Tovar();
        public string _photoDirectory = $@"{Directory.GetCurrentDirectory()}\Images\";

        private string _photoPath;
        private string _photoName;
        public AddAndEditTovarPage(Tovar selectedZakazchik)
        {
            InitializeComponent();
            _currentZakazchik = selectedZakazchik ?? new Tovar();
            EdCb.ItemsSource = TradeEntities.GetContext().Ed_Izm.ToList();
            ProizCb.ItemsSource = TradeEntities.GetContext().Proizvods.ToList();
            PostvCb.ItemsSource = TradeEntities.GetContext().Postavchiks.ToList();
            TypeCb.ItemsSource = TradeEntities.GetContext().Type_Tovara.ToList();
            DataContext = _currentZakazchik;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private StringBuilder CheckFileds()
        {
            StringBuilder s = new StringBuilder();

            return s;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder _error = CheckFileds();
            if (_error.Length > 0)
            {
                MessageBox.Show(_error.ToString());
                return;
            }
            try
            {
                if (_photoPath != null)
                {
                    _currentZakazchik.T_Photo = _photoName;
                    File.Copy(_photoPath, _photoDirectory + _photoName);
                }
                _currentZakazchik.T_Ed_Izm_ID = (EdCb.SelectedItem as Ed_Izm).Ed_Izm_ID;
                _currentZakazchik.T_Proizvod_ID = (ProizCb.SelectedItem as Proizvod).Proizvod_ID;
                _currentZakazchik.T_Postavshik_ID = (PostvCb.SelectedItem as Postavchik).Postavchik_ID;
                _currentZakazchik.T_Type_Tovar_ID = (TypeCb.SelectedItem as Type_Tovara).Type_Tovara_ID;
                if (_currentZakazchik.T_Artikyl_ID != null)
                {
                    TradeEntities.GetContext().Tovars.Add(_currentZakazchik);
                } 
                

                TradeEntities.GetContext().SaveChanges();
                MessageBox.Show("Запись изменена");
                NavigationService.Navigate(new Pages.AdminPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void LoadPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            if (openFileDialog.ShowDialog() == false)
            {
                return;
            }

            FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

            if (fileInfo.Length > 8 * 1024 * 1024 * 6)
            {
                MessageBox.Show("Размер фото не должен превышать 6 мб");
                return;
            }

            _photoName = Guid.NewGuid().ToString();
            _photoPath = fileInfo.FullName;
        }
    }
}
