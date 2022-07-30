namespace CamelCase
{
    class Direction
    {
        internal static void ToProperFunction(string str)
        {
            string[] strArray = str.Split(';');

            if (str[0].Equals('S'))
            {
                var list = Split.SplitName(strArray[2]);
                Display.SplitList(list);
            }
            if (str[0].Equals('C'))
            {
                if (str[2].Equals('C'))
                {
                    var list = Combine.CombineClass(strArray[2]);
                    Display.CombineList(list);
                }
                if (str[2].Equals('M'))
                {
                    var list = Combine.CombineMethod(strArray[2]);
                    Display.CombineList(list);
                }
                if (str[2].Equals('V'))
                {
                    var list = Combine.CombineVariable(strArray[2]);
                    Display.CombineList(list);
                }
            }
        }
    }

}

