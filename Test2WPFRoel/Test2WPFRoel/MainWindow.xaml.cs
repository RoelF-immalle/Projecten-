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

namespace Test2WPFRoel
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
            Rectangle roderechthoek = new Rectangle();
            roderechthoek.Height = 100;
            roderechthoek.Width = 100;
            roderechthoek.Margin = new Thickness(10, 210, 0, 0);
            roderechthoek.Fill = new SolidColorBrush(Colors.Red);
            roderechthoek.StrokeThickness = 2;
            roderechthoek.Stroke = new SolidColorBrush(Colors.Yellow);

           Euhm.Children.Add(roderechthoek);
            
        }

        private void Vergrootknop_Click(object sender, RoutedEventArgs e)
        {
            Cirkel.Width = 200;
            Cirkel.Height = 200;
        }

        private void Cirkel_MouseEnter(object sender, MouseEventArgs e)
        {
            Cirkel.Stroke = new SolidColorBrush(Colors.Black);
        }

        private void Cirkel_MouseLeave(object sender, MouseEventArgs e)
        {
            Cirkel.Stroke= new SolidColorBrush(Colors.Yellow);
        }
    }
}
