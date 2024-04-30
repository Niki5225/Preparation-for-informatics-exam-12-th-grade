namespace BombNumbers
{
    class Task
    {
        static void Main()
        {
            List<int> lst = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            int[] bombNumAndPower = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int bombNum = bombNumAndPower[0];
            int power = bombNumAndPower[1];

            while (lst.IndexOf(bombNum) != -1)
            {
                int index = lst.IndexOf(bombNum);
                int startingPoint = index - power < 0 ? 0 : index - power;
                int endPoint = index + power < lst.Count() ? index + power : lst.Count - 1;

                for(int i = startingPoint; i <= endPoint; i++)
                {
                    lst.RemoveAt(startingPoint);
                }

            }

            int sum = 0;

            foreach(int i in lst)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            
        }
    }
}