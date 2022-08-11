

class Result
{
    public static int MinimumNumber(int n, string password)
    {
        string special_characters = "!@#$%^&*()-+";
        int digitRequired = 1, lowerRequired = 1, upperRequired = 1, specialRequired = 1;

        foreach (var c in password)
        {
            if (special_characters.Contains(c) && specialRequired != 0)
                specialRequired = 0;

            else if (char.IsDigit(c) && digitRequired != 0)
                digitRequired = 0;

            else if (char.IsUpper(c) && upperRequired != 0)
                upperRequired = 0;

            else if (char.IsLower(c) && lowerRequired != 0)
                lowerRequired = 0;
        }
        int required = digitRequired + lowerRequired + upperRequired + specialRequired;

        return Math.Max(required, 6 - n);
    }

}
