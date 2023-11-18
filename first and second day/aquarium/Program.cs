namespace aquiarum;

public class Aquiarium
{
    static void Main(string[] args)
    {
        double length = int.Parse(Console.ReadLine());
        double width = int.Parse(Console.ReadLine());
        double heigth = int.Parse(Console.ReadLine());
        double percentage = double.Parse(Console.ReadLine()) / 100;

        double volume = (length * width * heigth) / 1000;

        double volumeForWater = volume * (1 - percentage); 

        Console.WriteLine(volumeForWater);
    }
}