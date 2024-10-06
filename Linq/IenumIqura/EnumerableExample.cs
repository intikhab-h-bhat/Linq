using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.IenumIqura
{
    public class EnumerableExample
    {
        List<Student> students = new List<Student>()
        {
            new Student(){Id=1,Name="Intikhab",Gender="Male"},
            new Student(){Id=2,Name="Misbah",Gender="Male"},
            new Student(){Id=3,Name="Maryam",Gender="Female"},

        };

        public void EnumerableMethod()
        {
            IEnumerable<Student> students1 = students;

            //var students2 = students1.Where(s => s.Gender == "Male").ToList();
            var students2 = from stu in students1 where stu.Gender == "Female" select stu;
            
            if (students2.Count() > 0)
            {

                foreach (var student in students2)
                {

                    Console.WriteLine($"Id:{student.Id} Name: {student.Name} Gender: {student.Gender}");
                }
            }
            else
            {
                Console.WriteLine("No student was found");
            }
        }



    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

       

    }
}
