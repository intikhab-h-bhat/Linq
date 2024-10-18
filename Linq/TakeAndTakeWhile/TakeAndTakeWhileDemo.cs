using Linq.All_AllAny;
using Linq.IenumIqura;
using Linq.Select_SelectMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.TakeAndTakeWhile
{
    public class TakeAndTakeWhileDemo
    {

        public void TakeAndTakeWileExample()
        {
            int[] ints = { 7, 8, 9, 6, 11, 12, 1, 2, 3, 4, 5, };

            //IEnumerable<int> qm = ints.Take(2);

            //IEnumerable<int> qs = (from i in ints select i).Take(3);


            //foreach (int i in qs)
            //{
            //    Console.WriteLine(i);
            //}

            //Example of Take while
            IEnumerable<int> qstw = (from i in ints select i).TakeWhile(x=> x > 6).ToList();

            foreach (int i in qstw)
            {
                Console.WriteLine(i);
            }

        }
        public void TakeAndTakeWileWithWhereCond()
        {
            int[] ints = { 1,2,3,6,7,8,9,10,4,5 };

            IEnumerable<int> qm = ints.Where(x=> x > 3).Take(4);
            IEnumerable<int> qs = (from i in ints where i >3 select i).Take(4).ToList();
            foreach (int i in qs)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> qstw = (from i in ints where i < 6 select i).TakeWhile(x=> x<6).ToList();

            foreach (int i in qstw)
            {
                Console.WriteLine(i);
            }
        }

        public void TakeWithCompleType()
        {
            //List<StudentMarks> students = new List<StudentMarks>();

            var Qm =StudentMarks.GetStudent().SelectMany(student => student.Subject
                .Take(2)
                .Select(sub => new
                {
                    studentName = student.Name,
                    Subject = sub.SubName,
                    StuMarks = sub.Marks,
                })).ToList();
                
                

            foreach (var item in Qm)
            {               

             
               Console.WriteLine($"{item.studentName}, {item.Subject}, {item.StuMarks}");
            
                
            }


        }

       
    }
}
