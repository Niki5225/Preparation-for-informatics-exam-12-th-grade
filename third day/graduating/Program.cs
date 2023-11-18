public class Task
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        double totalSumGrades = 0.00;
        int gradeCounter = 1;
        int repeatingClassTimes = 0;
        bool isGraduated = true;

        while (gradeCounter <= 12)
        {
            double currentGrade = double.Parse(Console.ReadLine());

            if (currentGrade < 4.00)
            {
                repeatingClassTimes++;
                if (repeatingClassTimes > 1)
                {
                    isGraduated = false;
                    break;
                }
            } else
            {
                gradeCounter++;
                totalSumGrades += currentGrade;

            }

        }

        if (isGraduated)
        {
            double averageGrade = totalSumGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        } else
        {
            Console.WriteLine($"{name} has been excluded at {gradeCounter} grade");
        }
    }
}