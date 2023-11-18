public class Task
{
    public static void Main(string[] args)
    {
        int numsToRead = int.Parse(Console.ReadLine());

        int result = 0;

        for (int i = 0; i < numsToRead; i++) {
            result += int.Parse(Console.ReadLine());
        }

        Console.WriteLine(result);
    }
}