namespace UniqueUsernames
{
    class Task
    {
        static void Main()
        {
            int CountNames = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < CountNames; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}