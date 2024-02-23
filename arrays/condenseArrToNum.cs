namespace Task
{
    class Task
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (arr.Length != 1)
            {
                arr = CondenseArr(arr);
            }

            Console.WriteLine(arr[0]);
        }

        static int[] CondenseArr(int[] nums)
        {
            int[] condensed = new int[nums.Length - 1];

            for(int i = 0; i < nums.Length - 1; i++) 
            {
                condensed[i] = nums[i] + nums[i + 1];
            }

            return condensed;
        }
    }
}