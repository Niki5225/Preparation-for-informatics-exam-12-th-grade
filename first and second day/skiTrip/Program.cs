namespace skiTrip;

public class SkiTrip
{
    public static void Main(string[] args) {

        int days = int.Parse(Console.ReadLine()) - 1;
        string typeOfRoom = Console.ReadLine();
        string grade = Console.ReadLine();

        double discount = 0.00;
        double pricePerNight = 0;

        switch (typeOfRoom)
        {
            case "room for one person":
                pricePerNight = 18;
                break;
            case "apartment":
                if (days < 10)
                {
                    discount = 0.3;
                } else if (days >= 10 && days < 15)
                {
                    discount = 0.35;
                } else if (days >= 15)
                {
                    discount = 0.5;
                }
                pricePerNight = 25;
                break;
            case "president apartment":
                if (days < 10)
                {
                    discount = 0.1;
                }
                else if (days >= 10 && days < 15)
                {
                    discount = 0.15;
                }
                else if (days >= 15)
                {
                    discount = 0.2;
                }
                pricePerNight = 35;
                break;
        }
        double result = 0;

        if (grade == "positive")
        {
            result = ((pricePerNight * days) * (1 - discount)) * 1.25;
        } else
        {
            result = ((pricePerNight * days) * (1 - discount)) * 0.9;
        }

        Console.WriteLine($"{result:f2}");
    }
}