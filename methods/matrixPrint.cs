namespace NNmatrix
{
    class Task
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < n; j++)
                {
                    line += $"{n} ";
                }
                line.Trim();
                Console.WriteLine(line);
            }
        }
    }
}

