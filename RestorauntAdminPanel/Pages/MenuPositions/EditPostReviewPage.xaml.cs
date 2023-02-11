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
    /// Логика взаимодействия для EditPostReviewPage.xaml
    /// </summary>
    public partial class EditPostReviewPage : Page
    {
        private Review _currentReview = new Review();
        public EditPostReviewPage(Review review)
        {
            InitializeComponent();

            _currentReview = review;
            DataContext = _currentReview;
        }

        private void btnPublishReview_Click(object sender, RoutedEventArgs e)
        {
            _currentReview.IsAccepted = true;
            DbHelper.GetContext().SaveChanges();
            MessageBox.Show("Успешно.");
        }
    }
}
