using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_OOP_Generic_Collections
{
    internal class EmployeeGenerator
    {
        private readonly Random rnd;
        public EmployeeGenerator() { rnd = new(); }
        public Employee GenerateEmployee(string name, Gender gender)
        {
            int salary = rnd.Next(0,10000000); //very salary-equal company
            Employee emp = new(IdGenerator.GenerateUniqueID(),name, gender, salary);

            return emp;
    }

    }

}
    
