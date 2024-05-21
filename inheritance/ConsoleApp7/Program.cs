namespace Inheritance
{
    class Task
    {
        static void Main()
        {
            string name = Console.ReadLine();

            Snake snake = new Snake(name);

            Console.WriteLine(snake.Name);


        }
    }
}