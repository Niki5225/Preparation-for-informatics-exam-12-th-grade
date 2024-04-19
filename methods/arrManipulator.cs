using System.Collections.Generic;

namespace arrManipulator
{
    class Task
    {
        static void Main()
        {
            List<int> lst = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

               

            while(true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] data = command.Split(" ").ToArray();
                string action = data[0];

                if (action == "exchange")
                {
                    if (!ValidateIndex(int.Parse(data[1]), lst))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    exchange(int.Parse(data[1]), lst);
                } else if (action == "max")
                {
                    maxEvenOrOddElement(data[1], lst);
                } else if (action == "min") 
                {
                    minEvenOrOddElement(data[1], lst);
                } else if (action == "first")
                {
                    int count = int.Parse(data[1]);
                    if (!ValidateCount(count, lst))
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    List<int> result = firstEvenOddNums(count, data[2], lst);

                    if (result.Count == 0)
                    {
                        Console.WriteLine("[]");
                    } else
                    {
                        Console.WriteLine($"[{string.Join(", ", result)}]");

                    }

                } else if (action == "last")
                {
                    int count = int.Parse(data[1]);
                    if (!ValidateCount(count, lst))
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    List<int> result = lastEvenOddNums(count, data[2], lst);
                    if (result.Count == 0)
                    {
                        Console.WriteLine("[]");
                    } else
                    {
                        Console.WriteLine($"[{string.Join(", ", result)}]");

                    }

                }
            }

            Console.WriteLine($"[{string.Join(", ", lst)}]");
        }

        static bool ValidateCount(int count, List<int> lst)
        {
            if (count > lst.Count)
            {
                return false;
            } 
            return true;
        }

        static bool ValidateIndex(int index, List<int> lst)
        {
            if (index >= lst.Count || index < 0) 
            {
                return false;
            }
            return true;
        }

        static List<int> exchange(int index, List<int> lst)
        {
            for (int i = 0; i <= index; i++) 
            {
                lst.Add(lst[0]);
                lst.RemoveAt(0);
                
            }
            return lst;
        }

        static void maxEvenOrOddElement(string value, List<int> lst)
        {
            if (value == "even")
            {
                maxEvenElement(lst);
            } else
            {
                maxOddElement(lst);
            }
        }

        static void minEvenOrOddElement(string value, List<int> lst)
        {
            if (value == "even")
            {
                minEvenElement(lst);
            }
            else
            {
                minOddElement(lst);
            }
        }

        private static void minOddElement(List<int> lst)
        {
            int index = -1;
            int number = 0;

            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (lst[i] % 2 != 0)
                {
                    if (lst[i] < number || index == -1)
                    {
                        index = i;
                        number = lst[i];

                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static void minEvenElement(List<int> lst)
        {
            int index = -1;
            int number = 0;

            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (lst[i] % 2 == 0)
                {
                    if (lst[i] < number || index == -1)
                    {
                        index = i;
                        number = lst[i];

                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        static void maxEvenElement(List<int> lst)
        {
            int index = -1;
            int number = 0;

            for(int i = lst.Count - 1; i >= 0; i--)
            {
                if (lst[i] % 2 == 0)
                {
                    if (lst[i] > number || index == -1)
                    {
                        index = i;
                        number = lst[i];

                    }
                }
            }
            
            if (index == -1)
            {
                Console.WriteLine("No matches");
            } else
            {
                Console.WriteLine(index);
            }

        }

        static void maxOddElement(List<int> lst)
        {
            int index = -1;
            int number = 0;
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (lst[i] % 2 != 0)
                {
                    if (lst[i] > number || index == -1)
                    {
                        index = i;
                        number = lst[i];
                    }
                }
            }

            if (index == -1)
            {
                Console.WriteLine("No matches");
            } else
            {
                Console.WriteLine(index);
            }
            
        }

        static List<int> firstEvenOddNums(int count, string value, List<int> lst)
        {
            List<int> arr = new List<int> { };

            if (value == "even")
            {
                firstEvenNums(count, lst, arr);
            } else
            {
                firstOddNums(count, lst, arr);
            }

            return arr;
        }

        private static void firstEvenNums(int count, List<int> lst, List<int> arr)
        {
            foreach(int i in lst)
            {
                if (arr.Count == count)
                {
                    return;
                }
                if (i % 2 == 0)
                {
                    arr.Add(i);
                }
            }

        }

        private static void firstOddNums(int count, List<int> lst, List<int> arr)
        {
            foreach (int i in lst)
            {
                if (arr.Count == count)
                {
                    return;
                }
                if (i % 2 != 0)
                {
                    arr.Add(i);
                }
            }
        }

        static List<int> lastEvenOddNums(int count, string value, List<int> lst)
        {
            List<int> arr = new List<int> { };

            if (value == "even")
            {
                lastEvenNums(count, lst, arr);
            }
            else
            {
                lastOddNums(count, lst, arr);
            }

            return arr;
        }

        private static void lastEvenNums(int count, List<int> lst, List<int> arr)
        {

            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (arr.Count == count)
                {
                    return;
                }
                if (lst[i] % 2 == 0)
                {
                    arr.Add(lst[i]);
                }
            }
        }

        private static void lastOddNums(int count, List<int> lst, List<int> arr)
        {
            for (int i = lst.Count - 1; i >= 0; i--)
            {
                if (arr.Count == count)
                {
                    return;
                }
                if (lst[i] % 2 != 0)
                {
                    arr.Add(lst[i]);
                }
            }
        }
    }

}