namespace BasicCalculator.operators
{
    internal class MathOperator
    {
        /**
         * Português: Cálculos básicos de arrays 'double'.
         * Inglês: Basic calculations from 'double' arrays.
         */

        public double Add(double[] numbers)
        {
            double total = 0;

            foreach (double number in numbers)
                total += number;

            return total;
        }

        public double Subtract(double[] numbers)
        {
            double total = 0;

            foreach (double number in numbers)
                total -= number;

            return total;
        }

        public double Multiply(double[] numbers)
        {
            double total = 0;

            foreach (double number in numbers)
                total *= number;

            return total;
        }

        public double Divide(double[] numbers)
        {
            double total = 0;

            foreach (double number in numbers)
                total /= number;

            return total;
        }
    }
}
