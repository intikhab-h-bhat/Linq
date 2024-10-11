using Linq.IenumIqura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ConactAndUnion
{
    public class ConcatDemo
    {

        public void ConcatWithInt()
        {
            int[] intArray1 = { 1, 2, 3, 4, 5 };
            int[] intArray2 = { 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> qm = intArray1.Concat(intArray2);
            //IEnumerable<int> qm = intArray1.Concat(intArray2).OrderByDescending(num => num);
            IEnumerable<int> qs = (from num in intArray1 select num).Concat(intArray2);

            //IEnumerable<int> qm = intArray1.Union(intArray2);
            //IEnumerable<int> qs = (from num in intArray1 select num).Union(intArray2);

            foreach (int num in qs)
            {
                Console.WriteLine(num);
            }

        }

        public void ConcatWithComplexType() {

            List<Student> stud1 = new List<Student>()
            {
                new Student() {Id = 1,Name="Abdullah"},
                new Student() {Id = 2,Name="Aidah"},
                new Student() {Id = 3,Name="Sareena"}
            };

            List<Student> stud2 = new List<Student>()
            {
                new Student() {Id = 1,Name="Abdullah"},
                new Student() {Id = 2,Name="Ziyan"},
                new Student() {Id = 3,Name="Amaan"},

            };

            //var qmConcat=stud1.Concat(stud2);
            //var qsConcat= (from s in stud1 select s).Concat(stud2).ToList();

            var qmUnion=stud1.Select(s=>s.Name).Union(stud2.Select(st=>st.Name)).ToList();
            var qsUnion= ((from s in stud1 select s.Name).Union(stud2.Select(st=>st.Name))).ToList();

            foreach(var item in qsUnion)
            {
                Console.WriteLine($"{item}");
            }


            //foreach (var item in qsConcat)
            //{
            //    Console.WriteLine($"{item.Id} {item.Name} {item.Gender}");
            //}
        }

    }
}
