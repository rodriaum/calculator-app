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
            return numbers.Sum();
        }

        public double Subtract(double[] numbers)
        {
            double total = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                total -= numbers[i];
            }

            return total;
        }

        public double Multiply(double[] numbers)
        {
            double total = 1;

            foreach (double number in numbers)
                total *= number;

            return total;
        }

        public double Divide(double[] numbers)
        {
            double total = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
                total /= numbers[i];

            return total;
        }
    }
}
