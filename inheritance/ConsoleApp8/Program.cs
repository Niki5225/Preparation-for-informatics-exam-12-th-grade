namespace Inheritance
{
    class Task
    {
        static void Main()
        {
            string username = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());
            DarkKnight knight = new DarkKnight(username, level);

            Console.WriteLine(knight);
        }
    }
}