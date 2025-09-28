using System;
using Microsoft.Maui.Controls;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        private double number1 = 0;
        private double number2 = 0;
        private string operation = "";

        private HashSet<string> calculations;
        private HashSet<string> operations;

        public MainPage()
        {
            InitializeComponent();

            calculations = new HashSet<string>() { "=", "1/x", "ln", "x²", "√", "cos", "sin", "tan" };
            operations = new HashSet<string>() { "÷", "×", "−", "+", "xʸ", "ʸ√x" };
        }

        private void Button_Click(object sender, EventArgs e)
        { }

    }
}
