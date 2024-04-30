namespace AppendArrays
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<int> result = AppendArrays(input);

            Console.WriteLine($"{string.Join(" ", result)}");
        }

        static List<int> AppendArrays(string input)
        {
            List<int> appendedList = new List<int>();
            string[] arrayStrings = input.Split('|');

            for (int i = arrayStrings.Length - 1; i >= 0; i--)
            {
                string arrayString = arrayStrings[i].Trim();

               
                string[] numberStrings = arrayString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string numStr in numberStrings)
                {
                    appendedList.Add(int.Parse(numStr));
                }
            }

            return appendedList;
        }
    }
}