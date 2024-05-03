namespace HotPotato
{
    class task
    {
        static void Main()
        {
            Queue<string> participants = new Queue<string>();
            string[] input = Console.ReadLine().Split().ToArray();
            int tosses = int.Parse(Console.ReadLine());

            foreach(string participant in input) 
            {
                participants.Enqueue(participant);
            }

            while(participants.Count > 1)
            {
                for (int i = 1; i < tosses; i++)
                {
                    string participant = participants.Dequeue();
                    participants.Enqueue(participant);
                }
                Console.WriteLine($"Removed {participants.Dequeue()}");
            }

            Console.WriteLine($"Last is {participants.Peek()}");
        }
    }
}