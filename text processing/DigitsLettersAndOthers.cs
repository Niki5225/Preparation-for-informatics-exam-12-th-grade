namespace DigitsLettersAndOthers
{
    class Task
    {
        static void Main()
        {
            string text = Console.ReadLine();
            List<char> characters = new List<char>();
            List<char> digits = new List<char>();
            List<char> others = new List<char>();

            foreach(char ch in text)
            {
                if (char.IsDigit(ch))
                {
                    digits.Add(ch);
                } else if (char.IsLetter(ch))
                {
                    characters.Add(ch);
                } else
                {
                    others.Add(ch);
                }
            }

            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", characters));
            Console.WriteLine(string.Join("", others));
        }
    }
}