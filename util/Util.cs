using System.Text.RegularExpressions;

namespace BasicCalculator.util
{
    internal class Util
    {
        public static string DoubleToString(double d)
        {
            return double.IsNaN(d) ? "" : d.ToString();
        }

        public static bool IsNumber(string s)
        {
            return Regex.IsMatch(s, @"^\d+$");
        }

        public static char EmptyChar()
        {
            return '\0';
        }

        public static double EvaluateExpression(string expression)
        {
            return Convert.ToDouble(new System.Data.DataTable().Compute(expression.Replace(" ", ""), null));
        }
    }
}
