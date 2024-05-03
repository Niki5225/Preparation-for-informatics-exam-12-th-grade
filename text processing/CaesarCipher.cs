namespace CaesarCipher
{
    class Task
    {
        static void Main()
        {
            string textToEncrypt = Console.ReadLine();
            string encryptedText = "";

            foreach(char ch in textToEncrypt)
            {
                int charCode = (int)ch;
                charCode += 3;
                
                char newChar = (char) charCode;

                encryptedText += newChar;
            }
            Console.WriteLine(encryptedText);
        }
    }
}