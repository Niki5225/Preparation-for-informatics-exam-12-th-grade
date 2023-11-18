namespace InchesToCentimeters;

public class InchesToCentimeters
{
    static void Main(string[] args)
    {
        int inches = int.Parse(Console.ReadLine());
        double centimeters = inches * 2.54;
        Console.WriteLine(centimeters);
    }
}