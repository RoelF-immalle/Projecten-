﻿using System;
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

namespace ExperimentjeH4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MessageBox.Show("5" + "5" + 5 + 5);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("5" + "5" + 5 + 5);
            MessageBox.Show("5" + "5" + (5 + 5));
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("heylaheylaheylahowlala");
        }
    }
}
