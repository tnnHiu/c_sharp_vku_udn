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

namespace Week_13_15
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


        private void btnCheckAllItems_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (CheckBox item in lst.Items)
            {
                if (item.IsChecked == true)
                {
                    stringBuilder.Append(
                        item.Content.ToString() + " is checked.\r\n");
                }
            }
            txtSelection.Text = stringBuilder.ToString();
        }
    }
}