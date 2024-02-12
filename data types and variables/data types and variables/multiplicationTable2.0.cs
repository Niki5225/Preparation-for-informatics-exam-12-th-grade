namespace Task;

public class Task
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int startingPoint = int.Parse(Console.ReadLine());  

        if (startingPoint <= 10)
        {
            for (int i = startingPoint; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        } else
        {
            Console.WriteLine($"{number} X {startingPoint} = {number * startingPoint}");
        }
    }
}