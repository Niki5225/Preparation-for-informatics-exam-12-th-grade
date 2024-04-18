namespace MiddleChars
{
    class Task
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Console.WriteLine(GetMiddleChars(str));
        }

        static string GetMiddleChars(string str)
        {
            int middleLen = (int)Math.Ceiling((decimal)(str.Length / 2));

            if (str.Length % 2 == 0)
            {
               
                return $"{str[middleLen - 1]}{str[middleLen]}";
            }
            

            return str[middleLen].ToString();


        }
    }
}