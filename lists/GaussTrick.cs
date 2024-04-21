namespace GaussTrick
{
    class Task
    {
        static void Main()
        {
            List<int> lst = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < lst.Count / 2; i++) 
            {
                result.Add(lst[i] + lst[lst.Count - 1 - i]);
            }

            if (lst.Count % 2 != 0)
            {
                result.Add(lst[lst.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}