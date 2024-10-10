using Linq.IenumIqura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Intersect
{
    public class IntersectDemo
    {
        public void IntersectWithInt()
        {
            List<int> numList1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> numList2 = new List<int>() { 1, 5, 6 };

            IEnumerable<int> qm = numList1.Intersect(numList2);

            IEnumerable<int> qs = (from num in numList1 select num).Intersect(numList2);


            foreach (int i in qs)
            {
                Console.WriteLine(i);
            }

        }
        public void IntersectWithString() {
            string[] strCountry = { "Turkey", "Egypt", "Saudi Arabia", "Pakistan" };
            string[] strCountr2 = { "Turkey", "egypt", "saudi arabia", "Pakistan" };
            string[] strCountry3 = null;

            IEnumerable<string> qm = strCountry.Intersect(strCountr2,StringComparer.OrdinalIgnoreCase);
            IEnumerable<string> qs = (from c in strCountry select c).Intersect(strCountr2);

            // this gives error as the strCountry3 is null
           // IEnumerable<string> query = strCountry.Intersect(strCountry3);

            foreach (var s in qm)
            {
                Console.WriteLine(s);
            }
        
        }

        public void IntersectionWithComplexType()
        {
            List<Student> stud1 = new List<Student>()
            {
                new Student() {Id = 1,Name="Aidah"},
                new Student() {Id = 2,Name="Abdullah"},
                new Student() {Id = 3,Name="Sareena"}
            };

            List<Student> stud2 = new List<Student>()
            {
                new Student() {Id = 1,Name="Abdullah"},
                new Student() {Id = 2,Name="Ziyan"},
                new Student() {Id = 3,Name="Amaan"},

            };

            List<string> qm = stud1.Select(s=>s.Name).Intersect(stud2.Select(s=>s.Name)).ToList();
            List<string> qs= ((from s in stud1 select s.Name).Intersect(stud2.Select(st=>st.Name))).ToList();
           
            foreach(var st in qs )
            {
                Console.WriteLine(st);   
            }




        }


    }
}
