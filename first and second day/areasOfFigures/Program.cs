namespace areasOfFigures;

public class AreasOfFigures
{
    public static void Main(string[] args)
    {
        string figure = Console.ReadLine();
        double side = double.Parse(Console.ReadLine());

        if (figure == "square")
        {
            Console.WriteLine("{0:F3}", side * side);
        }
        else if (figure == "triangle")
        {
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}", (side * height) / 2);
        }
        else if (figure == "circle")
        {
            Console.WriteLine($"{side * side * Math.PI}:3F");
        } else if (figure == "rectangle"){


            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}", side * length);
        }
    }
}

