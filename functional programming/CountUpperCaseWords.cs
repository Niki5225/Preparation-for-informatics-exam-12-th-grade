namespace CountUpperCaseWords
{
    class Task
    {
        static void Main()
        {
            List<string> upperCaseWords = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => char.IsUpper(x[0])).ToList();

            foreach (string word in upperCaseWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}