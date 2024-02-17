public class Task
{
    public static void Main(string[] args)
    {
        int countOfPeople = int.Parse(Console.ReadLine());
        string typeOfPeople = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double totalPrice = 0;

        switch (typeOfPeople)
        {
            case "Students":
                if (dayOfWeek == "Friday")
                {
                    totalPrice = countOfPeople * 8.45;
                } else if (dayOfWeek == "Saturday")
                {
                    totalPrice = countOfPeople * 9.80;
                } else if (dayOfWeek == "Sunday")
                {
                    totalPrice = countOfPeople * 10.46;
                }
                if (countOfPeople >= 30)
                {
                    totalPrice *= 0.85;
                }
                break;
            case "Business":

                if (countOfPeople >= 100)
                {
                    countOfPeople -= 10;
                }

                if (dayOfWeek == "Friday")
                {
                    totalPrice = countOfPeople * 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = countOfPeople * 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = countOfPeople * 16;
                }
                break;
                
            case "Regular":
                if (dayOfWeek == "Friday")
                {
                    totalPrice = countOfPeople * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = countOfPeople * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = countOfPeople * 22.5;
                }

                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    totalPrice *= 0.95;
                }
                break;
        }
        Console.WriteLine($"Total price: {totalPrice:F2}");
    }
}