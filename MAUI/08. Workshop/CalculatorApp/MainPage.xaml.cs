using CalculatorApp.DataContexts;
using Microsoft.Maui.Controls;
using System;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        private MainPageContext _context;

        private double number1 = 0;
        private double number2 = 0;
        private string operation = "";

        private HashSet<string> calculations;
        private HashSet<string> operations;

        public MainPage(MainPageContext context)
        {
            _context = context;

            InitializeComponent();

            calculations = new HashSet<string>() { "=", "1/x", "ln", "x²", "√", "cos", "sin", "tan" };
            operations = new HashSet<string>() { "÷", "×", "−", "+", "xʸ", "ʸ√x" };
        }

        private void Button_Click(object sender, EventArgs e)
        { }

    }
}
