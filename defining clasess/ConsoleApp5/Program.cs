namespace DefiningClasses
{
    class StartUp
    {
        static void Main()
        {
            string[] date1 = Console.ReadLine().Split().ToArray();
            string[] date2 = Console.ReadLine().Split().ToArray();

            string formattedDate1 = $"{date1[0]}-{date1[1].PadLeft(2, '0')}-{date1[2].PadLeft(2, '0')}";
            string formattedDate2 = $"{date2[0]}-{date2[1].PadLeft(2, '0')}-{date2[2].PadLeft(2, '0')}";

            DateModifier dateModifier = new DateModifier();

            int daysDifference = dateModifier.CalculateDifference(formattedDate1, formattedDate2);

            Console.WriteLine(daysDifference);
        }
    }
}