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

namespace _184905ComputerPartsProject
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

        private void CPUButton_Click(object sender, RoutedEventArgs e)
        {
            CPUWindow cw = new CPUWindow();
          cw.ShowDialog();
        }

        private void MotherboardButton_Click(object sender, RoutedEventArgs e)
        {
            MotherboardWindow mbw = new MotherboardWindow();
            mbw.ShowDialog();
        }

        private void RAMButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DiskDriveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PowerSupplyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GraphicsCardButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OpticalDriveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
