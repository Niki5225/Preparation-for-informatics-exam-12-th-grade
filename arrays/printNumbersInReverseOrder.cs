namespace Task
{
    class Task
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                arr[i] = currentNum;
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}