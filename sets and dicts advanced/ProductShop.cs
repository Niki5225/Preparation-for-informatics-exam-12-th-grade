namespace ProductShop
{
    class Task
    {
        static void Main()
        {

            SortedDictionary<string, Dictionary<string, double>> products = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string line = Console.ReadLine();   
                if (line == "Revision")
                {
                    break;
                }

                string[] data = line.Split(", ");
                string name = data[0];
                string product = data[1];
                double price = double.Parse(data[2]);

                if (!products.ContainsKey(name))
                {
                    products[name] = new Dictionary<string, double>();
                }

                
                products[name][product] = price;
            }

            foreach (var shopName in products.Keys)
            {
                Console.WriteLine($"{shopName}->");
                foreach(var product in products[shopName])
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}