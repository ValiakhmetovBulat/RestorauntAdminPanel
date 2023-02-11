using Microsoft.EntityFrameworkCore;
using Restoraunt.Data.Entities;
using RestorauntAdminPanel.Classes;
using RestorauntAdminPanel.Data;
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

namespace RestorauntAdminPanel.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPositionsPage.xaml
    /// </summary>
    public partial class MenuPositionsPage : Page
    {
        public MenuPositionsPage()
        {
            InitializeComponent();

            dgPositions.ItemsSource = DbHelper.GetContext().MenuPositions.Include(m => m.PositionType).Include(s => s.Section).ToList();
        }

        private void dgPositions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnEditPosition_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Pages.MenuPositions.AddEditPositionPage((sender as Button).DataContext as MenuPosition));
        }

        private void btnDeletePosition_Click(object sender, RoutedEventArgs e)
        {
            var positionsForRemoving = dgPositions.SelectedItems.Cast<MenuPosition>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить выделенные {positionsForRemoving.Count} элементов ?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) {
                try
                {
                    DbHelper.GetContext().MenuPositions.RemoveRange(positionsForRemoving);
                    DbHelper.GetContext().SaveChanges();
                    MessageBox.Show("Данные были успешно удалены");

                    dgPositions.ItemsSource = DbHelper.GetContext().MenuPositions.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
