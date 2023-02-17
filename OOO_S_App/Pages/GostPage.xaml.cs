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
    /// Логика взаимодействия для GostPage.xaml
    /// </summary>
    public partial class GostPage : Page
    {
        public GostPage()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AvtorizPage());
        }

        private void farm_zakaz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.FarmZakazPage(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                TradeEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                LVTovar.ItemsSource = TradeEntities.GetContext().Tovars.OrderBy(p => p.T_Artikyl_ID).ToList();
            }
        }

        private void TBP_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }

        private void CBS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            var currentProduct = TradeEntities.GetContext().Tovars.OrderBy(p => p.T_Spisok_ID).ToList();
            currentProduct = currentProduct.Where(p => p.T_Spisok_ID.ToLower().Contains(TBP.Text.ToLower())).ToList();

            if (CBS.SelectedIndex >= 0)
            {
                if (CBS.SelectedIndex == 0)
                {
                    currentProduct = currentProduct.OrderBy(p => p.T_Stoimost).ToList();
                }
                if (CBS.SelectedIndex == 1)
                {
                    currentProduct = currentProduct.OrderByDescending(p => p.T_Stoimost).ToList();
                }
            }

            LVTovar.ItemsSource = currentProduct;
        }

        private void CBBEB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData1();
        }

        private void UpdateData1()
        {
            var currentProduct = TradeEntities.GetContext().Tovars.OrderBy(p => p.T_Spisok_ID).ToList();
            currentProduct = currentProduct.Where(p => p.T_Spisok_ID.ToLower().Contains(TBP.Text.ToLower())).ToList();

            if (CBS.SelectedIndex >= 0)
            {
                if (CBS.SelectedIndex == 0)
                {
                    currentProduct = currentProduct.OrderBy(p => p.T_Stoimost).ToList();
                }
                if (CBS.SelectedIndex == 1)
                {
                    currentProduct = currentProduct.OrderByDescending(p => p.T_Stoimost).ToList();
                }
            }
            if (CBBEB.SelectedIndex > 0)
            {
                int a = 0;
                int b = 0;
                switch (CBBEB.SelectedIndex)
                {
                    case 1:
                        a = 0;
                        b = 10;
                        break;

                    case 2:
                        a = 11;
                        b = 15;
                        break;

                    case 3:
                        a = 16;
                        b = 100;
                        break;
                }

                currentProduct = currentProduct.Where(p => p.T_Destv_Skidka > a && p.T_Destv_Skidka <= b).ToList();
            }
            LVTovar.ItemsSource = currentProduct;
        }
    }
}
