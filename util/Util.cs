using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using BasicCalculator.Properties;

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
            return Regex.IsMatch(s, @"^-?\d+(\.\d+)?$");
        }

        public static char EmptyChar() 
        { 
            return '\0'; 
        }
    }
}
