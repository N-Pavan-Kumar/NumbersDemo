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

namespace NumbersDemo
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

        private void GenerateNumbersBTN_Click(object sender, RoutedEventArgs e)
        {
            numbersTB.Text = "";
            int minNumber = int.Parse(numberMinWidthTB.Text);
            int maxNumber = int.Parse(numberMaxWidthTB.Text);
            for (int i = minNumber; i<= maxNumber; i++)
            {
                numbersTB.AppendText(i + Environment.NewLine);
            }    
        }
    }
}
