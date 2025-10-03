using CalculatorApp.DataContexts;

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
            _context.DisplayText = "";
            _context.TempDisplay = "";
            number1 = 0;
            number2 = 0;
            operation = "";
        }

        private void Backspace()
        {
            if (!CheckContextDisplayText())
            {
                return;
            }

            _context.DisplayText = _context.DisplayText.Substring(0, _context.DisplayText.Length - 1);
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

        private void SetOperation(string op)
        {
            if (!double.TryParse(_context.DisplayText, out number1) && _context.TempDisplay.Length == 0)
            {
                return;
            }

            operation = op;

            if (_context.TempDisplay.Length > 0 && _context.TempDisplay[_context.TempDisplay.Length - 1].ToString() == " ")
            {
                _context.TempDisplay = _context.TempDisplay.Substring(0, _context.TempDisplay.Length - 2) + op + " ";
                double.TryParse(_context.TempDisplay.Substring(0, _context.TempDisplay.Length - 3), out number1);
            }
            else
            {
                _context.TempDisplay = _context.DisplayText + " " + op + " ";
            }

            _context.DisplayText = "";
        }

        private void CalculateResult(string op)
        {
            if ((String.IsNullOrEmpty(operation) && op == "=") || !CheckContextDisplayText())
            {
                return;
            }

            double result = 0;

            if (op == "=" && double.TryParse(_context.DisplayText, out number2))
            {
                switch (operation)
                {
                    case "÷":
                        result = number1 / number2;
                        break;
                    case "×":
                        result = number1 * number2;
                        break;
                    case "−":
                        result = number1 - number2;
                        break;
                    case "+":
                        result = number1 + number2;
                        break;
                    case "xʸ":
                        result = Math.Pow(number1, number2);
                        break;
                    case "ʸ√x":
                        result = Math.Pow(number2, 1 / number1);
                        break;
                }
            }
            else if (double.TryParse(_context.DisplayText, out number1))
            {
                switch (op)
                {
                    case "1/x":
                        result = 1 / number1;
                        break;
                    case "ln":
                        result = Math.Log(number1);
                        break;
                    case "x²":
                        result = Math.Pow(number1, 2);
                        break;
                    case "√":
                        result = Math.Sqrt(number1);
                        break;
                    case "cos":
                        result = Math.Cos(number1 * Math.PI / 180);
                        break;
                    case "sin":
                        result = Math.Sin(number1 * Math.PI / 180);
                        break;
                    case "tan":
                        result = Math.Tan(number1 * Math.PI / 180);
                        break;
                }
            }

            _context.DisplayText = result.ToString();
            _context.TempDisplay = "";

            number1 = result;
            operation = "";
        }

        private void SetBindings()
        {
            BindingContext = _context;

            tempDisplayLabel.SetBinding(Label.TextProperty, "TempDisplay");
            displayTextLabel.SetBinding(Label.TextProperty, "DisplayText");
        }
    }
}
