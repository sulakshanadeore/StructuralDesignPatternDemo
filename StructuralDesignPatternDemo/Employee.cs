using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatternDemo
{
    public  class Employee
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string Job { get; set; }

        public Employee(int id,string name,string job,int sal)
        {
            Empid=id;
            EmpName=name;
            Salary=sal;
            Job=job;    
        }
    }


    //Third Party class created by vendor of the company who provides talent
    public class SalaryCalculations
    {
        public void ProcessSalary(List<Employee> employees)
        { 
        //calculate
        //deposit
        
        }

    }
}
