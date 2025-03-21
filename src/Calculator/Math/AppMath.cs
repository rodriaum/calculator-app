﻿/*
 * Copyright (c) 2024 Rodrigo Ferreira
 * This file is part of a project (Calculator) with MIT License.
 * For more information about permissions, visit the link below.
 * https://github.com/rodriaum/Calculatorl?tab=MIT-1-ov-file#readme
 */

namespace Calculator.Math;

public class AppMath
{
    public static double EvaluateExpression(string expression)
    {
        return !string.IsNullOrEmpty(expression) ?
            Convert.ToDouble(new System.Data.DataTable().Compute(expression.Replace(" ", ""), null)) : double.NaN;
    }
}