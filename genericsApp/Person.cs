using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; } 
    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Age: {Age} years, Salary: {Salary:C}\n";
    }
}