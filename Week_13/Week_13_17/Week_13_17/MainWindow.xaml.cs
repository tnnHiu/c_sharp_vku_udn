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

namespace Week_13_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += LoadData;
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            List<dynamic> cars = new List<dynamic> {
            new { CarName = "VF3", Color = "Black", Brand = "VINFAST"},
            new { CarName = "VF5", Color = "White", Brand = "VINFAST"},
            new { CarName = "VF7", Color = "Black", Brand = "VINFAST"},
            new { CarName = "VF9", Color = "White", Brand = "VINFAST"},
            };

            dgCarList.ItemsSource = cars;

        }

    }
}