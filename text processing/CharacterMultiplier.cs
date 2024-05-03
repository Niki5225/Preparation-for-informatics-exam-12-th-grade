namespace CharacterMultiplier
{
    class Task
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Split().ToArray();
            Console.WriteLine(getSumOfCharacterCodes(data));
        }

        static int getSumOfCharacterCodes(string[] data)
        {
            string str1 = data[0];
            string str2 = data[1];
            int reachedIndex = Math.Min(str1.Length - 1, str2.Length - 1);
            string largerStr = str1.Length > str2.Length ? str1 : str2;


            int sum = 0;

            for (int i = 0; i <= reachedIndex; i++)
            {
                sum += (int)str1[i] * (int)str2[i];
            }

            for (int i = reachedIndex + 1; i < largerStr.Length; i++)
            {
                sum += (int)largerStr[i];
            }

            return sum;
        }
    }
}