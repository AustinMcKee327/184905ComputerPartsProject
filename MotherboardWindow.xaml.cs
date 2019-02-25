﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace _184905ComputerPartProject
{
    /// <summary>
    /// Interaction logic for MotherboardWindow.xaml
    /// </summary>
    public partial class MotherboardWindow : Window
    {
        public MotherboardWindow()
        {
            InitializeComponent();
        }

        private void ClosingButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void ExplanationButton_Click(object sender, RoutedEventArgs e)
        {
            //ExplanationButton.Content = 
                MessageBox.Show("The Motherboard is a connector of all the pieces of the computer. It holds the CPU, RAM and Graphics Card. It has a LGA 1151 cable to connect to the CPU correctly. It has four RAM slots, in case at some point you need to add additional RAM past the 16GB included in the RAM section.");
        }

        private void MotherboardImage_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.newegg.ca/Product/Product.aspx?Item=9SIA7BB3KE5015&ignorebbr=1");
        }
    }
}
