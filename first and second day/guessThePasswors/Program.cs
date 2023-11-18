namespace guessThePassword;

public class GuessThePassword
{
    const string PASSWORD = "s3cr3t!P@ssw0rd";
    static void Main(string[] args)
    {
        string passwordInput = Console.ReadLine();

        if (passwordInput == PASSWORD)
        {
            Console.WriteLine("Welcome!");
        } else
        {
            Console.WriteLine("Wrong password");
        }
    }
}