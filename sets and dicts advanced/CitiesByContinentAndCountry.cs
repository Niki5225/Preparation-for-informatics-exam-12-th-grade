namespace CitiesByContinentAndCountry
{
    class Task
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> cities = new Dictionary<string, Dictionary<string, List<string>>>();

            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                string[] data = Console.ReadLine().Split();
                string continent = data[0];
                string country = data[1];
                string city = data[2];

                if (!cities.ContainsKey(continent))
                {
                    cities[continent] = new Dictionary<string, List<string>>();
                }

                if (!cities[continent].ContainsKey(country))
                {
                    cities[continent][country] = new List<string>();
                }

                cities[continent][country].Add(city);
            }

            foreach(var continent in cities.Keys) 
            {
                Console.WriteLine($"{continent}:");
                foreach(var item in cities[continent])
                {
                    Console.WriteLine($"  {item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}