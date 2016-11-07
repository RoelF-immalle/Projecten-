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

namespace Dehemel
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

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Rectangle rect1 = new Rectangle();
            rect1.Width = 50;
            rect1.Height = 20;
            rect1.Margin = new Thickness (50, 50, 0, 0)  ;
            rect1.Stroke = new SolidColorBrush(Colors.Red);
            zwetzak.Children.Add(rect1);

        }
    }
}
