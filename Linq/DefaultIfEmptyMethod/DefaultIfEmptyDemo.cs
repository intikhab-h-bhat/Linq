using Linq.IenumIqura;
using Linq.Select_SelectMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.DefaultIfEmptyMethod
{
    public  class DefaultIfEmptyDemo
    {

        public void Example()
        {
            List<int> list = new List<int>() { 1,2,3,4,5};

            var qm = list.DefaultIfEmpty();
            var qs = (from i in list select i).DefaultIfEmpty();

            Console.WriteLine(string.Join(",", qs));

            foreach(var i in qs)
            {
               Console.WriteLine(i);
            }

        }

        // when dataset source is empty
        public void Example2()
        {
            List<int> intArra1 = new List<int>();

            var qm= intArra1.DefaultIfEmpty();
            Console.WriteLine(string.Join(",", qm));
            foreach (var i in qm) {
                Console.WriteLine(i);
                    }
        }

        /// <summary>
        /// Add data to empty datasource
        /// </summary>
        public void Example3()
        {
            List<int> intArra1 = new List<int>();

            var qm = intArra1.DefaultIfEmpty(5);
            Console.WriteLine(string.Join(",", qm));
            foreach (var i in qm)
            {
                Console.WriteLine(i);
            }

        }
        /// <summary>
        /// Add data to datasource when it is not empty
        /// </summary>
        public void Example4()
        {
            List<int> intArra1 = new List<int>()
            {
                1,3,4,5,6,7,8 
            };

            var qm = intArra1.DefaultIfEmpty(5);
            Console.WriteLine(string.Join(",", qm));
            foreach (var i in qm)
            {
                Console.WriteLine(i);
            }

        }

        public void Eaxmple5()
        {

            List<EmployeeInfo> emp = EmployeeInfo.GetEmployees();

            EmployeeInfo emp1= new EmployeeInfo()
            {
                Id=4,Name="XYZ",Email="xyz@gmail.com",
                City="sdaksd",Address="alasdasd",Phone=12312313,Salary=40000
            };


            IEnumerable<EmployeeInfo> qm = emp.DefaultIfEmpty();
            var qmWithValue = emp.DefaultIfEmpty(emp1);
            var qs= (from i in emp select i).DefaultIfEmpty();

            //foreach (var i in qmWithValue)
            //{

            //    Console.WriteLine($"{i.Id}, {i.Name}, {i.Email}, {i.City}");
            //}


            List<EmployeeInfo> empList1 = new List<EmployeeInfo>();

            var blankEmp= empList1.DefaultIfEmpty(emp1 );

            foreach (var i in blankEmp)
            {

                Console.WriteLine($"{i.Id}, {i.Name}, {i.Email}, {i.City}");
            }



        }


    }
}
