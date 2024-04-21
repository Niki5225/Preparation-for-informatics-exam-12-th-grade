namespace RemoveNegativesAndReverse
{
    class Task
    {
        static void Main()
        {
            List<int> lst = Console.ReadLine().Split().Select(int.Parse).ToList();

            lst.RemoveAll(x => x < 0);

            if (lst.Count == 0)
            {
                Console.WriteLine("empty");
            } else
            {
                lst.Reverse();
                Console.WriteLine(string.Join(" ", lst));
            }
        }
    }
}