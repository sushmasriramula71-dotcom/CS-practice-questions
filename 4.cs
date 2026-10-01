// Employee directory
// Create an Employee class with Name, Department and Salary. Hold several in a List, then build
// a Dictionary mapping each department to the total salary paid in it. Print each department
// total and the highest-paying department.
// E X P E C T E D O U T P U T
// IT: 195000
// HR: 85000
// Sales: 120000
// Highest paying: IT

using System;
using System.Collections.Generic;

class Employee
{
    public string Name;
    public string Department;
    public int Salary;

    public Employee(string name, string department, int salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees=new List<Employee>
        {
            new Employee("Rahul","IT",100000),
            new Employee("Suresh","IT",95000),
            new Employee("Priya","HR",85000),
            new Employee("Anil","Sales",70000),
            new Employee("Kiran","Sales",50000)
        };

        Dictionary<string,int> departmentSalary=new Dictionary<string,int>();

        foreach (Employee emp in employees){
            if(departmentSalary.ContainsKey(emp.Department))
            {
                departmentSalary[emp.Department]+=emp.Salary;
            }
            else
            {
                departmentSalary[emp.Department]=emp.Salary;
            }
        }

        foreach (var item in departmentSalary)
        {
            Console.WriteLine(item.Key+":"+item.Value);
        }
        string highestDepartment="";
        int highestSalary=0;

        foreach (var item in departmentSalary)
        {
            if (item.Value>highestSalary)
            {
                highestSalary=item.Value;
                highestDepartment=item.Key;
            }
        }

        Console.WriteLine("Highest paying:"+highestDepartment);
    }
}