using BasicCalculator.operators;
using System.Text.RegularExpressions;

namespace BasicCalculator
{
    public partial class FormCalculator : Form
    {
        // Bools Checkers
        public bool finish { get; set; }
        public bool transparency { get; set; }
        // Character Operator
        public string charOperator { get; set; }
        // Numbers
        public double[] numbers { get; set; }
        public int index { get; set; }

        MathOperator mathOperator = new MathOperator();

        public FormCalculator()
        {
            // Start Component
            InitializeComponent();

            // Starting Variables: Bools Checkers
            finish = false;
            transparency = false;
            // Starting Variables: Character Operator
            charOperator = "";
            // Starting Variables: Numbers
            numbers = new double[99];
            index = 0;
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
                    numbers[index] = double.NaN;

                    // Checks if the deleted char is not a number, which concludes that it is an operator, and sets the variable as empty.
                    if (Regex.IsMatch(text, @"^[0-9]+$"))
                        charOperator = "";
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
                }
                else
                {
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
                    switch (charOperator)
                    {
                        case "+":
                            textBoxScreen.Text = mathOperator.Add(numbers).ToString();
                            break;

                        case "-":
                            textBoxScreen.Text = mathOperator.Subtract(numbers).ToString();
                            break;

                        case "×":
                            textBoxScreen.Text = mathOperator.Multiply(numbers).ToString();
                            break;

                        case "÷":
                            if (!numbers.Contains(0))
                                textBoxScreen.Text = mathOperator.Divide(numbers).ToString();
                            else
                                Finish(true);
                            break;
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

                numbers[index] = Convert.ToDouble(button.Text);
                index++;
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

                if (!string.IsNullOrEmpty(textBoxScreen.Text) && charOperator.Length == 0)
                {
                    textBoxScreen.AppendText(button.Text);
                    charOperator = button.Text;
                }
            }
            else
            {
                Finish(true);
            }
        }

        private void Finish(bool isError)
        {
            if (isError)
                textBoxScreen.Text = "Error";
            else
                textBoxScreen.Clear();

            finish = true;
            charOperator = "";
            numbers = new double[99];

            Thread.Sleep(1000);
        }
    }
}
