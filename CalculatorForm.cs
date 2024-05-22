using BasicCalculator.util;

namespace BasicCalculator
{
    public partial class CalculatorForm : Form
    {
        // Bools Checkers
        public bool finish { get; set; }
        public bool transparency { get; set; }

        // Character Operator
        public char charOperator { get; set; }

        // Images
        public Image? backgroundImage { get; set; }

        public CalculatorForm()
        {
            // Start Component
            InitializeComponent();

            // Starting Variables: Bools Checkers
            finish = false;
            transparency = false;

            // Starting Variables: Character Operator
            charOperator = Util.EmptyChar();

            // Images
            backgroundImage = this.BackgroundImage;
        }

        /** Button Click Number */

        private void ButtonDigitNine_Click(object? sender, EventArgs e) => HandleDigitButton(sender);
        private void ButtonDigitEight_Click(object? sender, EventArgs e) => HandleDigitButton(sender);
        private void ButtonDigitSeven_Click(object? sender, EventArgs e) => HandleDigitButton(sender);
        private void ButtonDigitSix_Click(object? sender, EventArgs e) => HandleDigitButton(sender);
        private void ButtonDigitFive_Click(object? sender, EventArgs e) => HandleDigitButton(sender);
        private void ButtonDigitFour_Click(object? sender, EventArgs e) => HandleDigitButton(sender);
        private void ButtonDigitThree_Click(object? sender, EventArgs e) => HandleDigitButton(sender);
        private void ButtonDigitTwo_Click(object? sender, EventArgs e) => HandleDigitButton(sender);
        private void ButtonDigitOne_Click(object? sender, EventArgs e) => HandleDigitButton(sender);
        private void ButtonDigitZero_Click(object? sender, EventArgs e) => HandleDigitButton(sender);

        /** Button Click Operator */

        private void ButtonCharAdd_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);
        private void ButtonCharSubtract_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);
        private void ButtonCharMultiply_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);
        private void ButtonCharDivide_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);

        /** Button Click Operator */

        private void ButtonDelete_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                string text = textBoxScreen.Text;

                if (!string.IsNullOrEmpty(text))
                {
                    textBoxScreen.Text = text.Substring(0, text.Length - 1);

                    // Portuguese: Verifica se o caractere excluído não é um número, o que conclui que é um operador, e define a variável como vazia.
                    // English: Checks if the deleted char is not a number, which concludes that it is an operator, and sets the variable as empty.
                    if (!Util.IsNumber(text))
                    {
                        charOperator = Util.EmptyChar();
                    }
                }

            }
            else
            {
                Finish(true);
            }
        }

        private void ButtonReset_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (!string.IsNullOrEmpty(textBoxScreen.Text))
                    Finish(false);
            }
            else
            {
                Finish(true);
            }
        }

        private void ButtonTransparency_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (!transparency)
                {
                    BackColor = Color.DarkGray;
                    TransparencyKey = Color.DarkGray;
                    BackgroundImage = backgroundImage;
                }
                else
                {
                    BackgroundImage = null;
                    BackColor = Color.Empty;
                    TransparencyKey = Color.Empty;
                }

                transparency = !transparency;
            }
        }

        /** Button Click Result */

        private void ButtonCharResult_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (!string.IsNullOrEmpty(textBoxScreen.Text))
                {
                    string[] numbers = textBoxScreen.Text.Split(charOperator);

                    if (numbers.Length == 2)
                    {
                        double.TryParse(numbers[0], out double a);
                        double.TryParse(numbers[1], out double b);

                        switch (charOperator)
                        {
                            case '+':
                                textBoxScreen.Text = Util.DoubleToString(a + b);
                                break;

                            case '-':
                                textBoxScreen.Text = Util.DoubleToString(a - b);
                                break;

                            case '×':
                                textBoxScreen.Text = Util.DoubleToString(a * b);
                                break;

                            case '÷':
                                if (a != 0 || b != 0)
                                {
                                    textBoxScreen.Text = Util.DoubleToString(a / b);
                                }
                                else
                                {
                                    Finish(true);
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                Finish(true);
            }
        }

        /** Code Helpers */

        private void HandleDigitButton(object? sender)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (finish)
                {
                    textBoxScreen.Clear();
                    finish = false;
                }

                textBoxScreen.AppendText(button.Text);
            }
            else
            {
                Finish(true);
            }
        }

        private void HandleOperatorButton(object? sender)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (finish)
                {
                    textBoxScreen.Clear();
                    finish = false;
                }

                if (!string.IsNullOrEmpty(textBoxScreen.Text) && charOperator.Equals(Util.EmptyChar()))
                {
                    textBoxScreen.AppendText(button.Text);
                    charOperator = Convert.ToChar(button.Text);
                }
            }
            else
            {
                Finish(true);
            }
        }

        private async void Finish(bool isError)
        {
            if (isError)
                textBoxScreen.Text = "Error";
            else
                textBoxScreen.Clear();

            finish = true;
            charOperator = Util.EmptyChar();

            await Task.Delay(500);
        }
    }
}
