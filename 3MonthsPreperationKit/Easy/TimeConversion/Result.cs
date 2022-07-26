namespace TimeConversion
{
    class Result
    {
        public static string TimeConversion(string s)
        {
            DateTime dateTime = Convert.ToDateTime(s);
            TimeSpan hourOnly = dateTime.TimeOfDay;
            return Convert.ToString(hourOnly);
        }
    }
}

