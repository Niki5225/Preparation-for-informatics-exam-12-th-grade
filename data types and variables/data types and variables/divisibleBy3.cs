namespace Task;

public class Task
{
    public static void Main(string[] args)
    {
        for (int i = 3; i <= 99; i++)
        {
            if(i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}