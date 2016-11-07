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

namespace mijn_koekendooshuisje
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
            Rectangle VAmuur = new Rectangle();
            VAmuur.Width = 100;
            VAmuur.Height = 160;
            VAmuur.Margin = new Thickness(20, 80, 0, 0);
            VAmuur.Stroke = new SolidColorBrush(Colors.Red);

            Line zamuur1 = new Line();
            zamuur1.X1 = 40;  zamuur1.Y1 = 20;
            zamuur1.X2 = -21;  zamuur1.Y2 = -35;
            zamuur1.Margin = new Thickness(-20, 60, 0, 0);
            zamuur1.Stroke = new SolidColorBrush(Colors.Gray);
          


            Line zamuur2 = new Line();
            zamuur2.X1 = 40; zamuur2.Y1 = 20;
            zamuur2.X2 = -21; zamuur2.Y2 = -35;
            zamuur2.Margin = new Thickness(-20, 220, 0, 0);
            zamuur2.Stroke = new SolidColorBrush(Colors.Red);

            Line zamuur3 = new Line();
            zamuur3.X1 = 10; zamuur3.Y1 = 160;
            zamuur3.X2 = 10; zamuur3.Y2 = 0;
            zamuur3.Margin = new Thickness(-50, 28, 0, 0);
            zamuur3.Stroke = new SolidColorBrush(Colors.Red);

            Line dakL1 = new Line();
            dakL1.X1 = 20; dakL1.Y1 = 80;
            dakL1.X2 = 70; dakL1.Y2 = 10;
            dakL1.Stroke = new SolidColorBrush(Colors.Gray);

            Line dakL2 = new Line();
            dakL2.X1 = 70; dakL2.Y1 = 10;
            dakL2.X2 = 120; dakL2.Y2 = 80;
            dakL2.Stroke = new SolidColorBrush(Colors.Gray);

            Line dakL3 = new Line();
            dakL3.X1 = 20; dakL3.Y1 = 80;
            dakL3.X2 = 20; dakL3.Y2 = 80;
            dakL3.Stroke = new SolidColorBrush(Colors.Gray);

            Line dakL4 = new Line();
            dakL4.X1 = 40; dakL4.Y1 = 20;
            dakL4.X2 = -21; dakL4.Y2 = -35;
            dakL4.Margin = new Thickness(30, -10, 0, 0);
            dakL4.Stroke = new SolidColorBrush(Colors.Gray);

            Line dakL5 = new Line();
            dakL5.X1 = 20; dakL5.Y1 = 80;
            dakL5.X2 = 70; dakL5.Y2 = 10;
            dakL5.Margin = new Thickness(-60, -50, 0, 0);
            dakL5.Stroke = new SolidColorBrush(Colors.Gray);

            Rectangle deur = new Rectangle();
            deur.Width = 30;
            deur.Height = 50;
            deur.Margin = new Thickness(50, 190, 10, 0);
            deur.Stroke = new SolidColorBrush(Colors.Black);

            Rectangle raam1 = new Rectangle();
            raam1.Width = 30;
            raam1.Height = 30;
            raam1.Margin = new Thickness(30, 130, 10, 0);
            raam1.Stroke = new SolidColorBrush(Colors.Black);

            Rectangle raam = new Rectangle();
            raam.Width = 30;
            raam.Height = 30;
            raam.Margin = new Thickness(75, 130, 10, 0);
            raam.Stroke = new SolidColorBrush(Colors.Black);

            Line gras1 = new Line();
            gras1.X1 = 0; gras1.Y1 = 10;
            gras1.X2 = 150; gras1.Y2 = 10;
            gras1.Margin = new Thickness(120, 230, 0, 0);
            gras1.Stroke = new SolidColorBrush(Colors.LawnGreen);

            Line gras2 = new Line();
            gras2.X1 = 0; gras2.Y1 = 100;
            gras2.X1 = 100; gras2.Y2 = 100;
            gras2.Margin = new Thickness(120, 80, 10, 0);
            gras2.Stroke = new SolidColorBrush(Colors.LawnGreen);

            Line gras3 = new Line();
            gras3.X1 = 55; gras3.Y1 = 20;
            gras3.X2 = -21; gras3.Y2 = -35;
            gras3.Margin = new Thickness(230, 220, 0, 0);
            gras3.Stroke = new SolidColorBrush(Colors.LawnGreen);





            mijn_huisje.Children.Add(VAmuur);
            mijn_huisje.Children.Add(zamuur1);
            mijn_huisje.Children.Add(zamuur2);
            mijn_huisje.Children.Add(zamuur3);
            mijn_huisje.Children.Add(dakL1);
            mijn_huisje.Children.Add(dakL2);
            mijn_huisje.Children.Add(dakL3);
            mijn_huisje.Children.Add(dakL4);
            mijn_huisje.Children.Add(deur);
            mijn_huisje.Children.Add(raam1);
            mijn_huisje.Children.Add(raam);
            mijn_huisje.Children.Add(gras1);
            mijn_huisje.Children.Add(dakL5);
            mijn_huisje.Children.Add(gras2);
            mijn_huisje.Children.Add(gras3);



        }
    }
}
