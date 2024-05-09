namespace SortEvenNumbers
{
    class Task
    {
        static void Main()
        {
            List<int> evenInts = Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 == 0).ToList();

            List<int> sortedEvenInts = evenInts.OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", sortedEvenInts));
        }
    }
}