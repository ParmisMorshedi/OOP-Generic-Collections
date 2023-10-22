using GeneriscCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace GeneriscCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack < Employee > stack = new Stack<Employee>();

            // Fem objekt av klassen
            Employee employee1 = new Employee(1005, "John", "Male", 25000);
            Employee employee2 = new Employee(1004, "Nima", "Male", 245000);
            Employee employee3 = new Employee(1003, "Anna", "Female", 27000);
            Employee employee4 = new Employee(1002, "Parmis", "Female", 30000);
            Employee employee5 = new Employee(1001, "Ali", "Male", 40000);

            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            Console.WriteLine( "Alla objekt i stacken:");
            foreach (Employee emp in stack)
            {
                emp.PrintInfo();
                Console.WriteLine($"Number of objects in the Stack: {stack.Count}");


            }

            //pop metod
            Stack<Employee> stackCopy = new Stack<Employee>(stack);

            foreach (Employee emp in stackCopy)

            {
                stack.Pop();
                emp.PrintInfo();
                Console.WriteLine($"Number of objects in the Stack:{stack.Count}");
            }
            foreach (Employee emp in stackCopy)
            {
                stack.Push(emp);
            }
            //hämta två objekt med peek metod


            for (int i = 0; i < 2; i++) 
            {
                var emp = stack.Peek();
                emp.PrintInfo();
                Console.WriteLine($"Peeked: {stack.Count}");
                
               

            }
            

            
            //kolla om emp3 finns i stack

            bool exists = stack.Contains(employee3);

            if (exists)
            {
                Console.WriteLine("Employee3 is in stack");
            }
            else
            {
                Console.WriteLine("Employee3 is NOT in stack");
            }

            //del2:
            Console.WriteLine("===============================================================================");

            List<Employee> list = new List<Employee>(stack);

            //kolla om emp2 finns i listan
            exists = list.Contains(employee2);

            if (exists)

            {
                Console.WriteLine("Employee2 is in list");
            }
            else
            {
                Console.WriteLine("Employee2 is NOT in list");
            }


            Console.WriteLine("===============================================================================");

            Employee maleEmployees = list.Find(Male=> Male.Gender == "Male");
            maleEmployees.PrintInfo();
           
            Console.WriteLine("===============================================================================");


            List<Employee> males = list.FindAll(emplyee => emplyee.Gender == "Male");

            foreach (Employee emp in males)
            {
                emp.PrintInfo();
            }
            Console.ReadLine();
        }
    }
}
