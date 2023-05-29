using System;
class Program
{
    public const int Is_PART_TIME = 1;
    public const int Is_FULL_TIME = 2;
    public const int EMP_RATE_PER_HRS = 20;
    public const int NUM_OF_WORKING_DAYS = 2;
    public const int MAX_HRS_IN_MONTH = 10;

    static void Main(string[] args)
    {
        int TotlEmpHrs = 0;
        int Emphrs = 0;
        int TotalEmpworking_Day  = 0;
        while(TotlEmpHrs<= MAX_HRS_IN_MONTH && TotalEmpworking_Day<NUM_OF_WORKING_DAYS)
        {
            TotalEmpworking_Day++;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case Is_PART_TIME:
                    Emphrs = 4;
                    break;
                case Is_FULL_TIME:
                    Emphrs = 8;
                    break;
                default:
                    Emphrs = 0;
                    break;
            }
            TotlEmpHrs += Emphrs;
            Console.WriteLine("DAY-" + TotalEmpworking_Day + " emp hrs " + Emphrs);
        }
        int totalempwage = TotlEmpHrs * EMP_RATE_PER_HRS;
        Console.WriteLine("TOTAL EMP WAGE " + totalempwage);
    }
}