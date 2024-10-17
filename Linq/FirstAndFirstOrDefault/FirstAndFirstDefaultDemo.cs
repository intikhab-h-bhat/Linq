using Linq.All_AllAny;
using Linq.DistinctDemo;
using Linq.Select_SelectMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.FirstAndFirstOrDefault
{
    public class FirstAndFirstDefaultDemo
    {

        public void FirstExample()
        {
            List<int> list = new List<int>()
            {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            };


            var qm= list.First();
            
            var qs= (from i in list select i).First();

            Console.WriteLine(qs);
            Console.WriteLine(qm);



        }
        public void FirstWithConditions() {
            
            List<int> list = new List<int>()
            {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            };

            var qm= list.First(x=> x>3);
            var qs = (from i in list select i).First(x => x > 3);

            Console.WriteLine(qm);

        }
        public void FirstWithNotReturningAnyThing()
        {

            List<int> list = new List<int>()
            {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            };

            //InvalidOperationException as there is no number greater than 13
            //var qm = list.First(x => x > 13);
            //var qs = (from i in list select i).First(x => x > 13);

            // this will not give error it will return 0
            var qm= list.FirstOrDefault(x=> x > 13);

            Console.WriteLine(qm);

        }

        public void FirstWithCompleType()
        {

            var qm = StudentMarks.GetStudent().First();  
            var qs = (from i in StudentMarks.GetStudent() select i).First();

            Console.WriteLine($"{qm.Name} {qm.Subject.Select(x => x.SubName).First()}");
            Console.WriteLine($"{qs.Name} {qs.Subject.Select(x=>x.SubName).First()}");

            var qmc= StudentMarks.GetStudent().First(x=> x.Id>1);

            Console.WriteLine($"{qmc.Id},{qmc.Name}");


            //List<StudentMarks> stuMarks = StudentMarks.GetStudent();

            //StudentMarks stu1 = stuMarks.First();

            //Console.WriteLine(stu1.Name);

        }

    }
}
