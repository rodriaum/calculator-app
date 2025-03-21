using Calculator.Math;
using Calculator.Helper;

/*
 * Copyright (c) 2024 Rodrigo Ferreira
 * This file is part of a project (Calculator) with MIT License.
 * For more information about permissions, visit the link below.
 * https://github.com/rodriaum/Calculatorl?tab=MIT-1-ov-file#readme
 */

namespace Calculator;

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

    /** Number Button */

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

    /** Bracket Buttons */


    private void FirstBracketButton_Click(object sender, EventArgs e) => HandleCharacterButton(sender); // Represents "("
    private void SecondBracketButton_Click(object sender, EventArgs e) => HandleCharacterButton(sender); // Represents ")"

    /** Click Buttons */

    private void ButtonCharAdd_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);
    private void ButtonCharSubtract_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);
    private void ButtonCharMultiply_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);
    private void ButtonCharDivide_Click(object? sender, EventArgs e) => HandleOperatorButton(sender);

    /** General Buttons */

    private void ButtonDelete_Click(object? sender, EventArgs e)
    {
        Button button = deleteButton;

        if (button == null)
        {
            FinishAndRefresh(true, null);
            return;
        }

        string text = screenTextBox.Text;

        if (!string.IsNullOrEmpty(text))
        {
            screenTextBox.Text = text.Substring(0, text.Length - 1);
        }
    }

    private void ButtonReset_Click(object? sender, EventArgs e)
    {
        Button button = resetButton;

        if (button == null)
        {
            FinishAndRefresh(true, null);
            return;
        }

        if (!string.IsNullOrEmpty(screenTextBox.Text))
            FinishAndRefresh(false, null);
    }

    private void ButtonTransparency_Click(object? sender, EventArgs e)
    {
        Button button = transparencyButton;
        if (button == null) return;

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

    private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar.ToString() == Keys.Enter.ToString())
        {
            ButtonDigitNine_Click(sender, e);
        }
    }

    /** Result Buttons */

    private void ButtonCharResult_Click(object? sender, EventArgs e)
    {
        Button button = charResultButton;

        if (button == null)
        {
            FinishAndRefresh(true, null);
            return;
        }

        // Before performing the calculation, we must replace mathematical operators with arithmetic operators.
        screenTextBox.Text = screenTextBox.Text
            .Replace("×", "*")
            .Replace("÷", "/");

        if (string.IsNullOrEmpty(screenTextBox.Text)) return;

        try
        {
            (double result, bool success) = AppMath.EvaluateExpression(screenTextBox.Text);

            if (!success)
            {
                FinishAndRefresh(true, "Expressão inválida!");
            }

            screenTextBox.Text = AppHelper.DoubleToString(result);
        }
        catch (Exception ex)
        {
            FinishAndRefresh(true, ex.Message);
        }
    }

    /** Handlers */

    private void HandleCharacterButton(object? sender)
    {
        Button? button = sender as Button;

        if (button == null)
        {
            FinishAndRefresh(true, "");
            return;
        }

        if (HasFinishedCalculation)
        {
            screenTextBox.Clear();
            HasFinishedCalculation = false;
        }

        screenTextBox.AppendText(button.Text);
    }

    private void HandleOperatorButton(object? sender)
    {
        Button? button = sender as Button;

        if (button == null)
        {
            FinishAndRefresh(true, null);
            return;
        }

        if (HasFinishedCalculation)
        {
            screenTextBox.Clear();
            HasFinishedCalculation = false;
        }

        if (!string.IsNullOrEmpty(screenTextBox.Text))
        {
            screenTextBox.AppendText(button.Text);
        }
    }

    /** Functions */

    /// <summary>
    ///  The string "error" will only be used as a boolean parameter "isError" is true.
    /// </summary>
    private async void FinishAndRefresh(bool isError, string? error = null)
    {
        if (isError)
        {
            screenTextBox.Text = (!string.IsNullOrWhiteSpace(error) ? error : "Erro");
        }
        else
        {
            screenTextBox.Clear();
        }

        HasFinishedCalculation = true;

        await Task.Delay(500);
    }
}