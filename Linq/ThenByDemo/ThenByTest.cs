using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ThenByDemo
{
    public class ThenByTest
    {

        public void UsingThenBY()
        {


            //var qs = from i in EmpDetails.GetEmp() orderby i.FirstName, i.LastName select i;
            var qm = EmpDetails.GetEmp().OrderBy(x => x.Salary).ThenBy(y=>y.FirstName);
            foreach(var det in qm)
            {
                //Console.WriteLine($"{det.FirstName} {det.LastName}");
                Console.WriteLine($"{det.Salary} {det.FirstName}");
            }


        }

        public void UsingThenByMultipleValues()
        {

            //var qs = from i in EmpDetails.GetEmp() orderby i.Id, i.FirstName descending, i.Salary select i;
            var qm = EmpDetails.GetEmp().OrderBy(i=>i.Id).ThenByDescending(y=>y.FirstName).ThenBy(x=>x.Salary).ToList();
            foreach(var det in qm)
            {
                Console.WriteLine($"{det.Id} {det.FirstName} {det.Salary}");
            }



        }


    }
    public class EmpDetails
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public static List<EmpDetails> GetEmp()
        {
            List<EmpDetails> empDetailsList = new List<EmpDetails>()
        {
               new EmpDetails() {Id=1, FirstName="Masarat",LastName="Abc",Salary=10000},
               new EmpDetails() {Id=2, FirstName="Javaid",LastName="Ahamed",Salary=12000},
               new EmpDetails() {Id=3,FirstName="Adil",LastName="Dar",Salary=11000},
               new EmpDetails() {Id=6,FirstName="Haseena",LastName="Akhtar",Salary=6500},
               new EmpDetails() {Id=4,FirstName="Iqra",LastName="Tariq",Salary=6000},
               new EmpDetails() {Id=5,FirstName="Bisma",LastName="Bashir",Salary=7000},
               

        };

            return empDetailsList;
        }
    }
}
