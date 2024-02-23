namespace Task
{
    class Task
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();


            bool areEqual = true;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    areEqual = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if (areEqual)
            {
                int sum = FindSumOfArr(arr1);
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }

        static int FindSumOfArr(int[] arr1)
        {
            int sumArr = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sumArr += arr1[i];
            }
            return sumArr;
        } 
    }
}