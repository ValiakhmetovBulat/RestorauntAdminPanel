using Restoraunt.Data.Entities;
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

namespace RestorauntAdminPanel.Pages.MenuPositions
{
    /// <summary>
    /// Логика взаимодействия для ReviewsPage.xaml
    /// </summary>
    public partial class ReviewsPage : Page
    {
        public ReviewsPage()
        {
            InitializeComponent();
            lvReviews.ItemsSource = DbHelper.GetContext().Reviews.ToList();
        }

        private void btnOpenReview_Click(object sender, RoutedEventArgs e)
        {
            mfCurrentReview.Navigate(new EditPostReviewPage((sender as Button).DataContext as Review));
        }
    }
}
