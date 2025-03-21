/*
 * Copyright (c) 2024 Rodrigo Ferreira
 * This file is part of a project (Calculator) with MIT License.
 * For more information about permissions, visit the link below.
 * https://github.com/rodriaum/Calculatorl?tab=MIT-1-ov-file#readme
 */

using Calculator.Helper;

namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            charAddButton = new Button();
            charResultButton = new Button();
            digitThreeButton = new Button();
            digitSevenButton = new Button();
            digitEightButton = new Button();
            digitNineButton = new Button();
            digitFourButton = new Button();
            digitFiveButton = new Button();
            digitSixButton = new Button();
            charDivideButton = new Button();
            charMultiplyButton = new Button();
            charSubtractButton = new Button();
            digitZeroButton = new Button();
            digitOneButton = new Button();
            digitTwoButton = new Button();
            transparencyButton = new Button();
            deleteButton = new Button();
            resetButton = new Button();
            screenTextBox = new TextBox();
            secondBracketButton = new Button();
            firstBracketButton = new Button();
            SuspendLayout();
            // 
            // charAddButton
            // 
            charAddButton.BackColor = SystemColors.Control;
            charAddButton.FlatStyle = FlatStyle.System;
            charAddButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            charAddButton.Location = new Point(180, 234);
            charAddButton.Margin = new Padding(4, 3, 4, 3);
            charAddButton.Name = "buttonCharAdd";
            charAddButton.Size = new Size(51, 56);
            charAddButton.TabIndex = 0;
            charAddButton.Text = "+";
            charAddButton.UseVisualStyleBackColor = false;
            charAddButton.Click += ButtonCharAdd_Click;
            // 
            // charResultButton
            // 
            charResultButton.BackColor = SystemColors.HotTrack;
            charResultButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            charResultButton.ForeColor = Color.Transparent;
            charResultButton.Location = new Point(180, 298);
            charResultButton.Margin = new Padding(4, 3, 4, 3);
            charResultButton.Name = "buttonCharResult";
            charResultButton.Size = new Size(51, 56);
            charResultButton.TabIndex = 1;
            charResultButton.Text = "=";
            charResultButton.UseVisualStyleBackColor = false;
            charResultButton.Click += ButtonCharResult_Click;
            // 
            // digitThreeButton
            // 
            digitThreeButton.BackColor = SystemColors.Control;
            digitThreeButton.FlatStyle = FlatStyle.System;
            digitThreeButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            digitThreeButton.Location = new Point(124, 234);
            digitThreeButton.Margin = new Padding(4, 3, 4, 3);
            digitThreeButton.Name = "buttonDigitThree";
            digitThreeButton.Size = new Size(51, 56);
            digitThreeButton.TabIndex = 2;
            digitThreeButton.Text = "3";
            digitThreeButton.UseVisualStyleBackColor = false;
            digitThreeButton.Click += ButtonDigitThree_Click;
            // 
            // digitSevenButton
            // 
            digitSevenButton.BackColor = SystemColors.Control;
            digitSevenButton.FlatStyle = FlatStyle.System;
            digitSevenButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            digitSevenButton.Location = new Point(12, 108);
            digitSevenButton.Margin = new Padding(4, 3, 4, 3);
            digitSevenButton.Name = "buttonDigitSeven";
            digitSevenButton.Size = new Size(51, 56);
            digitSevenButton.TabIndex = 3;
            digitSevenButton.Text = "7";
            digitSevenButton.UseVisualStyleBackColor = false;
            digitSevenButton.Click += ButtonDigitSeven_Click;
            // 
            // digitEightButton
            // 
            digitEightButton.BackColor = SystemColors.Control;
            digitEightButton.FlatStyle = FlatStyle.System;
            digitEightButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            digitEightButton.Location = new Point(68, 108);
            digitEightButton.Margin = new Padding(4, 3, 4, 3);
            digitEightButton.Name = "buttonDigitEight";
            digitEightButton.Size = new Size(51, 56);
            digitEightButton.TabIndex = 4;
            digitEightButton.Text = "8";
            digitEightButton.UseVisualStyleBackColor = false;
            digitEightButton.Click += ButtonDigitEight_Click;
            // 
            // digitNineButton
            // 
            digitNineButton.BackColor = SystemColors.Control;
            digitNineButton.FlatStyle = FlatStyle.System;
            digitNineButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            digitNineButton.Location = new Point(124, 108);
            digitNineButton.Margin = new Padding(4, 3, 4, 3);
            digitNineButton.Name = "buttonDigitNine";
            digitNineButton.Size = new Size(51, 56);
            digitNineButton.TabIndex = 5;
            digitNineButton.Text = "9";
            digitNineButton.UseVisualStyleBackColor = false;
            digitNineButton.Click += ButtonDigitNine_Click;
            // 
            // digitFourButton
            // 
            digitFourButton.BackColor = SystemColors.Control;
            digitFourButton.FlatStyle = FlatStyle.System;
            digitFourButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            digitFourButton.Location = new Point(12, 171);
            digitFourButton.Margin = new Padding(4, 3, 4, 3);
            digitFourButton.Name = "buttonDigitFour";
            digitFourButton.Size = new Size(51, 56);
            digitFourButton.TabIndex = 6;
            digitFourButton.Text = "4";
            digitFourButton.UseVisualStyleBackColor = false;
            digitFourButton.Click += ButtonDigitFour_Click;
            // 
            // digitFiveButton
            // 
            digitFiveButton.BackColor = SystemColors.Control;
            digitFiveButton.FlatStyle = FlatStyle.System;
            digitFiveButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            digitFiveButton.Location = new Point(68, 171);
            digitFiveButton.Margin = new Padding(4, 3, 4, 3);
            digitFiveButton.Name = "buttonDigitFive";
            digitFiveButton.Size = new Size(51, 56);
            digitFiveButton.TabIndex = 7;
            digitFiveButton.Text = "5";
            digitFiveButton.UseVisualStyleBackColor = false;
            digitFiveButton.Click += ButtonDigitFive_Click;
            // 
            // digitSixButton
            // 
            digitSixButton.BackColor = SystemColors.Control;
            digitSixButton.FlatStyle = FlatStyle.System;
            digitSixButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            digitSixButton.Location = new Point(124, 171);
            digitSixButton.Margin = new Padding(4, 3, 4, 3);
            digitSixButton.Name = "buttonDigitSix";
            digitSixButton.Size = new Size(51, 56);
            digitSixButton.TabIndex = 8;
            digitSixButton.Text = "6";
            digitSixButton.UseVisualStyleBackColor = false;
            digitSixButton.Click += ButtonDigitSix_Click;
            // 
            // charDivideButton
            // 
            charDivideButton.BackColor = SystemColors.Control;
            charDivideButton.FlatStyle = FlatStyle.System;
            charDivideButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            charDivideButton.Location = new Point(180, 46);
            charDivideButton.Margin = new Padding(4, 3, 4, 3);
            charDivideButton.Name = "buttonCharDivide";
            charDivideButton.Size = new Size(51, 56);
            charDivideButton.TabIndex = 9;
            charDivideButton.Text = "÷";
            charDivideButton.UseVisualStyleBackColor = false;
            charDivideButton.Click += ButtonCharDivide_Click;
            // 
            // charMultiplyButton
            // 
            charMultiplyButton.BackColor = SystemColors.Control;
            charMultiplyButton.FlatStyle = FlatStyle.System;
            charMultiplyButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            charMultiplyButton.Location = new Point(180, 108);
            charMultiplyButton.Margin = new Padding(4, 3, 4, 3);
            charMultiplyButton.Name = "buttonCharMultiply";
            charMultiplyButton.Size = new Size(51, 56);
            charMultiplyButton.TabIndex = 10;
            charMultiplyButton.Text = "×";
            charMultiplyButton.UseVisualStyleBackColor = false;
            charMultiplyButton.Click += ButtonCharMultiply_Click;
            // 
            // charSubtractButton
            // 
            charSubtractButton.BackColor = SystemColors.Control;
            charSubtractButton.FlatStyle = FlatStyle.System;
            charSubtractButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            charSubtractButton.Location = new Point(180, 171);
            charSubtractButton.Margin = new Padding(4, 3, 4, 3);
            charSubtractButton.Name = "buttonCharSubtract";
            charSubtractButton.Size = new Size(51, 56);
            charSubtractButton.TabIndex = 11;
            charSubtractButton.Text = "-";
            charSubtractButton.UseVisualStyleBackColor = false;
            charSubtractButton.Click += ButtonCharSubtract_Click;
            // 
            // digitZeroButton
            // 
            digitZeroButton.BackColor = SystemColors.Control;
            digitZeroButton.FlatStyle = FlatStyle.System;
            digitZeroButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            digitZeroButton.Location = new Point(68, 298);
            digitZeroButton.Margin = new Padding(4, 3, 4, 3);
            digitZeroButton.Name = "buttonDigitZero";
            digitZeroButton.Size = new Size(51, 56);
            digitZeroButton.TabIndex = 12;
            digitZeroButton.Text = "0";
            digitZeroButton.UseVisualStyleBackColor = false;
            digitZeroButton.Click += ButtonDigitZero_Click;
            // 
            // digitOneButton
            // 
            digitOneButton.BackColor = SystemColors.Control;
            digitOneButton.FlatStyle = FlatStyle.System;
            digitOneButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            digitOneButton.Location = new Point(12, 234);
            digitOneButton.Margin = new Padding(4, 3, 4, 3);
            digitOneButton.Name = "buttonDigitOne";
            digitOneButton.Size = new Size(51, 56);
            digitOneButton.TabIndex = 13;
            digitOneButton.Text = "1";
            digitOneButton.UseVisualStyleBackColor = false;
            digitOneButton.Click += ButtonDigitOne_Click;
            // 
            // digitTwoButton
            // 
            digitTwoButton.BackColor = SystemColors.Control;
            digitTwoButton.FlatStyle = FlatStyle.System;
            digitTwoButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            digitTwoButton.Location = new Point(68, 234);
            digitTwoButton.Margin = new Padding(4, 3, 4, 3);
            digitTwoButton.Name = "buttonDigitTwo";
            digitTwoButton.Size = new Size(51, 56);
            digitTwoButton.TabIndex = 14;
            digitTwoButton.Text = "2";
            digitTwoButton.UseVisualStyleBackColor = false;
            digitTwoButton.Click += ButtonDigitTwo_Click;
            // 
            // transparencyButton
            // 
            transparencyButton.AccessibleName = "Mudar transparência";
            transparencyButton.BackColor = SystemColors.Control;
            transparencyButton.FlatStyle = FlatStyle.System;
            transparencyButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            transparencyButton.Location = new Point(124, 46);
            transparencyButton.Margin = new Padding(4, 3, 4, 3);
            transparencyButton.Name = "buttonTransparency";
            transparencyButton.Size = new Size(51, 56);
            transparencyButton.TabIndex = 15;
            transparencyButton.Text = "⌘";
            transparencyButton.UseVisualStyleBackColor = false;
            transparencyButton.Click += ButtonTransparency_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.Control;
            deleteButton.FlatStyle = FlatStyle.System;
            deleteButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            deleteButton.Location = new Point(68, 46);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "buttonDelete";
            deleteButton.Size = new Size(51, 56);
            deleteButton.TabIndex = 16;
            deleteButton.Text = "⌫";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += ButtonDelete_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = SystemColors.Control;
            resetButton.FlatStyle = FlatStyle.System;
            resetButton.Font = new Font(AppHelper.GetAppFontfamily(), 20F);
            resetButton.Location = new Point(12, 48);
            resetButton.Margin = new Padding(4, 3, 4, 3);
            resetButton.Name = "buttonReset";
            resetButton.Size = new Size(51, 56);
            resetButton.TabIndex = 17;
            resetButton.Text = "AC";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += ButtonReset_Click;
            // 
            // screenTextBox
            // 
            screenTextBox.BorderStyle = BorderStyle.FixedSingle;
            screenTextBox.Cursor = Cursors.No;
            screenTextBox.Font = new Font("Segoe UI", 15F);
            screenTextBox.Location = new Point(12, 8);
            screenTextBox.Name = "screenTextBox";
            screenTextBox.ReadOnly = true;
            screenTextBox.Size = new Size(219, 34);
            screenTextBox.TabIndex = 18;
            screenTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // secondBracketButton
            // 
            secondBracketButton.BackColor = SystemColors.Control;
            secondBracketButton.FlatStyle = FlatStyle.System;
            secondBracketButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            secondBracketButton.Location = new Point(124, 298);
            secondBracketButton.Margin = new Padding(4, 3, 4, 3);
            secondBracketButton.Name = "secondBracketButton";
            secondBracketButton.Size = new Size(51, 56);
            secondBracketButton.TabIndex = 19;
            secondBracketButton.Text = ")";
            secondBracketButton.UseVisualStyleBackColor = false;
            secondBracketButton.Click += SecondBracketButton_Click;
            // 
            // firstBracketButton
            // 
            firstBracketButton.BackColor = SystemColors.Control;
            firstBracketButton.FlatStyle = FlatStyle.System;
            firstBracketButton.Font = new Font(AppHelper.GetAppFontfamily(), 25F);
            firstBracketButton.Location = new Point(13, 298);
            firstBracketButton.Margin = new Padding(4, 3, 4, 3);
            firstBracketButton.Name = "firstBracketButton";
            firstBracketButton.Size = new Size(51, 56);
            firstBracketButton.TabIndex = 20;
            firstBracketButton.Text = "(";
            firstBracketButton.UseVisualStyleBackColor = false;
            firstBracketButton.Click += FirstBracketButton_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(244, 361);
            Controls.Add(firstBracketButton);
            Controls.Add(secondBracketButton);
            Controls.Add(digitSevenButton);
            Controls.Add(screenTextBox);
            Controls.Add(resetButton);
            Controls.Add(deleteButton);
            Controls.Add(transparencyButton);
            Controls.Add(digitTwoButton);
            Controls.Add(digitOneButton);
            Controls.Add(digitZeroButton);
            Controls.Add(charSubtractButton);
            Controls.Add(charMultiplyButton);
            Controls.Add(charDivideButton);
            Controls.Add(digitSixButton);
            Controls.Add(digitFiveButton);
            Controls.Add(digitFourButton);
            Controls.Add(digitNineButton);
            Controls.Add(digitEightButton);
            Controls.Add(digitThreeButton);
            Controls.Add(charResultButton);
            Controls.Add(charAddButton);
            Font = new Font("Segoe UI", 10F);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Básica";
            KeyPress += CalculatorForm_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button charAddButton;
        private Button charResultButton;
        private Button digitThreeButton;
        private Button digitSevenButton;
        private Button digitEightButton;
        private Button digitNineButton;
        private Button digitFourButton;
        private Button digitFiveButton;
        private Button digitSixButton;
        private Button charDivideButton;
        private Button charMultiplyButton;
        private Button charSubtractButton;
        private Button digitZeroButton;
        private Button digitOneButton;
        private Button digitTwoButton;
        private Button transparencyButton;
        private Button deleteButton;
        private Button resetButton;
        private TextBox screenTextBox;
        private Button secondBracketButton;
        private Button firstBracketButton;
    }
}