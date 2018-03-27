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

    public void PrintFullName()
    {
        Console.WriteLine("Their name is {0}", FirstName +" "+ LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public int FullTimeSalary;

    public void new PrintFullName()
    {
        Console.WriteLine("Their name is {0}", FirstName + " " + LastName +"consructor");
    }

}

public class PartTimeEmployee : Employee
{
    public int PartTimeSalary;
}



class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee E1 = new FullTimeEmployee();
        PartTimeEmployee E2 = new PartTimeEmployee();
        E2.PartTimeSalary = 12;
       
    }
}