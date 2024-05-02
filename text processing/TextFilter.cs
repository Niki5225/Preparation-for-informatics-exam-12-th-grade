namespace TextFilter
{
    class Task
    {
        static void Main()
        {
            string[] forbiddenWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach(string bannedword in forbiddenWords)
            {
                string word = new string('*', bannedword.Length);

                text = text.Replace(bannedword, word);
            }
            Console.WriteLine(text);
        }
    }
}