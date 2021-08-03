using SolidDesignPrinciples.Dependency_Inversion_Principle;
using SolidDesignPrinciples.Interface_Segregation_Principle;
using SolidDesignPrinciples.Liskov_Substitution_Principle;
using SolidDesignPrinciples.Open_Closed_Principle;
using SolidDesignPrinciples.Single_Responsibility_Principle;
using System;

namespace SolidDesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Solid Design Principles--------------");
            Console.WriteLine("1.Single Responsibilty Principle");
            Console.WriteLine("2.Open Closed Principle");
            Console.WriteLine("3.Liskov Substitution Principle");
            Console.WriteLine("4.Interface Segregation Principle");
            Console.WriteLine("5.Dependency Inversion Principle");
            Console.Write("\nEnter the option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    var report = new WorkReport();
                    report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
                    report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });
                    report.AddEntry(new WorkReportEntry { ProjectCode = "456Eh", ProjectName = "Project3", SpentHours = 8 });
                    Console.WriteLine(report.ToString());
                    report.RemoveEntryAt(1);
                    Console.WriteLine("After Removing the entry");
                    Console.WriteLine(report.ToString());
                    break;
                case 2:
                    Invoice FInvoice = new FinalInvoice();
                    Invoice PInvoice = new ProposedInvoice();
                    Invoice RInvoice = new RecurringInvoice();
                    double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
                    double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
                    double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
                    Console.WriteLine("Final Invoice Amount : "+FInvoiceAmount);
                    Console.WriteLine("Proposed Invoice Amount : " + PInvoiceAmount);
                    Console.WriteLine("Recurring Invoice Amount : " + RInvoiceAmount);
                    break;
                case 3:
                    Fruit fruit = new Orange();
                    Console.WriteLine(fruit.GetColor());
                    fruit = new Apple();
                    Console.WriteLine(fruit.GetColor());
                    break;
                case 4:
                    Console.WriteLine("----------------------Jeans---------------------");
                    IProduct jeans = new Jeans();
                    Console.WriteLine("ID : " + jeans.ID);
                    Console.WriteLine("Weight in kgs : " + jeans.Weight);
                    Console.WriteLine("Stock : " + jeans.Stock);
                    IPants jeans2 = new Jeans();
                    Console.WriteLine("Leg size in inches : " + jeans2.Inseam);
                    Console.WriteLine("Size of the waist : " + jeans2.WaistSize);
                    Console.WriteLine("---------------------Hat------------------");
                    IProduct baseballcap = new BaseballCap();
                    Console.WriteLine("ID : " + baseballcap.ID);
                    Console.WriteLine("Weight in kgs : " + baseballcap.Weight);
                    Console.WriteLine("Stock : " + baseballcap.Stock);
                    IHat baseballcap2 = new BaseballCap();
                    Console.WriteLine("Size of the hat : " + baseballcap2.HatSize);
                    break;
                case 5:
                    var employeeDetailsModified = new EmployeeDetails(new SalaryCalculator());
                    employeeDetailsModified.numberOfDays = 25;
                    employeeDetailsModified.hoursWorkedPerDay = 8;
                    employeeDetailsModified.ratePerHour = 100;
                    Console.WriteLine($"\nThe Total Pay is {employeeDetailsModified.GetSalary()}");
                    break;
            }
        }
    }
}
