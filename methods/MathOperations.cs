namespace MathOperations
{
    class Task
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());

            if(action == "*")
            {
                Console.WriteLine(Multiply(num1, num2));
            } else if(action == "+")
            {
                Console.WriteLine(Add(num1, num2));
            } else if(action == "-")
            {
                Console.WriteLine(Subtract(num1, num2));
            } else
            {
                Console.WriteLine(Divide(num1, num2));
            }
        }

        private static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        private static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        private static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}