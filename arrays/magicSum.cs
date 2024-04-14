namespace MagicSum
{
    class task
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            List<int[]> matrixOfPairsMagicSums = new List<int[]> { };
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int num1 = arr[i];
                for(int j = i + 1; j < arr.Length; j++)
                {
                    int num2 = arr[j];
                    if (num1 + num2 == magicSum)
                    {
                        int[] pair = { num1, num2 };
                        matrixOfPairsMagicSums.Add(pair);
                    }
                }
            }

            foreach (int[] item in  matrixOfPairsMagicSums)
            {
                Console.WriteLine(string.Join(" ", item));
            }

        }
    }
}