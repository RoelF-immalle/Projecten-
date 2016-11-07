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

namespace Test1WPFRoel
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
            var a = 2;
            var b = 5.5;
            MessageBox.Show("De Inhoud van a = " + a + " en de inhoud van b =" + b );

        }

        private void button1_TouchEnter(object sender, TouchEventArgs e)
        {
            Infobutton.Visibility = Visibility.Collapsed;
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            Infobutton.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Hidden;
            MessageBox.Show("oeps! Er zijn geen knoppen meer beschikbaar!");

        }

        private void textBox_MouseEnter(object sender, MouseEventArgs e)
        {
            textBox.Visibility = Visibility.Collapsed;
        }
    }
    }

