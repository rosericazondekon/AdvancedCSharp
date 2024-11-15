using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Person
{
    public Person(string name, int age, decimal salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
}