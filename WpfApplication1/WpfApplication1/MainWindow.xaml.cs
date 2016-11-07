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

namespace WpfApplication1
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
            Ellipse oog1 = new Ellipse();
            oog1.Height = 1000;
            oog1.Width = 1000;
            oog1.Fill = new SolidColorBrush(Colors.White);
            oog1.Stroke = new SolidColorBrush(Colors.Black);
            oog1.Margin = new Thickness(50, 50, 10, 0);












            kabouter_wesley.Children.Add(oog1);
        }
    }
}
