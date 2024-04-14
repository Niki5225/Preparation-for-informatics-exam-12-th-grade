namespace PrintingTriangle
{
    class Task
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            printingTriangle(num);

        }

        private static void printingTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int i = number - 1; i > 0; i--) 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}