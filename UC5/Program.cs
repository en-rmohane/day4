using System;
class Program
{
    public const int Is_PART_TIME = 1;
    public const int Is_FULL_TIME = 2;
    public const int EMP_RATE_PER_HRS = 20;
    public const int NUM_OF_WORKING_DAYS = 2;

    static void Main(string[] args)
    {
        int EmpHrs = 0;
        int EmpWage = 0;
        int TotalEmpWage = 0;
        for (int day = 0; day < NUM_OF_WORKING_DAYS;day++)
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case Is_PART_TIME:
                    EmpHrs = 4;
                    break;
                case Is_FULL_TIME:
                    EmpHrs = 8;
                    break;
                default:
                    EmpHrs = 0;
                    break;
            }
            EmpWage = EmpHrs * EMP_RATE_PER_HRS;
            TotalEmpWage += EmpWage;
            Console.WriteLine("Emp wage " + EmpWage);

        }
        Console.WriteLine("Total employee wage" + TotalEmpWage);
    }

}