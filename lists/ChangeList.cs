namespace ChangeList
{
    class Task
    {
        static void Main()
        {
            List<int> lst = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] data = command.Split();
                string action = data[0];
                int element = int.Parse(data[1]);

                if (action == "Delete") 
                {
                    lst.RemoveAll(x => x == element);
                } else
                {
                    int index = int.Parse(data[2]);
                    lst.Insert(index, element);
                }
            }
            Console.WriteLine(string.Join(" ", lst));
        }
    }
}