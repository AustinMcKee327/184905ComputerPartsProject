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
    /// Interaction logic for OpticalDriveWindow.xaml
    /// </summary>
    public partial class OpticalDriveWindow : Window
    {
        public OpticalDriveWindow()
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
                MessageBox.Show("A Blu-Ray Burner was important to this computer because it can be used for watching Blu-Ray films. This Blu-Ray burner also has the rewrite function, allowing for copies of Blu-Ray discs to be made, or even just to take parts of discs to help create something else. It reads Blu-Ray discs, which are becoming more and more common than floppy discs or DVDs.");
        }

        private void OpticalDriveImage_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.newegg.ca/Product/Product.aspx?Item=9SIA7RD2WW5109&ignorebbr=1");
        }
    }
}
