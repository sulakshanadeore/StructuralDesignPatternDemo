using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] empArray = new string[5, 4]
            {
                {"101","Jack","SE","10000" },
                { "102","Jim","SE","10000"},
                { "103","Sam","SE","10000"},
                {"104","Harry","SE","12000" },
                { "105","Jill","SE","15000"}
            };

            string id=null, name=null, desig = null, sal = null    ;

            for (int i = 0; i < empArray.GetLength(0); i++)
            {
                for (int j = 0; j < empArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        id = empArray[i, j];
                    }
                    else if (j == 1)
                    {
                        name = empArray[i, j];
                    }
                    else if (j == 2) {
                        desig = empArray[i, j];
                    }
                    else
                    {
                        sal = empArray[i, j];
                    }
                }

                List<Employee> emplist = new List<Employee>();
                emplist.Add(new Employee (Convert.ToInt32(id),name,desig,Convert.ToInt32(sal) ));
                SalaryCalculations salaryCalculations = new SalaryCalculations();
                salaryCalculations.ProcessSalary(emplist);

            }
        }
    }
}
