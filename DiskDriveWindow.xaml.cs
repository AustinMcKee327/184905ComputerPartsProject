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
    /// Interaction logic for DiskDriveWindow.xaml
    /// </summary>
    public partial class DiskDriveWindow : Window
    {
        public DiskDriveWindow()
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
            MessageBox.Show("This Disk Drive was selected because of two things: Speed and size. Because this is a SSD type Disk Drive and not a magnetic arm type, it can access the data much faster. Instead of waiting for a physical metallic arm to move back and forth to locate the files, the SSD stores them electronically, resulting in faster loading times. It also requires less room in a computer than a metalic arm type. This means that you can store more files on less area, so there is more room for additional components if they are added in the future.");
        }

        private void DiskDriveImage_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.newegg.ca/Product/Product.aspx?Item=9SIAE508PR8514&ignorebbr=1");
        }
    }
}
