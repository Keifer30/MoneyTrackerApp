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

namespace MoneyTrackerApp
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            UInt32 cashAmount = Convert.ToUInt32(CashBox.Text);
            UInt32 shortTermAmount = Convert.ToUInt32(ShortTermBox.Text);
            UInt32 midTermAmount = Convert.ToUInt32(MidtermBox.Text);
            UInt32 retirementAmount = Convert.ToUInt32(RetirementBox.Text);

            UInt32 totalAmount = 0;

            totalAmount = cashAmount + shortTermAmount + midTermAmount + retirementAmount;

            TotalBox.Text = totalAmount.ToString();
        }
    }
}
