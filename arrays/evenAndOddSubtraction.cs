namespace Task
{
    class Task
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i< arr.Length; i++)
            {
                int currentNum = arr[i];

                if( currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                } else
                {
                    oddSum += currentNum;
                }
            }

            Console.WriteLine( evenSum - oddSum );
        }
    }
}