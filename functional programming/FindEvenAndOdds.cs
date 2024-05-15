namespace FindEvenAndOdds
{
    class Task
    {
        static void Main()
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = parameters[0];
            int end = parameters[1];
            string condition = Console.ReadLine();

            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;

            List<int> list = new List<int>();

            for (int i = start; i <= end; i++)
            {
                list.Add(i);
            }

            if (condition == "odd")
            {
                Console.WriteLine(string.Join(" ", list.FindAll(isOdd)));
            } else
            {
                Console.WriteLine(string.Join(" ", list.FindAll(isEven)));
            }
        }
    }
}