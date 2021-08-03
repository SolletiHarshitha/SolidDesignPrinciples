using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDesignPrinciples.Dependency_Inversion_Principle
{
    public interface ISalaryCalculator
    {
        float CalculateSalary(int numberOfDays,float hoursWorkedPerDay, int ratePerHour);
    }

    public class SalaryCalculator : ISalaryCalculator
    {
        public float CalculateSalary(int numberOfDays, float hoursWorkedPerDay, int ratePerHour) => numberOfDays*hoursWorkedPerDay * ratePerHour;
    }
    class EmployeeDetails
    {
        private readonly ISalaryCalculator salaryCalculator;
        public int numberOfDays { get; set; }
        public float hoursWorkedPerDay { get; set; }
        public int ratePerHour { get; set; }
        public EmployeeDetails(ISalaryCalculator Calculator)
        {
            salaryCalculator = Calculator;
        }
        public float GetSalary()
        {
            return salaryCalculator.CalculateSalary(numberOfDays,hoursWorkedPerDay, ratePerHour);
        }
    }
}
