namespace Orders
{
    class Task
    {
        static void Main()
        {
            Dictionary<string, double[]> dict = new Dictionary<string, double[]>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "buy")
                {
                    break;
                }

                string[] data = command.Split().ToArray();
                string product = data[0];
                double price = double.Parse(data[1]);
                double quantity = double.Parse(data[2]);  

                if (dict.ContainsKey(product))
                {
                    dict[product][0] = price;
                    dict[product][1] += quantity;
                } else
                {
                    dict[product] = new double[]{ price, quantity};
                }
            }

            foreach(var item in dict) 
            {
                double finalPrice = item.Value[0] * item.Value[1];

                Console.WriteLine($"{item.Key} -> {finalPrice:F2}");
            }
        }
    }
}