using System.Text;

namespace CharactersRange
{
    class Task
    {
        static void Main()
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            
            int char1Value = GetAsciiValueOfChar(char1);
            int char2Value = GetAsciiValueOfChar(char2);

            for(int i = Math.Min(char1Value, char2Value) + 1; i < Math.Max(char1Value, char2Value); i++) 
            {
                Console.Write(GetAsciiValueOfInt(i) + " ");
            }



        }

        static int GetAsciiValueOfChar(char currentChar)
        {
           int value = Convert.ToInt32(currentChar);
           return value;
        }

        static char GetAsciiValueOfInt(int value)
        {
             return Convert.ToChar(value);

        }


    }
}