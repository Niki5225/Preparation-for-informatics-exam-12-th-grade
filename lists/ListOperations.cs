namespace ListOperations
{
    class Task
    {
        static void Main()
        {
            List<int> lst = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] data = command.Split();
                string action = data[0];

                if (action == "Add")
                {
                    int number = int.Parse(data[1]);
                    lst.Add(number);
                } else if (action == "Insert")
                {
                    int number = int.Parse(data[1]);
                    int index = int.Parse(data[2]);
                    if (!ValidateIndex(index, lst)) 
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    lst.Insert(index, number);
                } else if (action == "Remove")
                {
                    int index = int.Parse(data[1]);
                    if (!ValidateIndex(index, lst))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    lst.RemoveAt(index);
                } else if(action == "Shift")
                {
                    string nextCommand = data[1];
                    int count = int.Parse(data[2]);
                    if (nextCommand == "left") 
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int number = lst[0];
                            lst.RemoveAt(0);
                            lst.Add(number);
                        }
                    } else if(nextCommand == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int number = lst[lst.Count - 1];
                            lst.RemoveAt(lst.Count - 1);
                            lst.Insert(0, number);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", lst));
        }

        static bool ValidateIndex(int index, List<int> lst)
        {
            return index >= 0 && index < lst.Count; 
        }
    }
}