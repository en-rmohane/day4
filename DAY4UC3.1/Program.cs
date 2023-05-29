using System;
class Program
{
    static void Main(string[] args)
    {
        int Is_part_time = 1;
        int is_full_time = 2;
        int emprate_prhes = 20;
        int empHrs = 0;
        int empWage = 0;
        
        Random random = new Random();
        int empcheck = random.Next(0, 3);
        if (empcheck == Is_part_time)
        {
            empHrs = 4;
        }
        else if (empcheck== is_full_time)
        {
            empHrs = 8;
        }
        else
        {
            empHrs = 0;
        }
        empWage = empHrs * emprate_prhes;
        Console.WriteLine("Emp wage " + empWage);

    }
}