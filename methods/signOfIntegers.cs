namespace SignOfIntegers
{
    class Task
    {

        static void SignOfIntegers(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            SignOfIntegers(number);
        }
    }
}