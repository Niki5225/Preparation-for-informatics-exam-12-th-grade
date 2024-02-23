namespace Task
{
    class Task
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] arr = new int[number];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                arr[i] = passengers;
                sum += passengers;
            }

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(sum);
        }
    }
}