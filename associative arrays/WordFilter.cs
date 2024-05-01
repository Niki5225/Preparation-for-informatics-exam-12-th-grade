namespace WordFilter
{
    class Task
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

            foreach(string str in arr) 
            {
                Console.WriteLine(str);
            }
        }
    }
}