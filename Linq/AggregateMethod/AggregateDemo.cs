using Linq.Select_SelectMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.AggregateMethod
{
    public class AggregateDemo
    {
        List<int> list1 = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            16, 17, 18, 19, 20, 21, 22, 23, 24,
        };
        public void AggregateInt()
        {

            //var qs = (from i in list1 select i).Sum();
            //var qm = list1.Sum();
            // var qs =(from i in list1 select i).Max();
            //var qm = list1.Max();
            //var qs = (from i in list1 select i).Min();
            //var qm = list1.Min();
            //var qs = (from i in list1 select i).Count();
           // var qm = list1.Count();
            //var qs = (from i in list1 select i).Average();
            var qm = list1.Average();

            Console.WriteLine(qm);
        }


        public void AggregateWithWhere() {

            //var qm=list1.Where(x => x > 20).Sum();

            int qs = (from i in list1 where i > 20 select i).Count(); 

            Console.WriteLine(qs);

        }
       
        public void AggregateWithComplexType()
        {
            List<EmployeeInfo> emp = new List<EmployeeInfo>() { 
            
                new EmployeeInfo(){Id=1, Name="Javaid",Salary=12000},
                new EmployeeInfo(){Id=2, Name="Adil",Salary=11000},
                new EmployeeInfo(){Id=3, Name="Tabasum",Salary=15000},
                new EmployeeInfo(){Id=4, Name="Masarat",Salary=30000},
                new EmployeeInfo(){Id=5, Name="Intikhab",Salary=25000},
            };
            
            

            //var qs=emp.Sum(i=>i.Salary);
            //var qs= (from i in emp select i).Sum(i=> i.Salary);

            //var qm= emp.Count();
            //var qs= (from i in emp select i).Average(x=>x.Salary);
            //var qm = emp.Average(x=>x.Salary);
            var qm= emp.Where(x=>x.Salary> 12000).Average(x=>x.Salary);


            Console.WriteLine(qm);


        }


    }
}
