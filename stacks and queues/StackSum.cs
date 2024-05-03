namespace StackSum
{
    class Task
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Stack<int> result = new Stack<int>();

            foreach(int x in nums) 
            {
                result.Push(x);
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();
                if (command == "end")
                {
                    break;
                }

                string[] data = command.Split();
                string action = data[0].ToLower();
                
                if (action == "add")
                {
                    int num1 = int.Parse(data[1]);
                    int num2 = int.Parse(data[2]);

                    result.Push(num1);
                    result.Push(num2);
                } else
                {

                    int numsToRemove = int.Parse(data[1]);
                    if (numsToRemove > result.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < numsToRemove; i++)
                    {
                        result.Pop();
                    }
                }
            }

            int sum = 0;
            foreach(int x in result) 
            {
                sum += x;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}