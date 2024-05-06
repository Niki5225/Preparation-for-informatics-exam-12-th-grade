namespace AverageStudentGrades
{
    class Task
    {
        static void Main()
        {
            int studentCount = int.Parse(Console.ReadLine()); 
            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < studentCount; i++)
            {
                string[] studentInfo = Console.ReadLine().Split().ToArray();
                string name = studentInfo[0];
                decimal grade = decimal.Parse(studentInfo[1]);

                if (studentGrades.ContainsKey(name))
                {
                    studentGrades[name].Add(grade);
                } else
                {
                    studentGrades[name] = new List<decimal> { grade };
                }
            }

            foreach (var student in studentGrades)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}