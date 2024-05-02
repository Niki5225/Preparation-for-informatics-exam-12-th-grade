namespace ValidUsername
{
    class Task
    {
        static void Main()
        {
            List<string> usernames = Console.ReadLine().Split(", ").ToList();
            List<string> validUsernames = new List<string>();

            foreach (string username in usernames) 
            {
                bool isValid = true;
                foreach (char ch in username) 
                {
                    if (!(char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
                    {
                        isValid = false;
                    }
                }

                if (!(username.Length > 3 && username.Length < 16))
                {
                    isValid = false;
                }

                if (isValid)
                {
                    validUsernames.Add(username);
                }
            }

            foreach(string username in validUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}