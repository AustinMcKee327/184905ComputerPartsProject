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
    /// Interaction logic for GraphicsCardWindow.xaml
    /// </summary>
    public partial class GraphicsCardWindow : Window
    {
        public GraphicsCardWindow()
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
                MessageBox.Show("I chose this Graphics Card because it was one of the suggested graphics cards to run Solid Works with. Solid Works was the most demanding program in order to get optimal preformance. The Solid Works website tested that this graphics card could run all versions of SolidWorks without problem. It was also praised on NewEgg as the one of the best for CAD programs. A good Graphics Card usually means it is going to use a lot of power, so a bigger Power Supply may be required.");
        }

        private void GraphicsCardImage_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.newegg.ca/Product/Product.aspx?Item=9SIAFA46MJ2357&ignorebbr=1");
        }
    }
}
