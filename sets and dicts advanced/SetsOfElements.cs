namespace SetsOfElements
{
    class Task
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int n = nums[0];
            int m = nums[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0;i < m; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            foreach (int number in set1)
            {
                if (set2.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}