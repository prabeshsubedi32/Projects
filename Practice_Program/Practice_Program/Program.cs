using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public virtual void PrintFullName()
    {
        Console.WriteLine("I am an Employee");
    }
}

public class FullTimeEmployee : Employee
{
    public int FullTimeSalary;

    public override void PrintFullName()
    {
        Console.WriteLine("I am FullTime");
    }

}

public class PartTimeEmployee : Employee
{
    public int PartTimeSalary;

    public override void PrintFullName()
    {
        Console.WriteLine("I am PartTime");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Employee E1 = new Employee();
        Employee E2 = new FullTimeEmployee();
        Employee E3 = new PartTimeEmployee();
        

        E1.PrintFullName();
        E2.PrintFullName();
        E3.PrintFullName();
        Console.ReadKey();
       
    }
}