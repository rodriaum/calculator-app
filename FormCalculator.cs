using BasicCalculator.operators;

namespace BasicCalculator
{
    public partial class FormCalculator : Form
    {

        public string charOperator { get; set; }
        public double[] numbers { get; set; }

        MathOperator mathOperator = new MathOperator();

        public FormCalculator()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

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

        /** Button Click Result */

        private void ButtonCharResult_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null && !string.IsNullOrEmpty(textBoxScreen.Text))
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

        /** Helpers */

        private void HandleDigitButton(object? sender)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                numbers[LastNumber(numbers)] = Convert.ToDouble(button.Text);
                textBoxScreen.AppendText(button.Text);
            }
        }

        private void HandleOperatorButton(object? sender)
        {
            Button? button = sender as Button;

            if (button != null && !string.IsNullOrEmpty(textBoxScreen.Text) && IsNotNullOrEmpty(charOperator))
            {
                textBoxScreen.AppendText(button.Text);
                charOperator = button.Text;
            }
        }

        private int LastNumber(double[] array)
        {

            for (int i = array.Length - 1; i >= 0; i--)
                return i;

            return -1;
        }

        private bool IsNotNullOrEmpty(string text) => (text != null ? text.Equals(string.Empty) : true);
    }
}
