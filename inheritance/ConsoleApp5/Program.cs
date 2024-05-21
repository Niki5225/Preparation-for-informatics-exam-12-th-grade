namespace Inheritance
{
    class Task
    {
        static void Main()
        {
            var stack = new CustomStack();

            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");
            stack.Push("5");
            stack.Push("6");
            stack.Push("7");

            List<string> lst = new List<string>() { "a", "b", "c"};

            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(lst);

            Console.WriteLine(string.Join(" ", stack));

        }
    }
}