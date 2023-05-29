using System;
class Program
{
    public const int Is_patr_time = 1;
    public const int is_full_time = 2;
    public const int emp_rate_per_hrs = 20;

    static void Main(string[] args)
    {
        int emp_hrs = 0;
        int empWage = 0;
        Random random = new Random();
        int empcheck = random.Next(0, 3);
        switch(empcheck)
        {
            case Is_patr_time:
                emp_hrs = 4;
                break;
            case is_full_time:
                emp_hrs = 8;
                break;
            default:
                emp_hrs = 0;
                break;
        }
        empWage = emp_hrs * emp_rate_per_hrs;
        Console.WriteLine("emp wage" + empWage);
            
    }
}