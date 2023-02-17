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
    /// Логика взаимодействия для FarmZakazPage.xaml
    /// </summary>
    public partial class FarmZakazPage : Page
    {
        public static Zakaz _zak { get; set; }
        public FarmZakazPage(Zakaz selectedep)
        {
            InitializeComponent();

            _zak = selectedep ?? new Zakaz();

            DataContext = _zak;
            CBTovar.ItemsSource = TradeEntities.GetContext().Tovars.ToList();
            CBPV.ItemsSource = TradeEntities.GetContext().Pynkt_vid.ToList();
            TBStatus.ItemsSource= TradeEntities.GetContext().Status.ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _zak.Z_Pynkt_vid_ID = (CBPV.SelectedItem as Pynkt_vid).Pynkt_vid_ID;
                _zak.Z_Sostav = (CBTovar.SelectedItem as Tovar).T_Artikyl_ID;
                _zak.Z_Status_ID = (TBStatus.SelectedItem as Status).Status_ID;
                if (_zak.Zakaz_ID == 0)
                {
                    TradeEntities.GetContext().Zakazs.Add(_zak);
                }
                TradeEntities.GetContext().SaveChanges();
                MessageBox.Show("Вы оформили заказ!");
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void TP_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Тел: 89966064526");
        }
    }
}
