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
using Section = Restoraunt.Data.Entities.Section;

namespace RestorauntAdminPanel.Pages.MenuPositions
{
    /// <summary>
    /// Логика взаимодействия для AddEditPositionPage.xaml
    /// </summary>
    public partial class AddEditPositionPage : Page
    {
        private MenuPosition _currentPosition;
        public AddEditPositionPage(MenuPosition selectedPosition)
        {
            InitializeComponent();

            if (selectedPosition != null)
                _currentPosition = selectedPosition;

            DataContext = _currentPosition;
            cmbPosType.ItemsSource = DbHelper.GetContext().PositionTypes.ToList();
            cmbPosSection.ItemsSource = DbHelper.GetContext().Sections.ToList();
            
           if (_currentPosition.Id != 0)
            {
                cmbPosSection.SelectedItem = _currentPosition.Section;
                cmbPosType.SelectedItem = _currentPosition.PositionType;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _currentPosition.PositionType = cmbPosType.SelectedItem as PositionType;
            _currentPosition.Section = cmbPosSection.SelectedItem as Section;

            if (_currentPosition.Id == 0)
            {
                DbHelper.GetContext().MenuPositions.Add(_currentPosition);
            }

            try
            {
                DbHelper.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                Manager.MainFrame.Navigate(new MenuPositionsPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
