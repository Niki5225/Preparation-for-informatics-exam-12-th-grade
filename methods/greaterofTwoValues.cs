namespace GreaterOfTwoValues
{
    class Task
    {
        static void Main()
        {
            string typeOfInput = Console.ReadLine();
            string input1 = Console.ReadLine(); 
            string input2 = Console.ReadLine();
            

            if (typeOfInput == "int")
            {
                Console.WriteLine(GetMax(int.Parse(input1), int.Parse(input2)));
            } else if (typeOfInput == "string")
            {
                Console.WriteLine(GetMax(input1, input2));
            } else
            {
               Console.WriteLine(GetMax(char.Parse(input1), char.Parse(input2)));
            }


        }

        static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) > 0)
            {
                return str1;
            } else
            {
                return str2;
            }
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            } else
            {
                return num2;
            }
        }

        static char GetMax(char char1, char char2)
        {
            if (char1 > char2) 
            {
                return char1;
            } else
            {
                return char2;
            }
        }
    }
}