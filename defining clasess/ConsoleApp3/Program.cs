namespace DefiningClasses
{
    class StartUp
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < people; i++)
            {
                string[] personData = Console.ReadLine().Split();
                string personName = personData[0];
                int personAge = int.Parse(personData[1]);

                Person person = new Person(personName, personAge);

                

                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}