using System;
class Program
{
    static void Main(string[] args)
    {
        int Is_full_time = 1;
        int Emp_Rate_Per_Hrs = 20;
        int emphrs = 0;
        int empwage = 0;
        Random random = new Random();
        int empcheck = random.Next(0, 2);
        if(empcheck == Is_full_time)
        {
            emphrs = 8;

        }
        else
        {
            emphrs = 0;


        }
        empwage = emphrs * Emp_Rate_Per_Hrs;
        Console.WriteLine("Empwage" + empwage);
    }
}