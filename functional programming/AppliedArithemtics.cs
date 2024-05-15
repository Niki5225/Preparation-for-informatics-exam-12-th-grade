namespace AppliedArithemtics
{
    class Task
    {
        static void Main()
        {
            List<int> collection = Console.ReadLine().Split().Select(int.Parse).ToList();
            Action<List<int>> add = Add;
            Action<List<int>> subtract = Subtract;
            Action<List<int>> multiply = Multiply;
            Action<List<int>> print = Print;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "add":
                        add(collection);
                        break;
                    case "multiply":
                        multiply(collection);
                        break;
                    case "subtract":
                        subtract(collection);
                        break;
                    case "print":
                        print(collection);
                        break;
                }
            }



            static void Add(List<int> collection)
            {
                for (int i = 0; i < collection.Count; i++)
                {
                    collection[i]++;
                }
            }

            static void Multiply(List<int> collection)
            {
                for (int i = 0; i < collection.Count; i++)
                {
                    collection[i] *= 2;
                }
            }

            static void Subtract(List<int> collection)
            {
                for (int i = 0; i < collection.Count; i++)
                {
                    collection[i]--;
                }
            }

            static void Print(List<int> collection)
            {
                Console.WriteLine(string.Join(" ", collection));
            }
        }
    }
}