namespace CustomMinFunc
{
    class Task
    {
        static void Main()
        {
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minFunc = MinFunc;

            Console.WriteLine(minFunc(ints));

            static int MinFunc(int[] ints)
            {
                int minInt = int.MaxValue;

                foreach (int i in ints)
                {
                    if (i < minInt)
                    {
                        minInt = i;
                    }
                }

                return minInt;
            }
        }
    }
}