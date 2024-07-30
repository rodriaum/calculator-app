/*
 * Copyright (c) 2024 Rodrigo Ferreira
 * This file is part of a project (BasicCalculator) with MIT License.
 * For more information about permissions, visit the link below.
 * https://github.com/rodriaum/BasicCalculatorl?tab=MIT-1-ov-file#readme
 */

namespace BasicCalculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new CalculatorForm());
        }
    }
}