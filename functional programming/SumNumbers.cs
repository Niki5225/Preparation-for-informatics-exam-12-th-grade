namespace SumNumbers
{
    class Task
    {
        static void Main()
        {
            List<int> ints = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToList();

            Console.WriteLine(ints.Count);
            Console.WriteLine(ints.Sum());
        }
    }
}