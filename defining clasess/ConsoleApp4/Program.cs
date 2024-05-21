namespace DefiningClasses
{
    class StartUp
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] personData = Console.ReadLine().Split().ToArray();
                string name = personData[0];
                int age = int.Parse(personData[1]);

                Person person = new Person(name, age);

                people.Add(person);
            }

            List<Person> sortedPeople = people.OrderBy(x => x.Name).ToList();
            
            foreach (Person person in sortedPeople)
            {
                if (person.Age > 30)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
           

        }
    }
}