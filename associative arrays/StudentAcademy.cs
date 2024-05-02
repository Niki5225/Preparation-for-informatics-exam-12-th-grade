namespace StudentAcademy
{
    class Task
    {
        static void Main()
        {
            int pairOfRows = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();


            for(int i = 0; i < pairOfRows; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (dict.ContainsKey(studentName))
                {
                    dict[studentName].Add(grade);
                } else
                {
                    dict[studentName] = new List<double>() { grade };
                }

            }

            foreach(var item in dict)
            {
                List<double> gradesOfStudent = item.Value;
                double average = gradesOfStudent.Sum() / gradesOfStudent.Count();

                if (average >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {average:F2}");
                }
            }
        }
    }
}