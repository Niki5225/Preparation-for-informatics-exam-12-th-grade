namespace MergingLists
{
    class Task
    {
        static void Main()
        {
            List<int> lst1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> lst2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            if(lst1.Count == lst2.Count)
            {
                EqualLens(result, lst1, lst2);
            } else
            {
                NonEqualLens(result, lst1, lst2);
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static void EqualLens(List<int> res, List<int> lst1, List<int> lst2)
        {
            for(int i = 0; i < lst1.Count; i++)
            {
                res.Add(lst1[i]);
                res.Add(lst2[i]);
            }
        }

        private static void NonEqualLens(List<int> res, List<int> lst1, List<int> lst2)
        {
            int minValue = Math.Min(lst1.Count, lst2.Count);
            for (int i = 0; i < minValue; i++)
            {
                res.Add(lst1[0]);
                lst1.RemoveAt(0);
                res.Add(lst2[0]);
                lst2.RemoveAt(0);
            }

            if (lst1.Count > 0)
            {
                foreach(int i in lst1)
                {
                    res.Add(i);
                }
            }

            if (lst2.Count > 0)
            {
                foreach (int i in lst2)
                {
                    res.Add(i);
                }
            }


        }
    }
}