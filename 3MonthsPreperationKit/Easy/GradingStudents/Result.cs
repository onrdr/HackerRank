namespace GradingStudents
{
    class Result
    {
        public static List<int> GradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                int diff = 5 - grades[i] % 5;
                if (grades[i] >= 38 && diff < 3)
                    grades[i] += diff;
            } 
            return grades;
        } 
    }
}