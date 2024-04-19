namespace FactorialDivision
{
    class Task
    {
        static void Main()
        {
            double number1 = int.Parse(Console.ReadLine());
            double number2 = int.Parse(Console.ReadLine());

            double factorial1 = CalculateFactorial(number1);
            double factorial2 = CalculateFactorial(number2);

            Console.WriteLine($"{(factorial1 / factorial2):F2}");
        }

        static double CalculateFactorial(double num)
        {
            double result = num;

            for (double i = num - 1; i > 0; i--) 
            {
                result *= i;
            }

            return result;
        }

    }
}