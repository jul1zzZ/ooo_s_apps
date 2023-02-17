using OOO_S_App.Base;
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
    /// Логика взаимодействия для ZakazPage.xaml
    /// </summary>
    public partial class ZakazPage : Page
    {
        public ZakazPage()
        {
            InitializeComponent();

            List<Zakaz> zak = TradeEntities.GetContext().Zakazs.OrderBy(p => p.Z_Data_Dostav).ToList();
            Zakaz.ItemsSource = zak;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addzakaz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.FarmZakazPage(null));
        }

        private void deletezakaz_Click(object sender, RoutedEventArgs e)
        {
            var _selectedzakaz = Zakaz.SelectedItems.Cast<Zakaz>().ToList();

            MessageBoxResult messageBoxResult = MessageBox.Show($"Удалить {_selectedzakaz.Count()} записей???",
            "Удаление", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (messageBoxResult == MessageBoxResult.OK)
            {
                try
                {
                    Zakaz x = _selectedzakaz[0];

                    TradeEntities.GetContext().Zakazs.Remove(x);

                    TradeEntities.GetContext().SaveChanges();
                    MessageBox.Show("Записи удалены");
                    List<Zakaz> tours = TradeEntities.GetContext().Zakazs.OrderBy(p => p.Z_Data_Dostav).ToList();
                    Zakaz.ItemsSource = null;
                    Zakaz.ItemsSource = tours;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Zakaz_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void Zakaz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.FarmZakazPage((sender as Button).DataContext as Zakaz));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            List<Zakaz> zak = TradeEntities.GetContext().Zakazs.OrderBy(p => p.Z_Data_Dostav).ToList();
            Zakaz.ItemsSource = zak;
        }
    }
}
