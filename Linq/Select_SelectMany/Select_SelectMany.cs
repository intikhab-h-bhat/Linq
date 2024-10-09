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


        //selectMany
        public void SelectManyMethod()

        {
            IEnumerable<string> stuInfo=(from s in StudentInfo.GetStudents()
                                      from prog in s.ProgrammingLang                                     
                                      select prog).ToList();

            foreach(var stu in stuInfo)
            {
                Console.WriteLine(stu);
            }

            List<string> methodSyntext = StudentInfo.GetStudents().SelectMany(s => s.ProgrammingLang).ToList();

            foreach (var stu in methodSyntext)
            {
                Console.WriteLine(stu);
            }

        }

        //Remove duplicacy
        public void RemoveDuplicacy()
        {
            List<string> rmDupProg= StudentInfo.GetStudents().SelectMany(s=>s.ProgrammingLang)
                .Distinct().ToList();

            IEnumerable<string> rmDupPrgQueryType = (from s in StudentInfo.GetStudents()
                                                     from p in s.ProgrammingLang
                                                     select p).Distinct().ToList();
            foreach(var pr in rmDupPrgQueryType)
            {
                Console.WriteLine(pr);
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


    public class StudentInfo
    {
        public int Id { get; set; }
        public string StuName { get; set; }
        public string StuAddress { get; set;}
        public List<string> ProgrammingLang { get; set;}



        public static List<StudentInfo> GetStudents()
        {
            List<StudentInfo> stuList = new List<StudentInfo>() {
                new StudentInfo(){Id=1,StuName="Ahmad",ProgrammingLang=new List<string> {"C#","Python","JavaScript"} },
                new StudentInfo(){Id=2,StuName="Imad",ProgrammingLang=new List<string> {"CSS","HTML","JavaScript"} },
            };
            return stuList;
        }
    }
}
