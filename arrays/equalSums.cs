namespace EqualSums
{
    public class Task
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for(int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}