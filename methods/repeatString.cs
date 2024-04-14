namespace RepeatString
{
    class Task
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int timesToRepeat = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatStringFunc(str, timesToRepeat));
        }

        private static string RepeatStringFunc(string str, int timesToRepeat)
        {
            string result = "";

            for (int i = 0; i < timesToRepeat; i++)
            {
                result += str;
            }

            return result;
        }
    }
}