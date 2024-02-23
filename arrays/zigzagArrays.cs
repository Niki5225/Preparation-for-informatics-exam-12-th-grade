namespace Task
{
    class Task
    {
        static void Main()
        {
            int coupleOfNums = int.Parse(Console.ReadLine());
            int[] arr1 = new int[coupleOfNums];
            int[] arr2 = new int[coupleOfNums];

            for (int i = 0; i < coupleOfNums; i++)
            {
                int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if(i % 2 == 0)
                {
                    arr1[i] = inputArr[0];
                    arr2[i] = inputArr[1];
                } else
                {
                    arr1[i] = inputArr[1];
                    arr2[i] = inputArr[0];
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));

        }
    }
}