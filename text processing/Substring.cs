namespace Substring
{
    class Task
    {
        static void Main()
        {
            string substring = Console.ReadLine();
            string str = Console.ReadLine();

            while(str.IndexOf(substring) != -1)
            {
                int index = str.IndexOf(substring);
                str = str.Remove(index, substring.Length);
            }

            Console.WriteLine(str);
        }
    }
}