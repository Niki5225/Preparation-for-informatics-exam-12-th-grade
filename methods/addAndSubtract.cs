namespace AddAndSubtract
{
    class Task
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(AddAndSubtract(num1, num2, num3));
        }

        static int AddAndSubtract(int x, int y, int z)
        {
            return Subtract(Add(x, y), z);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int resFromFunc, int z)
        {

            return resFromFunc - z;
        }
    }
}