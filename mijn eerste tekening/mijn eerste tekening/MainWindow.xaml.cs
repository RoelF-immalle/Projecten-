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

namespace mijn_eerste_tekening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
         
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Rectangle rect1 = new Rectangle();
            rect1.Width = 100;
            rect1.Height = 50;
            rect1.Margin = new Thickness(20, 10, 0, 0);
            rect1.Stroke = new SolidColorBrush(Colors.Pink);

        }
    }
}
