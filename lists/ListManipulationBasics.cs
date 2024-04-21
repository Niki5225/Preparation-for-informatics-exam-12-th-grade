namespace ListManipulationBasics
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

                string[] data = command.Split(" ");
                string action = data[0];
                int number = int.Parse(data[1]);

                if(action == "Add")
                {
                    lst.Add(number);
                } else if(action == "Insert")
                {
                   int index = int.Parse(data[2]);
                   lst.Insert(index, number);
                } else if(action == "RemoveAt")
                {
                    lst.RemoveAt(number);

                } else if(action == "Remove")
                {
                    lst.Remove(number);
                } 
            }

            Console.WriteLine(string.Join(" ", lst)) ;
        }
    }
}