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

namespace gittaak1_Kaan
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

        private void Image_MouseEnterRed(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Red;
        }

        private void Image_MouseEnterYellow(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Yellow;
        }

        private void Image_MouseEnterBlue(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Blue;
        }

        private void Image_MouseEnterGreen(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Green;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.LightGray;
        }

        private void MouseDownRed(object sender, MouseButtonEventArgs e)
        {
            ColorLabel.Text = "Rood: #FF0000";

        }
        // green image
        private void MouseDownGreen(object sender, MouseButtonEventArgs e)
        {
            ColorLabel.Text = "Groen: #008000";

        }
        // Yellow image
        private void MouseDownYellow(object sender, MouseButtonEventArgs e)
        {
            ColorLabel.Text = "Geel: #FFFF00";

        }
        // blue
        private void MouseDownBlue(object sender, MouseButtonEventArgs e)
        {
            ColorLabel.Text = "Blauw: #0000FF";

        }




    }
}