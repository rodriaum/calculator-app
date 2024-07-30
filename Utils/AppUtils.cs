using System.Text.RegularExpressions;

/*
 * Copyright (c) 2024 Rodrigo Ferreira
 * This file is part of a project (BasicCalculator) with MIT License.
 * For more information about permissions, visit the link below.
 * https://github.com/rodriaum/BasicCalculatorl?tab=MIT-1-ov-file#readme

 */
namespace BasicCalculator.util
{
    internal partial class AppUtils
    {

        /** App Utils */

        public static string DoubleToString(double d)
        {
            return double.IsNaN(d) ? "" : d.ToString();
        }

        public static bool IsNumber(string s)
        {
            return OnlyNumberRegex().IsMatch(s);
        }

        public static char EmptyChar()
        {
            return '\0';
        }

        /** Generated Regex */

        [GeneratedRegex(@"^\d+$")]
        private static partial Regex OnlyNumberRegex();
    }
}

