namespace PalindromeIntegers
{
    class Task
    {
        static void Main()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string number = command;
                string reversedNumber = new string(number.Reverse().ToArray());

                if (number == reversedNumber)
                {
                    Console.WriteLine("true");
                } else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();   

            }
        }
    }
}