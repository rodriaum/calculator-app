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

            FormCalculator form = new FormCalculator();
            Application.Run(form);

            while (form.charOperator != null)
                Console.WriteLine(form.charOperator);
        }
    }
}