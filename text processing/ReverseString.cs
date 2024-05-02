namespace ReverseString
{
    class Task
    {
        static void Main()
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string reversedString = new string(command.Reverse().ToArray());

                Console.WriteLine($"{command} = {reversedString}");
            }
        }
    }
}