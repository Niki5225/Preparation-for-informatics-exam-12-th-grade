using System;
class Task
{
    static void Main()
    {
        string user = Console.ReadLine();
        int failCount = 0;
        

        while(true)
        {
            string reversedPass = Console.ReadLine();
            if (reversedPass == null)
            {
                continue;
            }
            char[] charArr = reversedPass.ToCharArray();
            Array.Reverse(charArr);
            string pass = new string(charArr).Trim();
            if (pass == user)
            {
                Console.WriteLine($"User {user} logged in.");
                return;
            }
            failCount++;

            if (failCount == 4) 
            {
                Console.WriteLine($"User {user} blocked!");
            } else
            {
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
        
    }
}