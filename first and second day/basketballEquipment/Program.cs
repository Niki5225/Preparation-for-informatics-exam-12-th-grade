namespace basketballEquipment;

public class BasketballEquipment
{
    static void Main(string[] args)
    {
        double taxesForTrainingsAnnualy = double.Parse(Console.ReadLine());
        double shoes = 0.6 * taxesForTrainingsAnnualy;
        double outfit = shoes * 0.8;
        double basketball = 0.25 * outfit;
        double accessories = 0.2 * basketball;


        Console.WriteLine(taxesForTrainingsAnnualy + shoes + outfit + basketball + accessories);
    }   
}