namespace Wardrobe
{
    class Task
    {
        static void Main()
        {
            int numberOfClothes = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothesDict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfClothes; i++)
            {
                string[] data = Console.ReadLine().Split(" -> ");
                string color = data[0];
                string[] clothes = data[1].Split(",");

                if (!clothesDict.ContainsKey(color))
                {
                    clothesDict[color] = new Dictionary<string, int>();
                }

                foreach (string s in clothes)
                {
                    if (clothesDict[color].ContainsKey(s))
                    {
                        clothesDict[color][s]++;
                    } else
                    {
                        clothesDict[color][s] = 1;
                    }
                }
            }

            string[] searchedInfo = Console.ReadLine().Split();
            string searchedColor = searchedInfo[0];
            string searchedDress = searchedInfo[1];


            foreach(string color in clothesDict.Keys)
            {
                Console.WriteLine($"{color} clothes:");
                foreach(var item in clothesDict[color])
                {
                    if (searchedColor == color && searchedDress == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    } else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}