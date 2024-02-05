using System.Drawing;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Administrator\\source\\repos\\WpfApp2\\WpfApp2/main_bk.png"));

        }
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}