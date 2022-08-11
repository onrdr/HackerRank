
int test_cases = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < test_cases; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    bool ans = IsSmartNumber(num);

    Console.WriteLine(ans == true? "YES" : "NO"); 

}
static bool IsSmartNumber(int num)
{
    int val = (int)Math.Sqrt(num);

    // Before correction the code was :  " return num / val == 1; " 
    // The corrected code is below
    return val * val == num; 
    
}

Console.ReadKey(); 





