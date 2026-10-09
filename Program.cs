namespace Lab_6_OOP_Generic_Collections
{
    internal class Program
    {

        static void Main(string[] args)
        {
            EmployeeGenerator employeeGenerator = new();
            Stack<Employee> employees = new();

            Employee emp_1 = employeeGenerator.GenerateEmployee("Hassan", Gender.Male);
            Employee emp_2 = employeeGenerator.GenerateEmployee("Agustus", Gender.Male);
            Employee emp_3 = employeeGenerator.GenerateEmployee("Luna", Gender.Female);
            Employee emp_4 = employeeGenerator.GenerateEmployee("Torsten", Gender.Male);
            Employee emp_5 = employeeGenerator.GenerateEmployee("Tuva", Gender.Female);

            employees.Push(emp_1);
            employees.Push(emp_2);
            employees.Push(emp_3);
            employees.Push(emp_4);
            employees.Push(emp_5);

            
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
                Console.WriteLine("Items left in stack " + employees.Count);
            }

            Console.WriteLine("Retrieved using pop method");

            while (employees.TryPop(out var emp))
            {
                Console.WriteLine(emp);
                Console.WriteLine("Items left in stack " + employees.Count);
            }

            employees.Push(emp_1);
            employees.Push(emp_2);
            employees.Push(emp_3);
            employees.Push(emp_4);
            employees.Push(emp_5);

            Console.WriteLine("Retrieved using peek method");

            Console.WriteLine(employees.Peek());
            Console.WriteLine("Items left in stack " + employees.Count);
            Console.WriteLine(employees.Peek());
            Console.WriteLine("Items left in stack " + employees.Count);

            if (employees.Contains(emp_3))
            {
                Console.WriteLine("emp 3 is in stack!");
            }                
            else
            {
                Console.WriteLine("emp 3 is not in stack!");
            }
                
            List<Employee> employeeList =
            [
                emp_1,
                emp_2,
                emp_3,
                emp_4,
                emp_5
            ];

            if (employeeList.Contains(emp_2))
            {
                Console.WriteLine("Employee 2 exists in list!");
            }   
            else
            {
                Console.WriteLine("Employee 2 does not exist in list!");
            }
                
            Console.WriteLine($"First female in list : {employeeList.First(x=>x.Gender == Gender.Female)}");

            foreach (var m in employeeList.FindAll(x => x.Gender == Gender.Male)) //loopa igenom listan vi får tillbaka från FindAll och printa employee
            {
                Console.WriteLine(m);
            }
               
        }
    }
}
