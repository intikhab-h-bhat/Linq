using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.WhereFilter
{
    public class WherFilter
    {

        public void WhereFilterDemo()
        {
            List<EmployeeTechnology> methodSyntex =EmployeeTechnology.GetEmpTech().Where(e=>e.Salary>200000 && e.Age>24).ToList();

            List<EmployeeTechnology>queryType= (from e in EmployeeTechnology.GetEmpTech()
                                               where e.Salary > 200000 && e.Age >24 select e).ToList();

            foreach(var et in queryType)
            {
                Console.WriteLine(et.Name);

                foreach(var tech in et.Technology)
                {
                    Console.Write(tech);
                    Console.Write(",");
                }
            }

        }


    }

    public class EmployeeTechnology()
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Technology { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }


        public static List<EmployeeTechnology> GetEmpTech()
        {

            List<EmployeeTechnology> employeeTechnologies = new List<EmployeeTechnology>()
            {

                new EmployeeTechnology() {Id=1, Name="Intikhab",Technology=new List<string>() {"Python","C#","JavaScript","Azure"},Salary=500000,Age=43 },
                new EmployeeTechnology() {Id=1, Name="Rahil",Technology=new List<string>() {"C#","JavaScript","Azure"} ,Salary=300000,Age=25},
                 new EmployeeTechnology() {Id=1, Name="Abc",Technology=new List<string>() {"Python","C#","JavaScript","Azure"},Salary=200000,Age=35 },
                new EmployeeTechnology() {Id=1, Name="EFG",Technology=new List<string>() {"C#","JavaScript","Azure"} ,Salary=600000,Age=22},

            };

            return employeeTechnologies;

        }

    }
}
