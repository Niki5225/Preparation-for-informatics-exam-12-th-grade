﻿namespace Task;

public class Task
{
    public static void Main(string[] args)
    {
        string country = Console.ReadLine();

        if (country == "England" || country == "USA")
        {
            Console.WriteLine("English");
        } else if (country == "Spain" || country == "Argentina" || country == "Mexico")
        {
            Console.WriteLine("Spanish");
        } else
        {
            Console.WriteLine("unknown");
        }
    }
}