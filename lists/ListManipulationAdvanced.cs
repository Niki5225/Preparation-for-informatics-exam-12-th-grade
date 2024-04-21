namespace ListManipulationAdvanced
{
    class Task
    {
        static void Main()
        {
            List<int> lst = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> copyOfOriginalLst = new List<int>(lst);
             
            while(true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] data = command.Split();
                string action = data[0];


                if (action == "Add")
                {
                    int number = int.Parse(data[1]);
                    lst.Add(number);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(data[1]);
                    int index = int.Parse(data[2]);
                    lst.Insert(index, number);
                }
                else if (action == "RemoveAt")
                {
                    int number = int.Parse(data[1]);
                    lst.RemoveAt(number);

                }
                else if (action == "Remove")
                {
                    int number = int.Parse(data[1]);
                    lst.Remove(number);
                }
                else if (action == "Contains")
                {
                    int number = int.Parse(data[1]);
                    if (lst.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    } else
                    {
                        Console.WriteLine("No such number");
                    }

                } else if(action == "PrintEven")
                {
                    PrintEven(lst);
                } else if (action == "PrintOdd")
                {
                    PrintOdd(lst);
                } else if (action == "GetSum") 
                {
                    GetSum(lst);
                } else if (action == "Filter")
                {
                    string condition = data[1];
                    int number = int.Parse(data[2]);
                    Filter(lst, condition, number);
                }
            }

            if (!AreEqual(lst, copyOfOriginalLst))
            {

            }
        }

        private static bool AreEqual(List<int> lst1, List<int> lst2)
        {
            if(lst1.Count != lst2.Count)
            {
                return false;
            }

            for (int i = 0; i < lst1.Count; i++)
            {
                if (lst1[i] != lst2[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static void Filter(List<int> lst, string condition, int number)
        {
            List<int> result = new List<int>();
            switch (condition)
            {
                case "<":
                    result = lst.FindAll(x => x < number);
                    break;
                case ">":
                    result = lst.FindAll(x => x > number);
                    break;
                case "<=":
                    result = lst.FindAll(x => x <= number);
                    break;
                case ">=":
                    result = lst.FindAll(x => x >= number);
                    break;
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void GetSum(List<int> nums)
        {
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }

        private static void PrintOdd(List<int> nums)
        {
            List<int> result = new List<int>();
            foreach (int num in nums)
            {
                if (num % 2 != 0)
                {
                    result.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void PrintEven(List<int> nums)
        {
            List<int> result = new List<int>();
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}