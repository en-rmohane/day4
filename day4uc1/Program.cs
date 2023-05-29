using System;
class Program
{
    static void Main(string[] args)
    {
        int is_full_time = 1;
        Random random = new Random();
        int empcheck = random.Next(0, 2);
        if (empcheck == is_full_time)
        {
            Console.WriteLine("employee is present");

        }
        else
        {
            Console.WriteLine("employee is absent");
        }
    }
}