namespace Task
{
    class Task
    {
        static void Main()
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();
            List<string> commonElements = new List<string>();

            for (int i = 0; i < arr2.Length; i++)
            {
                string el1 = arr2[i];
                for(int j = 0; j < arr1.Length; j++)
                {
                    string el2 = arr1[j];
                    if (el1 == el2)
                    {
                        commonElements.Add(el1);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", commonElements));

        }
    }
}