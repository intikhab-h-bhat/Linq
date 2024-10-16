using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.All_AllAny
{
    public class AllAnyDemo
    {
        List<int> list = new List<int>()
        {
            12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,
        };

        public void AllMethod() {

            // var qs= (from i in list  select i).Any(x=>x>23);
            //var qs = (from i in list select i).All(x => x > 23);
            var qm = list.All(x => x > 25);

            Console.WriteLine(qm);

        }


        public void WithComplexType()
        {

            //var qm = StudentMarks.GetStudent().Where(s => s.Subject.All(m => m.Marks > 75)).ToList();
            //var qs = (from i in StudentMarks.GetStudent() where i.Subject.All(x => x.Marks > 75) select i).ToList();

             var qm = StudentMarks.GetStudent().Where(s=> s.Subject.Any(x=>x.Marks>80));

            //var qm = StudentMarks.GetStudent().Select(i => i.Subject.Sum(x => x.Marks)).ToList();

            foreach (var s in qm)
            {
                Console.WriteLine(s.Name);

                foreach(var sub in s.Subject)
                {

                    Console.WriteLine($"{sub.SubName},  {sub.Marks}");
                }
            }

            //foreach(var x in qm) {
            //   Console.WriteLine($"{x}");
            //}


        }
       


    }
    public class StudentMarks()
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Subjects> Subject { get; set; }


        public static List<StudentMarks> GetStudent()
        {
            List<StudentMarks> students = new List<StudentMarks>()
            {
                new StudentMarks() { Id = 1, Name = "Imaad",
                    Subject = new List<Subjects>() {
                        new Subjects() { id = 1, SubName = "Engnglish", Marks = 90 },
                         new Subjects() { id = 2, SubName = "Math", Marks = 95 },
                          new Subjects() { id = 3, SubName = "Science", Marks = 80 },

                    },
                },
                new StudentMarks() { Id = 2, Name = "Abdullah",
                    Subject = new List<Subjects>() {
                        new Subjects() { id = 1, SubName = "English", Marks = 95 },
                        new Subjects() { id = 2, SubName = "Math", Marks = 100 },
                        new Subjects() { id = 3, SubName = "Science", Marks = 97 },


                    },
                }

            };

            return students;
        }

    public class Subjects()
        {
            public int id { get; set; }
            public string SubName { get; set; }
            public decimal Marks { get; set; }

        }
    }
}
