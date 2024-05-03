namespace ExtractFile
{
    class Task
    {
        static void Main()
        {
            string[] location = Console.ReadLine().Split("\\");

            string file = location[location.Length - 1];
            string[] fileData = file.Split(".");
            string fileName = fileData[0];
            string fileExtension = fileData[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}