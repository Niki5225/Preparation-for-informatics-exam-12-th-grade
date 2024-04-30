namespace CountRealNumbers
{
    class Task
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            SortedDictionary<int, int> numbersCount = new SortedDictionary<int, int>();

            foreach(int number in numbers)
            {
                if (numbersCount.Keys.Contains(number))
                {
                    numbersCount[number]++;
                } else
                {
                    numbersCount[number] = 1;
                }
            }

            foreach (int key in numbersCount.Keys)
            {
                Console.WriteLine($"{key} -> {numbersCount[key]}");
            }
        }
    }
}