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

namespace kabouter_wesley2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse ellipse;

        public MainWindow()
        {
            InitializeComponent();

            slider.Minimum = 0;
            slider.Maximum = ok.Height;

            slider2.Minimum = 0;
            slider2.Maximum = ok.Height;

            loemp.Content = Convert.ToString(slider.Value);
            loemp2.Content = Convert.ToString(slider2.Value);

            CreateEline();
        }
        private void slider_verandert(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int vertical = Convert.ToInt32(slider.Value);
            loemp.Content = Convert.ToString(vertical);
            updateEline();
        }
        private void slider2_verandert(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int horizontal = Convert.ToInt32(slider2.Value);
            loemp2.Content = Convert.ToString(horizontal);
            updateEline();
        }
        private void CreateEline()
        {
            Eline = new Ellipse();
            Eline.Width = slider.Value;
            Eline.Height = slider2.Value;
            Eline.Stroke = new SolidColorBrush(Colors.Yellow);
            Eline.Margin = new Thickness(0, 0, 0, 0 );

            ok.Children.Add(Eline);
        }
        private void updateEline()
        {
            Eline.Width = slider.Value;
            Eline.Height = slider2.Value;
        }
        }
    }

