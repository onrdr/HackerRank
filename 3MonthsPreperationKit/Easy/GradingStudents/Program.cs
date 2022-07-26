namespace GradingStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new() { 29, 44, 67 };

            Result.GradingStudents(grades).ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}