namespace CardGame
{
    class Task
    {
        static void Main()
        {
            List<int> hand1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            List<int> hand2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            while(hand1.Count > 0 && hand2.Count > 0) 
            {
                int card1 = hand1[0];
                int card2 = hand2[0];

                if(card1 == card2)
                {
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                } else if (card1 > card2)
                {
                    hand1.Add(card2);
                    hand1.Add(card1);
                    hand2.RemoveAt(0);
                    hand1.RemoveAt(0);
                } else
                {
                    hand2.Add(card1);
                    hand2.Add(card2);
                    hand1.RemoveAt(0);
                    hand2.RemoveAt(0);
                }
            }

            if (hand1.Count > 0)
            {
                int sum = hand1.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            } else if (hand2.Count > 0)
            {
                int sum = hand2.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}