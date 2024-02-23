namespace Task
{
    class Task
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> topIntegers = new List<int>();

            for(int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                bool isGreater = true;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (currentNum < arr[j]) 
                    {
                        isGreater = false;
                        break;
                    }
                }
                if (isGreater)
                {
                    topIntegers.Add(currentNum);
                }
            }
            Console.WriteLine(string.Join(" ", topIntegers));
        }
    }
}