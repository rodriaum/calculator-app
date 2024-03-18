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
            Application.Run(new FormCalculator());

            FormCalculator calc = new FormCalculator
            ();

            Console.WriteLine(calc.BackColor != null ? calc.BackColor.Name : "BackColor Nulo");

            Console.WriteLine(calc.TransparencyKey != null ? calc.TransparencyKey.Name : "TransparencyKey Nulo");

        }
    }
}