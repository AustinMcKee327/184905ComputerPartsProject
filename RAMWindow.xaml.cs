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
    /// Interaction logic for RAMWindow.xaml
    /// </summary>
    public partial class RAMWindow : Window
    {
        public RAMWindow()
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
                MessageBox.Show("This RAM is a good choice because there is 16GB RAM, the CAD programs should run smoothly, as per the recommendations by Solid Works. It runs at 3600 mHz. It was also origanlly designed for an Intel Motherboard so it will fit and run at the correct timings of 19-20-20.");
        }

        private void RAMImage_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.newegg.ca/Product/Product.aspx?Item=N82E16820232731");
        }
    }
}
