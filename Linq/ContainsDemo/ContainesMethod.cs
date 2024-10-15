using Linq.Select_SelectMany;
using Linq.ThenByDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ContainsDemo
{
    public class ContainesMethod
    {

        public void UsingContains() {

            int[] intNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            string[] strArray = { "Apple", "Bananna", "Orange" };

            //var qm = intNumbers.Contains(3);
            //var qs = (from i in intNumbers select i).Contains(3);
          
            // here the Contains method belog to System.Collection.Generic Namespace
            var qm = strArray.Contains("Apple");
            // here the Contains method belong to System.Linq Namespace
            var qmlinq = strArray.AsEnumerable().Contains("Apple");

            var qs = (from i in strArray select i).Contains("Apple");

            
            Console.WriteLine(qs);

         }

        public void ContainsWithComplexType()
        {
            List<EmpDetails> empDetailsList = new List<EmpDetails>();

            var emp1 = new EmpDetails() { Id = 1, FirstName = "Masarat", LastName = "Abc", Salary = 10000 };
            var emp2 = new EmpDetails() { Id = 2, FirstName = "Javaid", LastName = "Ahamed", Salary = 12000 };
            var emp3 = new EmpDetails() { Id = 3, FirstName = "Adil", LastName = "Dar", Salary = 11000 };
            var emp4 = new EmpDetails() { Id = 6, FirstName = "Haseena", LastName = "Akhtar", Salary = 6500 };
            var emp5 = new EmpDetails() { Id = 4, FirstName = "Iqra", LastName = "Tariq", Salary = 6000 };
            var emp6 = new EmpDetails() { Id = 5, FirstName = "Bisma", LastName = "Bashir", Salary = 7000 };

            empDetailsList.Add(emp1);
            empDetailsList.Add(emp2);
            empDetailsList.Add(emp3);
            empDetailsList.Add(emp4);

            //var qm = empDetailsList.Contains(emp1);
            var qs= (from emp in empDetailsList select emp).Contains(emp6);
            Console.WriteLine(qs);

            //var qm=empDetailsList.Select(x=> x.FirstName).Contains("Masarat") ;
            //var qs= from i in  empDetailsList where i.FirstName.Contains("Masarat") select i ;
            //Console.WriteLine(qs);

           

           



        }
    }
}
