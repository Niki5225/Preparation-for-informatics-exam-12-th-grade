namespace PrintEvenNumbers
{
    class Task
    {
        static void Main()
        {
            Queue<int> ints = new Queue<int>();

            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            foreach (int i in input)
            {
                if (i % 2 == 0)
                {
                    ints.Enqueue(i);
                }
            }

            Console.WriteLine(string.Join(", ", ints));
        }
    }
}