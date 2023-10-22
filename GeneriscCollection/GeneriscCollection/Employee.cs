using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriscCollection
{
    internal class Employee
    {

        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Gender { get; set; }
        public int Salary { get; set; }


        public Employee(int id,string name,string gender,int salary) 
        {
        
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Salary = salary;
        


        
        }

        public void PrintInfo()

        {

            Console.WriteLine($"{Id}-{Name}-{Gender}-{Salary}");
        }
    }
}
