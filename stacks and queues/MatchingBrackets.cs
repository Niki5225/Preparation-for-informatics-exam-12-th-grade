namespace MatchingBrackets
{
    class stask
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            Stack<int> indicesOfOpeningBrackets = new Stack<int>();

            for(int i = 0; i < expression.Length; i++) 
            {
                char ch = expression[i];
                if (ch == '(')
                {
                    indicesOfOpeningBrackets.Push(i);
                } else if (ch == ')')
                {
                    int startingIndex = indicesOfOpeningBrackets.Pop();
                    int endIndex = i;
                    Console.WriteLine(expression.Substring(startingIndex, endIndex - startingIndex + 1));
                }
            }
        }
    }
}