namespace RecordUniqueNames
{
    class Task
    {
        static void Main()
        {
            int numOfNames = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < numOfNames; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}