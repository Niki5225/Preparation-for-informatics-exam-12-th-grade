
namespace Inheritance
{
    class Task
    {
        static void Main()
        {
            var list = new RandomList();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");

            Console.WriteLine(list.RandomString());

        }
    }
}