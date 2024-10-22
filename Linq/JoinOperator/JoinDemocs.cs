using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linq.JoinOperator
{
    public class JoinDemocs
    {

        #region Inner Join
        // with anonimous
        public void Example1()
        {
         
            var qm = EmpData.GetEmpData().Join(
                AddresDetails.GetAddress(),
                emp=>emp.AddressId,
                add=>add.Id,
                (emp,add)=>new {
                    EmpId = emp.Id,
                     EmpName=emp.Name,
                    AddrId=add.Id,
                    AddressLine= add.Address
                });

            foreach (var item in qm)
            {
                Console.WriteLine($"{item.EmpId}, {item.EmpName}, {item.AddrId},{item.AddressLine}");
            }
                   


            var qs = (from emp in EmpData.GetEmpData() 
                      join add in AddresDetails.GetAddress()
                       
                      on emp.AddressId equals add.Id 
                      select new
                      {
                          EmpName= emp.Name,
                          AddressLine=add.Address
                      }
                      
                ).ToList();
            foreach (var item in qs)
            {
                Console.WriteLine($"{item.EmpName}, {item.AddressLine}");
            }
        }

        public void Example2()
        {
            var qm = EmpData.GetEmpData()
                .Join(AddresDetails.GetAddress(),
                Emp => Emp.AddressId,
                add => add.Id,
                (emp, add) => new EmployeeAddress
                {

                    EmpName = emp.Name,
                    Address = add.Address

                }).ToList();

            foreach(var item in qm)
            { 
                Console.WriteLine(item.EmpName); 
            }

            var qs = (from emp in EmpData.GetEmpData()
                      join add in AddresDetails.GetAddress()
                      on emp.AddressId equals add.Id
                      select new EmployeeAddress
                      {
                          EmpName = emp.Name,
                          Address = add.Address
                      }).ToList();    

            foreach( var item in qs)
            {
                Console.WriteLine(item.EmpName); 
            }

        }

        public void Examle3()
        {
            var qm = AddresDetails.GetAddress()
                .GroupJoin(EmpData.GetEmpData(),
                add => add.Id,
                emp => emp.AddressId,
                (add, emp) => new 
                {
                    Address=add,
                    Employee=emp
                   
                });

            foreach(var item in qm)
            {
                Console.WriteLine(item.Address.Id);
                foreach(var a in item.Employee)
                {

                    Console.WriteLine(a.Name);
                }
            }
                   

            var qs = (from a in AddresDetails.GetAddress()
                          join e in EmpData.GetEmpData()
                          on a.Id equals e.AddressId
                          into EmployeeGroup
                          select new { 
                              Address = a, 
                              Employees = EmployeeGroup 
                          }).ToList();

            foreach(var item in qs)
            {
                Console.WriteLine(item.Address.Id);
                foreach(var e in item.Employees)
                {
                    Console.WriteLine(e.Name);
                }
            }


        }
        #endregion

        #region Left Join
        public void Example4()
        {
            var qs = (from e in EmpData.GetEmpData()
                      join a in AddresDetails.GetAddress()
                      on e.AddressId equals a.Id
                       into EmployeeGroup
                      from address in EmployeeGroup.DefaultIfEmpty()
                      select new
                      {
                          e,
                          address

                      }).ToList();

            foreach (var item in qs)
            {
                Console.WriteLine($" {item.e.Name} , {item.address.Address} ,");
            }

            //var qsAddress = (from a in AddresDetails.GetAddress()
            //          join e in EmpData.GetEmpData()
            //          on a.Id equals e.AddressId
            //           into EmployeeGroup
            //          from emp in EmployeeGroup.DefaultIfEmpty()
            //          select new
            //          {
            //              a,
            //              emp

            //          }).ToList();

            //foreach (var item in qsAddress)
            //{
            //    Console.WriteLine($" {item.a.Id} , {item.emp.Name} ,");
            //}

        }

        public void Example5()
        {
            var qm = EmpData.GetEmpData().GroupJoin(AddresDetails.GetAddress()
                , e => e.AddressId, a => a.Id,
                (e, a) => new
                {
                    e,
                    a
                }).SelectMany(x => x.a.DefaultIfEmpty(),
                (e, a) => new { e, a });


            foreach(var item in qm)
            {
                Console.WriteLine($"{item.e}{item.a.Address}");
            }
        }


        #endregion

    }
    public class EmpData
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }

        public static List<EmpData> GetEmpData()
        {
            List<EmpData> empData = new List<EmpData>()
                {
                new EmpData() { Id = 1, Name = "Intikhab", AddressId = 1 },
            new EmpData() { Id = 2, Name = "Kaiser", AddressId = 1 },
            new EmpData() { Id = 3, Name = "Tabasum", AddressId = 2 },
            //new EmpData() { Id = 4, Name = "Adil", AddressId = 2 },
            //new EmpData() { Id = 5, Name = "Tabiya", AddressId = 3 },

            };
            return empData;
        }

    }
    public class AddresDetails
    {

        public int Id { get; set; }
     
        public string Address { get; set; }

        public static List<AddresDetails> GetAddress()
        {
            List<AddresDetails> addressDetail = new List<AddresDetails>()
                {
                new AddresDetails() { Id = 1,Address="Nowgam" },
            new AddresDetails() { Id = 2, Address = "Yamberzal Colony Nowgam"},
            new AddresDetails() { Id = 3, Address="Abcdef"},
            new AddresDetails() { Id = 4,Address="LMNOPEQWSA" },
            new AddresDetails() { Id = 5, Address="EFGHIJK"},

            };
            return addressDetail;
        }

    }

    public class EmployeeAddress
    {
        public string EmpName { get; set; }
        public string Address { get; set; }
    }
}
