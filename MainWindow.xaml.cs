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

namespace CAL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float value = 0.0f;
        float value2 = 0.0f;

        char op = ' ';
        float result = 0.0f;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnEqualsClick(Object sender, RoutedEventArgs e)
        {
            if(!(op == ' '))
            {
                if(op == '+')
                {
                    result = value + value2;
                } 
                else if (op == '-')
                {
                    result = value - value2;
                }
                else if (op == '/')
                {
                    result = value / value2;
                }
                else if (op == '*')
                {
                    result = value * value2;
                }

                value = result;
                resultsText.Text = result.ToString();
                op = 'N';
                value2 = 0.00f;
            }
        }
        private void btnClearClick(object sender, RoutedEventArgs e)
        {
            value = 0.0f;
            value2 = 0.0f;
            op = ' ';
            result = 0.0f;
            resultsText.Text = value.ToString();
        }

        private void btnOperatorClick(object sender, RoutedEventArgs e)
        {
            op = char.Parse(((string)((Button)sender).Content));
        }

        private void btnDigitClick(object sender, RoutedEventArgs e)
        {
            if (op == ' ')
            {
                value = (value * 10) + float.Parse((string)((Button)sender).Content);
                resultsText.Text = value.ToString();
            }
            else
            {
                value2 = (value2 * 10) + float.Parse((string)((Button)sender).Content);
                resultsText.Text = value2.ToString();
            }
        }
        private void btnNegPosClick(object sender, RoutedEventArgs e)
        {
           if(op == ' ')
            {
                value = -value;
                resultsText.Text = value.ToString();

            }
            else
            {
                value2 = -value2;
                resultsText.Text = value2.ToString();

            }
        }
    }
}
