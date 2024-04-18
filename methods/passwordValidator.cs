namespace PasswordValidator
{
    class Task
    {
        static void Main()
        {
            string password = Console.ReadLine();

            bool isValid = true;

            if (!HasLenBetween6and10Chars(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (!HasOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!HasAtLeast2Digits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool HasAtLeast2Digits(string input)
        {
            int count = 0;
            foreach (var character in input)
            {
                if (count == 2)
                {
                    break;
                }
                if (char.IsDigit(character))
                {
                    count++;
                }
            }

            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool HasOnlyLettersAndDigits(string input)
        {
            bool valid = true;
            foreach (var value in input)
            {
                if (!(char.IsLetter(value) || char.IsDigit(value)))
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        static bool HasLenBetween6and10Chars(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    
}