using System.Globalization;

namespace Task
{
    class Task
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;

            int sumOfFactorials = 0;



            while (number > 0)
            {
                int digit = number % 10;
                sumOfFactorials += factorialCalculate(digit);
                number /= 10;

            }

            if (originalNumber == sumOfFactorials || originalNumber == 2 || originalNumber == 1)
            {
                Console.WriteLine("yes");
            } else
            {
                Console.WriteLine("no");
            }


        }

        static int factorialCalculate(int digit)
        {
            if (digit <= 1)
            {
                return 1;
            } else
            {
                return digit * factorialCalculate(digit - 1);
            }
        }
    }
}