namespace TopNumber
{
    class Task
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++) 
            {
                if (CheckIfNumIsTopNum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckIfNumIsTopNum(int num)
        {
            bool isTopNum = true;
            bool holdsOneOddDigit = false;
            int sumOfDigits = 0;
            string strNum = num.ToString();

            foreach(var digit in strNum)
            {
                int number = int.Parse(digit.ToString());
                sumOfDigits += number;
                if (number % 2 != 0)
                {
                    holdsOneOddDigit = true;
                }
            }

            if (sumOfDigits % 8 == 0 && holdsOneOddDigit)
            {
                return true;
            } else
            {
                return false;
            }
            
        }
    }
}