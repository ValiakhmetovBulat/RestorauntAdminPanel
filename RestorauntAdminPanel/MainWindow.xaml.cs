using Microsoft.EntityFrameworkCore;
using RestorauntAdminPanel.Classes;
using RestorauntAdminPanel.Data;
using RestorauntAdminPanel.Pages.MenuPositions;
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

namespace RestorauntAdminPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = mf;
            Manager.MainFrame.Navigate(new Pages.MenuPositionsPage());
            
        }

        private void dgPositions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnEditPosition_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGoToReviews_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ReviewsPage());
        }
    }
}
