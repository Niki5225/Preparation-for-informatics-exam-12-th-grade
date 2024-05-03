using System.Numerics;

namespace MultiplyBigNumber
{
    class Task
    {
        static void Main()
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 * num2);
        }
    }
}