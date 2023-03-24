using System;
using System.Windows;
using System.Windows.Controls;

namespace SimpleCalculator
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

        // event handler Button_Click_1:
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            tb.Text += b.Content.ToString();
        }

        // event handler Result_click:
        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception ex)
            {
                tb.Text = "Error!";
            }
        }

        // perform calculation and display result in the TextBox:
        private void result()
        {
            String op; // operation
            int iOp = 0; // operation index

            // get the operation index:
            if (tb.Text.Contains("+"))
            {
                iOp = tb.Text.IndexOf("+");
            }
            else if (tb.Text.Contains("-"))
            {
                iOp = tb.Text.IndexOf("-");
            }
            else if (tb.Text.Contains("*"))
            {
                iOp = tb.Text.IndexOf("*");
            }
            else if (tb.Text.Contains("/"))
            {
                iOp = tb.Text.IndexOf("/");
            }
            else
            {
                // error - unknown operation
            }

            op = tb.Text.Substring(iOp, 1); // get operation

            // get both values for the math operation:
            double op1 = Convert.ToDouble(tb.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(tb.Text.Substring(iOp + 1, tb.Text.Length - iOp - 1));

            // perform calculation and display result:
            if (op == "+")
            {
                tb.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                tb.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                tb.Text += "=" + (op1 * op2);
            }
            else // op = "/"
            {
                tb.Text += "=" + (op1 / op2);
            }
        }

        // event handler Off_Click_1:
        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // close the app
        }

        // event handler Del_Click:
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = ""; // clear the TextBox
        }

        // event handler R_Click:
        private void R_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length > 0)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1); // clear last character
            }
        }
    }
}
