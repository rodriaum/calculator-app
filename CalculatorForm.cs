using BasicCalculator.util;

namespace BasicCalculator
{
    public partial class CalculatorForm : Form
    {
        // Bools Checkers
        public bool finish { get; set; }
        public bool transparency { get; set; }

        // Images
        public Image? backgroundImage { get; set; }

        public CalculatorForm()
        {
            // Start Component
            InitializeComponent();

            // Starting Variables: Bools Checkers
            finish = false;
            transparency = false;

            // Images
            backgroundImage = this.BackgroundImage;
        }

        /** Button Click Number */

        private void ButtonDigitNine_Click(object? sender, EventArgs e) => HandleCharacterButton(sender);
        private void ButtonDigitEight_Click(object? sender, EventArgs e) => HandleCharacterButton(sender);
        private void ButtonDigitSeven_Click(object? sender, EventArgs e) => HandleCharacterButton(sender);
        private void ButtonDigitSix_Click(object? sender, EventArgs e) => HandleCharacterButton(sender);
        private void ButtonDigitFive_Click(object? sender, EventArgs e) => HandleCharacterButton(sender);
        private void ButtonDigitFour_Click(object? sender, EventArgs e) => HandleCharacterButton(sender);
        private void ButtonDigitThree_Click(object? sender, EventArgs e) => HandleCharacterButton(sender);
        private void ButtonDigitTwo_Click(object? sender, EventArgs e) => HandleCharacterButton(sender);
        private void ButtonDigitOne_Click(object? sender, EventArgs e) => HandleCharacterButton(sender);
        private void ButtonDigitZero_Click(object? sender, EventArgs e) => HandleCharacterButton(sender);

        /** Button Click Bracket */


        private void firstBracketButton_Click(object sender, EventArgs e) => HandleCharacterButton(sender); // Represents "("
        private void secondBracketButton_Click(object sender, EventArgs e) => HandleCharacterButton(sender); // Represents ")"

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
                string text = screenTextBox.Text;

                if (!string.IsNullOrEmpty(text))
                {
                    screenTextBox.Text = text.Substring(0, text.Length - 1);
                }

            }
            else
            {
                Finish(true, null);
            }

        }

        private void ButtonReset_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (!string.IsNullOrEmpty(screenTextBox.Text))
                    Finish(false, null);
            }
            else
            {
                Finish(true, null);
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
                // Before performing the calculation, we must replace mathematical operators with arithmetic operators.
                screenTextBox.Text = screenTextBox.Text
                    .Replace("", "")
                    .Replace("÷", "/");

                if (!string.IsNullOrEmpty(screenTextBox.Text))
                {
                    try
                    {
                        screenTextBox.Text = Util.DoubleToString(Util.EvaluateExpression(screenTextBox.Text));
                    }
                    catch (Exception ex)
                    {
                        Finish(true, ex.Message);
                    }
                }

            }
            else
            {
                Finish(true, null);
            }

        }

        /** Code Helpers */

        private void HandleCharacterButton(object? sender)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (finish)
                {
                    screenTextBox.Clear();
                    finish = false;
                }

                screenTextBox.AppendText(button.Text);
            }
            else
            {
                Finish(true, "");
            }
        }

        private void HandleOperatorButton(object? sender)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (finish)
                {
                    screenTextBox.Clear();
                    finish = false;
                }

                if (!string.IsNullOrEmpty(screenTextBox.Text))
                    screenTextBox.AppendText(button.Text);

            }
            else
            {
                Finish(true, null);
            }

        }

        // The string "error" will only be used as a boolean parameter "isError" is true.
        private async void Finish(bool isError, string? error)
        {
            if (isError)
            {

                if (!string.IsNullOrEmpty(error))
                {
                    screenTextBox.Text = error;
                }
                else
                {
                    screenTextBox.Text = "Error";
                }

            }
            else
            {
                screenTextBox.Clear();
            }

            finish = true;

            await Task.Delay(500);
        }

    }
}
