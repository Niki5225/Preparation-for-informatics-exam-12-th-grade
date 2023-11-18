public class Task
{
    public static void Main(string[] args)
    {
        int maxNumber = int.Parse(Console.ReadLine());
        int currentNum = 1;

        while (true)
        {
            Console.WriteLine(currentNum);
            int possibleValue = 2 * currentNum + 1;
            if (possibleValue <= maxNumber)
            {
                currentNum = possibleValue;
            } else
            {
                break;
            }
        }
    }
}