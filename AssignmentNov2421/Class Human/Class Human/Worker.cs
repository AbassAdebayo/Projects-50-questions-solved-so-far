using System;

namespace Class_Human
{
    public class Worker: Human
    {
        decimal Wage;
        private double time;
        public Worker(string firstName, string lastName, decimal wage, double time): base(firstName,lastName)
        {
            Wage = wage;
        }
        


        public string PrintWage(decimal yearlyWage, double hour)
        {
            decimal hourlyWage = Wage /(decimal)hour;



            return $"The hourly wage is #{hourlyWage}";
        }

    }
}