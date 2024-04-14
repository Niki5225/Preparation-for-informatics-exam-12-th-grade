namespace MaxSequenceOfEqualElements
{
    class Task
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] maxSequence = { };
            List<int> currentSequence = new List<int> { arr[0], };

            for (int i = 1; i < arr.Length; i++)
            {
                if (currentSequence[0] == arr[i])
                {
                    currentSequence.Add(arr[i]);
                } else
                {
                    int[] ints = currentSequence.ToArray();
                    if (ints.Length > maxSequence.Length)
                    {
                        maxSequence = ints;
                    }
                    currentSequence = new List<int> {arr[i]};
                }
            }

            int[] finalInts = currentSequence.ToArray();
            if (finalInts.Length > maxSequence.Length)
            {
                maxSequence = finalInts;
            }
            Console.WriteLine(string.Join(" ", maxSequence));

        }
    }
}