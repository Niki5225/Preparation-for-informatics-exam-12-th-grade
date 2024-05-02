namespace Courses
{
    class Task
    {
        static void Main()
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] data = command.Split(" : ");
                string courseName = data[0];
                string student = data[1]; 

                if (dict.ContainsKey(courseName))
                {
                    dict[courseName].Add(student);
                } else
                {
                    dict[courseName] = new List<string> { student };
                }
            }

            foreach(var item in dict)
            {
                List<string> students = item.Value;
                Console.WriteLine($"{item.Key}: {students.Count}");
                foreach(var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}