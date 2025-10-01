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
            SetBindings();

            calculations = new HashSet<string>() { "=", "1/x", "ln", "x²", "√", "cos", "sin", "tan" };
            operations = new HashSet<string>() { "÷", "×", "−", "+", "xʸ", "ʸ√x" };
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string text = button.Text;

            if (calculations.Contains(text))
            {
                CalculateResult(text);
            }
            else if (operations.Contains(text))
            {
                SetOperation(text);
            }
            else
            {
                switch (text)
                {
                    case "+/-":
                        ChangeSign();
                        break;
                    case "del":
                        Backspace();
                        break;
                    case "C":
                        ClearDisplay();
                        break;
                    default:
                        AppendToDisplay(text);
                        break;
                }
            }
        }

        private void AppendToDisplay(string text)
        {
            if (text == "." && (CheckContextDisplayText() && _context.DisplayText.Contains(".") || !CheckContextDisplayText()))
            {
                return;
            }

            _context.DisplayText += text;
        }

        private bool CheckContextDisplayText()
        {
            return _context.DisplayText.Length > 0;
        }

        private void ClearDisplay()
        {
            throw new NotImplementedException();
        }

        private void Backspace()
        {
            throw new NotImplementedException();
        }

        private void ChangeSign()
        {
            if (!CheckContextDisplayText())
            {
                return;
            }

            _context.DisplayText = _context.DisplayText.First().ToString() == "-"
                ? _context.DisplayText.Substring(1)
                : "-" + _context.DisplayText;
        }

        private void SetOperation(string text)
        {
            throw new NotImplementedException();
        }

        private void CalculateResult(string text)
        {
            throw new NotImplementedException();
        }

        private void SetBindings()
        {
            BindingContext = _context;

            tempDisplayLabel.SetBinding(Label.TextProperty, "TempDisplay");
            displayTextLabel.SetBinding(Label.TextProperty, "DisplayText");
        }
    }
}
