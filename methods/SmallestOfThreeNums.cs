namespace SmallestOfThreeNums
{
    class Task
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int[] arr = new int[3] { num1, num2, num3 };

            Console.WriteLine(arr.Min());
            
        }
    }
}