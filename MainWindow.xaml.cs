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

namespace _184905ComputerPartProject
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
            RAMWindow rw = new RAMWindow();
            rw.ShowDialog();
        }

        private void DiskDriveButton_Click(object sender, RoutedEventArgs e)
        {
            DiskDriveWindow ddw = new DiskDriveWindow();
            ddw.ShowDialog();
        }

        private void PowerSupplyButton_Click(object sender, RoutedEventArgs e)
        {
            PowerSupplyWindow psw = new PowerSupplyWindow();
            psw.ShowDialog();
        }

        private void GraphicsCardButton_Click(object sender, RoutedEventArgs e)
        {
            GraphicsCardWindow gcw = new GraphicsCardWindow();
            gcw.ShowDialog();
        }

        private void OpticalDriveButton_Click(object sender, RoutedEventArgs e)
        {
            OpticalDriveWindow odw = new OpticalDriveWindow();
            odw.ShowDialog();
        }  
    }
}
