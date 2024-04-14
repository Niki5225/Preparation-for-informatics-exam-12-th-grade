namespace MathPower
{
    class Task
    {
        static void Main()
        {
            double number = int.Parse(Console.ReadLine());
            double power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPowerFunc(number, power));  
        }

        private static double MathPowerFunc(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}