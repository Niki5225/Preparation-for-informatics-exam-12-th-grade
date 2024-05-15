namespace ReverseAndExclude
{
    class Task
    {
        static void Main() 
        {
            List<int> ints = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int divisor = int.Parse(Console.ReadLine());

            Predicate<int> isNotDivisible = x => x % divisor != 0;

            Console.WriteLine(string.Join(" ", ints.FindAll(isNotDivisible)));
        }
    }
}