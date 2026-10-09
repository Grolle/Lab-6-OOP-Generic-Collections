using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_OOP_Generic_Collections
{
    internal class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Salary { get; set; }

        public Employee(int iD, string name, Gender gender, int salary)
        {
            ID = iD;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public override string ToString()//overwrite tostring to print employee data
        {
            return $"Employee with ID: {ID} Name: {Name} Gender: {Gender} and Salary: {Salary} ";
        }
    }
}
