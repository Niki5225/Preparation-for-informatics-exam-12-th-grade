namespace KnightsOfHonor
{
    class Task
    {
        static void Main()
        {
            string[] knightNames = Console.ReadLine().Split().ToArray();
            Action<string[]> printKnights = PrintKnights;

            printKnights(knightNames);


            static void PrintKnights(string[] names)
            {
                foreach (string name in names)
                {
                    Console.WriteLine($"Sir {name}");
                }
            }
        }
    }
}