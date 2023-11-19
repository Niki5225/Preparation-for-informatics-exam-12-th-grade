public class Task
{
    public static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        int pieces = length * width;
        bool isEnough = true;

        string command = Console.ReadLine();

        while (command != "STOP") {
            int piecesWanted = int.Parse(command);

            pieces -= piecesWanted;

            if (pieces < 0)
            {
                isEnough = false;
                break;
            }

            command = Console.ReadLine();
        }
        gthjk
        if (isEnough)
        {
            Console.WriteLine($"{pieces} pieces are left.");
        } else
        {
            Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
        }
    }
}