namespace AddVAT
{
    class Task
    {
        static void Main()
        {
            List<double> list = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => x + (x * 0.2)).ToList();

            foreach(double x in list)
            {
                Console.WriteLine($"{x:F2}");
            }
        }
    }
}