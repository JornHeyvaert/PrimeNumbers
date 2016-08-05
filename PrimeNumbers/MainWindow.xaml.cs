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

namespace PrimeNumbers
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblLimit.Content = string.Format("Limit: {0}", Int32.MaxValue);
            tbHelp.Text = "A prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself.";
        }

        private void btnExecute_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool canContinue = !string.IsNullOrEmpty(txtPrimeNumber.Text);
                if (canContinue)
                {
                    int numberToTest = Convert.ToInt32(txtPrimeNumber.Text);
                    bool result = PrimeNumber.isPrime(numberToTest);
                    lblResult.Content = result ? $"{numberToTest} is a prime number" : $"{numberToTest} is not a prime number";
                }
                else
                {
                    lblResult.Content = "Please input a number!!!";
                }
            }
            catch (Exception)
            {
                lblResult.Content = "An error has occurred. Please try again!";
            }
        }
    }
}
