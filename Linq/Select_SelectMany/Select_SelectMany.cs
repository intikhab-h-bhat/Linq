using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Select_SelectMany
{
    public class Select_SelectMany
    {

        public void SelectMethod() {

           List<EmployeeInfo> basicQuery=(from employee in EmployeeInfo.GetEmployees() where employee.Salary > 15000 
                                          select employee).ToList();

            foreach(var emp in basicQuery)
            {
                Console.WriteLine($"Employee Details: Name: {emp.Name}");
            }

            List<EmployeeInfo> basicMethod = EmployeeInfo.GetEmployees().ToList();

            foreach (var emp in basicMethod)
            {
                Console.WriteLine($"Employee Details: Name: {emp.Name}");
            }

        }

        public void SelectSingleProperty()
        {

            List<int> getId = (from employee in EmployeeInfo.GetEmployees()
                                             where employee.Salary > 15000
                                             select employee.Id).ToList();

            foreach (var emp in getId)
            {
                Console.WriteLine($"Employee Id: {emp}");
            }

            List<int> getIdMethod = EmployeeInfo.GetEmployees().Select(x => x.Id).ToList();
            foreach (var emp in getIdMethod)
            {
                Console.WriteLine($"Employee Id: {emp}");
            }


        }

        public void SelectMultipleProperties() {
        
            List<EmployeeInfo> queryMultiple= (from e in EmployeeInfo.GetEmployees() 
                                              select new EmployeeInfo
                                              {
                                                  Id= e.Id,
                                                  Name= e.Name,
                                                  Salary= e.Salary,

                                              }).ToList();

            foreach(var emp in queryMultiple)
            {
                Console.WriteLine($"basicQuery   Id: {emp.Id} Name: {emp.Name} Salary: {emp.Salary}");
            }

            List<EmployeeInfo> queryMethodMultiple = EmployeeInfo.GetEmployees()
                .Select(e => new EmployeeInfo
                {
                    Id = e.Id,
                    Name = e.Name,
                    Salary = e.Salary,

                }).ToList();

            foreach (var emp in queryMethodMultiple)
            {
                Console.WriteLine($"basicQuery   Id: {emp.Id} Name: {emp.Name} Salary: {emp.Salary}");
            }
        }

        public void SelectAnonymousObj() {
        
         var emp = (from e in EmployeeInfo.GetEmployees() select new
         {
             Id = e.Id,
             Name = e.Name,
             Salary = e.Salary,
         });
            foreach(var i in emp)
            {
                Console.WriteLine($" The details are {i.Id} {i.Name}  {i.Salary}");
            }

            var empMethod = EmployeeInfo.GetEmployees()
                .Select(e => new
                {
                    Id = e.Id,
                    Name = e.Name,
                    Salary = e.Salary,
                });
               
            foreach (var i in empMethod)
            {
                Console.WriteLine($" The details are {i.Id} {i.Name}  {i.Salary}");
            }



        }
    }
    public class EmployeeInfo
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public decimal Salary { get; set; }


        public static List<EmployeeInfo> GetEmployees()
        {
            List<EmployeeInfo> employeeInfos = new List<EmployeeInfo>()
            { 
            new EmployeeInfo{Id=1,Name="Kaiser",Address="Nowgam",City="Srinagar",Email="abc@gmail.com",Phone=123456789,Salary=20000},
            new EmployeeInfo{Id=2,Name="Masarat",Address="Nowgam",City="Srinagar",Email="xyz@gmail.com",Phone=786567890,Salary=30000},
            new EmployeeInfo{Id=3,Name="abcd",Address="Kanipora",City="Srinagar",Email="dez@gmail.com",Phone=986567890,Salary=15000},
            };
            return employeeInfos;
        }
    }
}
