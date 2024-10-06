using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.IenumIqura
{
    public class QurableExample
    {
        public void Example()
        {
            List<StudentList> studentList = new List<StudentList>()
            {

                new StudentList() { Id = 1, Name = "Ahmad", Gender = "Male" },
                new StudentList() { Id = 2, Name = "Mohammad", Gender = "Male" },
                new StudentList() { Id = 3, Name = "Aidah", Gender = "Female" }

            };

            IQueryable<StudentList> queryable = studentList.AsQueryable().Where(s => s.Gender == "Male");

            foreach (var student in queryable)
            {
                Console.WriteLine($"Name : {student.Name}");
            }


        }
    }

        public class StudentList
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }
    
}