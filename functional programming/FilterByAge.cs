using System;

namespace FilterByAge
{
    class Task
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string name = input[0];
                int personAge = int.Parse(input[1]);

                people[name] = personAge;
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var person in people)
            {
                if (condition == "younger")
                {
                    if (age > person.Value) 
                    {
                        result.Add(person.Key, person.Value);
                    }
                }
                else if(condition == "older")
                {
                    if (person.Value >= age)
                    {
                        result.Add(person.Key, person.Value);
                    }
                }
            }

            if (format == "name")
            {
                foreach(var person in result)
                {
                    Console.WriteLine(person.Key);
                }
            } else if (format == "age")
            {
                foreach (var person in result)
                {
                    Console.WriteLine(person.Value);
                }
            }
            else
            {
                foreach (var person in result)
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
        }
    }
}