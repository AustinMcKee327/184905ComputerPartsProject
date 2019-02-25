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
    /// Interaction logic for PowerSupplyWindow.xaml
    /// </summary>
    public partial class PowerSupplyWindow : Window
    {
        public PowerSupplyWindow()
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
                MessageBox.Show("You should buy this part for your computer because...");
        }

        private void CaseImage_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.newegg.ca/Product/Product.aspx?Item=9SIA7RD2WX2993&ignorebbr=1");
        }

        private void PowerSupplyImage_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.newegg.ca/Product/Product.aspx?Item=N82E16817438136&ignorebbr=1");
        }
    }
}
