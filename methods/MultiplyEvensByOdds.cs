namespace MultiplyEvensByOdds
{
    class Task
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            char[] strNumber = number.ToString().ToCharArray();

            int[] arrEvenOddSum = CalculateEvenOddSumOfNum(strNumber);

            int evenSum = arrEvenOddSum[0];
            int oddSum = arrEvenOddSum[1];

            Console.WriteLine(evenSum * oddSum);
        }

        static int[] CalculateEvenOddSumOfNum(char[] strNum)
        {
            int evenSum = 0;
            int oddSum = 0;

           

            for (int i = 0; i < strNum.Length; i++)
            {
                int currentNum = int.Parse(strNum[i].ToString());
                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                } else
                {
                    oddSum += currentNum;
                }
            }

            int[] resultArr = new int[2] { evenSum, oddSum };

            return resultArr;
        }
    }
}