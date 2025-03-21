using System.Drawing.Text;
using System.Text.RegularExpressions;

/*
 * Copyright (c) 2024 Rodrigo Ferreira
 * This file is part of a project (Calculator) with MIT License.
 * For more information about permissions, visit the link below.
 * https://github.com/rodriaum/Calculatorl?tab=MIT-1-ov-file#readme
 */

namespace Calculator.Helper;

public partial class AppHelper
{

    /** Formatters, etc */

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

    public static bool HasDeviceFont(string name)
    {
        using (var fonts = new InstalledFontCollection())
        {
            return fonts.Families.Any(fontFamily => fontFamily.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }

    public static FontFamily GetAppFontfamily()
    {
        return HasDeviceFont("Barlow") ? new FontFamily("Barlow") : new FontFamily("Mongolian Baiti");
    }

    /** Regex */

    [GeneratedRegex(@"^\d+$")]
    private static partial Regex OnlyNumberRegex();
}

