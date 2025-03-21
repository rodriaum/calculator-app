/*
 * Copyright (c) 2024 Rodrigo Ferreira
 * This file is part of a project (Calculator) with MIT License.
 * For more information about permissions, visit the link below.
 * https://github.com/rodriaum/Calculatorl?tab=MIT-1-ov-file#readme
 */

namespace Calculator.Math;

public class AppMath
{
    /// <summary>
    /// Evaluates a mathematical expression string and handles large number calculations.
    /// </summary>
    /// <param name="expression">The mathematical expression to evaluate (e.g. "123*456").</param>
    /// <returns>True if the expression was evaluated successfully; otherwise, false.</returns>
    public static (double, bool) EvaluateExpression(string expression)
    {
        if (string.IsNullOrEmpty(expression))
            return (double.NaN, false);

        // Parse and evaluate the expression manually for large numbers
        try
        {
            // For simple multiplication of two large numbers
            if (expression.Contains("*") && !expression.Contains("+") && !expression.Contains("-") && !expression.Contains("/"))
            {
                string[] parts = expression.Replace(" ", "").Split('*');

                if (parts.Length == 2)
                {
                    double num1 = double.Parse(parts[0]);
                    double num2 = double.Parse(parts[1]);
                    return ((num1 * num2), true);
                }
            }

            // Fall back to DataTable.Compute for other expressions
            return (Convert.ToDouble(new System.Data.DataTable().Compute(expression.Replace(" ", ""), null)), true);
        }
        catch (Exception ex)
        {
            // Handle exceptions or return NaN
            Console.WriteLine($"Error evaluating expression: {ex.Message}");
            return (double.NaN, false);
        }
    }
}