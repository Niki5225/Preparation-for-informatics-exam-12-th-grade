namespace Task;

public class Task
{
    public static void Main(string[] args)
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var averageGrade = double.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}, Age: {age}, Grade: {averageGrade:F2}");
    }
}