using Linq.Data;
using Linq.IenumIqura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Linq.OrderByDemo
{
    public class OrderByAssign
    {

        public void OrderByWithInt()
        {
            var intArray1 = new int[] { 1, 2, 3, 4, 10, 11, 12, 5, 6, 7, 8, 9 };
            var qs = from a in intArray1 orderby a descending select a;
            var qm = intArray1.OrderBy(a => a);

            foreach (var a in qm)
            {
                Console.WriteLine(a);
            }
        }

        public void OrderByWithString()
        {

            var strArray = new string[] { "Maviya", "Abdullah", "Hafsa", "Adn", "Tabeen", "Sumaida" };

            var qs = from a in strArray orderby a ascending select a;
            var qm = strArray.OrderBy(a => a);

            foreach (var a in qm)
            {
                Console.WriteLine(a);
            }

        }

        public void OrderByWithComplexType()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Waseem", Address = "Pulwama",Salary=10000 },
                new Employee() { Id = 2,Name="Javid Ahamed",Address="Parrypora",Salary=12000},
                new Employee() { Id = 3,Name="Kaiser",Address="Nowgam",Salary=20000}
                
            };

                //var qs = (from x in emp orderby x.Name select x) ;
                //var qm = emp.Select(a=>a).OrderBy(a=>a.Name);


            var qs = from a in emp where a.Salary>10000 orderby a.Name ascending select a;
            var qm= emp.Where(a=>a.Salary>10000).OrderBy(a=>a.Name);


            foreach(var a in qm)
            { 
                Console.WriteLine($"{a.Id} {a.Name} {a.Salary}"); 
            }
        }


    }
}
