namespace ListOfProducts
{
    class Task
    {
        static void Main()
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();   

            for(int i = 0; i < numberOfProducts; i++)
            {
                products.Add(Console.ReadLine());

            }

            products.Sort((a, b) => a.CompareTo(b));
            for(int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}