using BasicCalculator.util;
using BasicCalculator.Util.Math;

/*
 * Copyright (c) 2024 Rodrigo Ferreira
 * This file is part of a project (BasicCalculator) with MIT License.
 * For more information about permissions, visit the link below.
 * https://github.com/rodriaum/BasicCalculatorl?tab=MIT-1-ov-file#readme
 */

namespace BasicCalculator
{
    public partial class CalculatorForm : Form
    {
        // Bools Checkers
        public bool HasFinishedCalculation { get; set; }
        public bool AppTransparencyActive { get; set; }

        // Images
        public Image? AppBackgroundImage { get; set; }

        public CalculatorForm()
        {
            // Start Component
            InitializeComponent();

            // Starting Variables: Bools Checkers
            HasFinishedCalculation = false;
            AppTransparencyActive = false;

            // Images
            AppBackgroundImage = this.BackgroundImage;
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


        private void FirstBracketButton_Click(object sender, EventArgs e) => HandleCharacterButton(sender); // Represents "("
        private void SecondBracketButton_Click(object sender, EventArgs e) => HandleCharacterButton(sender); // Represents ")"

        /** Button Click Operator */

        private void ButtonCharAdd_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);
        private void ButtonCharSubtract_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);
        private void ButtonCharMultiply_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);
        private void ButtonCharDivide_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);

        /** Button Click Operator */

        private void ButtonDelete_Click(object? sender, EventArgs e)
        {
            Button button = deleteButton;

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
                FinishAndRefresh(true, null);
            }

        }

        private void ButtonReset_Click(object? sender, EventArgs e)
        {
            Button button = resetButton;

            if (button != null)
            {
                if (!string.IsNullOrEmpty(screenTextBox.Text))
                    FinishAndRefresh(false, null);
            }
            else
            {
                FinishAndRefresh(true, null);
            }

        }

        private void ButtonTransparency_Click(object? sender, EventArgs e)
        {
            Button button = transparencyButton;

            if (button != null)
            {
                if (!AppTransparencyActive)
                {
                    BackColor = Color.DarkGray;
                    TransparencyKey = Color.DarkGray;
                    BackgroundImage = AppBackgroundImage;
                }
                else
                {
                    BackgroundImage = null;
                    BackColor = Color.Empty;
                    TransparencyKey = Color.Empty;
                }

                AppTransparencyActive = !AppTransparencyActive;
            }

        }

        /** Button Click Result */

        private void ButtonCharResult_Click(object? sender, EventArgs e)
        {
            Button button = charResultButton;

            if (button != null)
            {
                // Before performing the calculation, we must replace mathematical operators with arithmetic operators.
                screenTextBox.Text = screenTextBox.Text
                    .Replace("×", "*")
                    .Replace("÷", "/");

                if (!string.IsNullOrEmpty(screenTextBox.Text))
                {
                    try
                    {
                        
                        screenTextBox.Text = AppUtils.DoubleToString(AppMath.EvaluateExpression(screenTextBox.Text));
                    }
                    catch (Exception ex)
                    {
                        FinishAndRefresh(true, ex.Message);
                    }
                }

            }
            else
            {
                FinishAndRefresh(true, null);
            }

        }

        /** Code Helpers */

        private void HandleCharacterButton(object? sender)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (HasFinishedCalculation)
                {
                    screenTextBox.Clear();
                    HasFinishedCalculation = false;
                }

                screenTextBox.AppendText(button.Text);
            }
            else
            {
                FinishAndRefresh(true, "");
            }
        }

        private void HandleOperatorButton(object? sender)
        {
            Button? button = sender as Button;

            if (button != null)
            {
                if (HasFinishedCalculation)
                {
                    screenTextBox.Clear();
                    HasFinishedCalculation = false;
                }

                if (!string.IsNullOrEmpty(screenTextBox.Text))
                    screenTextBox.AppendText(button.Text);

            }
            else
            {
                FinishAndRefresh(true, null);
            }

        }

        // The string "error" will only be used as a boolean parameter "isError" is true.
        private async void FinishAndRefresh(bool isError, string? error)
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

            HasFinishedCalculation = true;

            await Task.Delay(500);
        }

        private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == Keys.Enter.ToString())
                ButtonDigitNine_Click(sender, e);
        }
    }
}
