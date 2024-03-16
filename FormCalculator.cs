using BasicCalculator.operators;
using System.Runtime.Intrinsics.X86;

namespace BasicCalculator
{
    public partial class FormCalculator : Form
    {

        public bool finish { get; set; }
        public string charOperator { get; set; }
        public double[] numbers { get; set; }

        MathOperator mathOperator = new MathOperator();

        public FormCalculator()
        {
            // Start Component
            InitializeComponent();

            // Form Color
            BackColor = Color.DarkGray;
            TransparencyKey = Color.DarkGray;

            // Starting Variables
            finish = false;
            charOperator = "";
            numbers = new double[99];

            // Results
            buttonCharResult.Click += ButtonCharResult_Click;

            // Operators

            buttonCharAdd.Click += ButtonCharAdd_Click;
            buttonCharSubtract.Click += ButtonCharSubtract_Click;
            buttonCharMultiply.Click += ButtonCharMultiply_Click;
            buttonCharDivide.Click += ButtonCharDivide_Click;

            // Numbers
            buttonDigitZero.Click += ButtonDigitZero_Click;
            buttonDigitOne.Click += ButtonDigitOne_Click;
            buttonDigitTwo.Click += ButtonDigitTwo_Click;
            buttonDigitThree.Click += ButtonDigitThree_Click;
            buttonDigitFour.Click += ButtonDigitFour_Click;
            buttonDigitFive.Click += ButtonDigitFive_Click;
            buttonDigitSix.Click += ButtonDigitSix_Click;
            buttonDigitSeven.Click += ButtonDigitSeven_Click;
            buttonDigitEight.Click += ButtonDigitEight_Click;
            buttonDigitNine.Click += ButtonDigitNine_Click;

            // Calculator Default Buttons
            buttonDelete.Click += ButtonDelete_Click;
            buttonReset.Click += ButtonReset_Click;

            // Buttons Modifications
            buttonCharResult.FlatStyle = FlatStyle.Popup;
            buttonCharResult.ForeColor = Color.Transparent;
            buttonCharResult.BackColor = Color.FromArgb(150, Color.Purple);
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
                if (!string.IsNullOrEmpty(textBoxScreen.Text))
                {
                textBoxScreen.Text = textBoxScreen.Text.Substring(0, textBoxScreen.Text.Length - 1);
                numbers[LastNumberIndex(numbers)] = double.NaN;
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

        /** Button Click Result */

        private void ButtonCharResult_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (!string.IsNullOrEmpty(textBoxScreen.Text))
                {
                    double total = -1;

                    switch (charOperator)
                    {
                        case "+":
                            total = mathOperator.Add(numbers);
                            break;

                        case "-":
                            total = mathOperator.Subtract(numbers);
                            break;

                        case "×":
                            total = mathOperator.Multiply(numbers);
                            break;

                        case "÷":
                            total = mathOperator.Divide(numbers);
                            break;
                    }

                    textBoxScreen.Text = total.ToString();
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

                numbers[LastNumberIndex(numbers)] = Convert.ToDouble(button.Text);
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
                textBoxScreen.Text = "ERROR!";
                finish = true;
            }
        }

        private void Finish(bool error)
        {
            if (error)
                textBoxScreen.Text = "ERROR!";
            else
                textBoxScreen.Clear();

            finish = true;
            charOperator = "";
            numbers = new double[99];
        }

        private int LastNumberIndex(double[] array)
        {

            for (int i = array.Length - 1; i >= 0; i--)
                return i;

            return -1;
        }
    }
}
