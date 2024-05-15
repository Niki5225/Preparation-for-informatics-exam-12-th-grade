namespace ActionPrint
{
    class Task
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split().ToArray();
            Action<string[]> action = Print;

            action(names);


            static void Print(string[] names)
            {
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }

        }

        
    }
}