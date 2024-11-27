using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week_13_18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        ManageCategories manageCategories = new ManageCategories();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCategory();
        }
        private void LoadCategory()
        {
            lvCategories.ItemsSource = manageCategories.GetCategories();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var category = new Category
                {
                    CategoryName = txtCategoryName.Text
                };
                manageCategories.InsertCategory(category);
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var category = new Category
                {
                    CategoryId = Convert.ToInt32(txtCategoryId.Text),
                    CategoryName = txtCategoryName.Text
                };
                manageCategories.UpdateCategory(category);
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var category = new Category
                {
                    CategoryId = Convert.ToInt32(txtCategoryId.Text)
                };
                manageCategories.DeleteCategory(category);
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}