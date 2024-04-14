namespace Calculations
{
    class Task
    {
        static void Main()
        {
            string action = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (action == "add")
            {
                Add(number1, number2);

            } else if (action == "subtract")
            {
                Subtract(number1, number2);
            } else if (action == "multiply")
            {
                Multiply(number1, number2);
            } else if (action == "divide")
            {
                Divide(number1, number2);
            }
        }

        private static void Add(int num1, int num2) 
        {
            Console.WriteLine(num1 + num2);
        }
        private static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        private static void Multiply(int num1, int num2) 
        {
            Console.WriteLine(num1 * num2);
        }
        private static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}