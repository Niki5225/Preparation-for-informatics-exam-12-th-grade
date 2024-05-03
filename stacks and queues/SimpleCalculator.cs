namespace SimpleCalculator
{
    class Task
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();  

            foreach(string s in input.Reverse())
            {
                stack.Push(s);
            }

            int result = int.Parse(stack.Pop());
            while(stack.Count > 0)
            {
                string operation = stack.Pop();
                int number = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    result += number;
                } else
                {
                    result -= number;
                }
            }
            Console.WriteLine(result);
        }
    }
}