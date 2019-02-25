using System;
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
    /// Interaction logic for CPUWindow.xaml
    /// </summary>
    public partial class CPUWindow : Window
    {
        public CPUWindow()
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
                MessageBox.Show("I think this CPU is a good CPU because it meets the requirments of Solid Works to run efficently. Solid Works asks for minimum 3.3 GHz processing speed, of which this CPU has 3.6 GHz. An i7 core is a good type of core for dealing with the math and other things required by any CAD program. anything less than an i7 would not have the same preformance level. It also comes with a fan and cooler, to protect the CPU from overheating and causing issues with the computer. It has a LGA 1151 socket, so it connects with the Motherboard. It also only uses 65W, so it won't need a big Power Supply.");
        }

        private void Intel7CPUImage_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.newegg.ca/Product/Product.aspx?Item=N82E16819117727&ignorebbr=1");
        }
    }
}
