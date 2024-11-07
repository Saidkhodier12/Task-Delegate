using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Two;
internal class Employee
{
    public string Name { get; set; }
    public int YearsOfExperience { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int yearsOfExperience, double salary)
    {
        Name = name;
        YearsOfExperience = yearsOfExperience;
        Salary = salary;
    }
}
