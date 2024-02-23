namespace Task
{
    class Task
    {
        static void Main()
        {
            string[] daysOfWeek = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int dayOfWeekNum = int.Parse(Console.ReadLine());

            if (dayOfWeekNum > 7 || dayOfWeekNum < 1)
            {
                Console.WriteLine("Invalid day!");
            } else
            {
                Console.WriteLine(daysOfWeek[dayOfWeekNum - 1]);
            }
        }
    }
}