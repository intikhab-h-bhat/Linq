using Linq.IenumIqura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ExceptMethod
{
    public class ExceitDemo
    {

        public void ExceptWithInt() {

            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> list2 = new List<int>() { 1, 2, 3, 7, 8, 9 };

            IEnumerable<int>  qm = list1.Except(list2).ToList();

            foreach (int i in qm)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> qs= (from num in list1 select num).Except(list2).ToList();
            foreach (int i in qs)
            {
                Console.WriteLine(i);
            }
        }
        public void ExceptWithString() {
            string[] string1 = { "Turkey", "Russia", "China", "Canada" };
            string[] string2 = { "turkey", "Russia", "Canada", "India" };
        
            IEnumerable<string> qm= string1.Except(string2).ToList();

            IEnumerable<string> qs= (from c in string1 select c).Except(string2).ToList();

            foreach(string s in qs)
            {
                Console.WriteLine(s);
            }
        
        }

        public void ExceptWithStringCase()
        {
            string[] string1 = { "Turkey", "Russia", "China", "Canada" };
            string[] string2 = { "turkey", "Russia", "Canada", "India" };

            IEnumerable<string> qm= string1.Except(string2,StringComparer.OrdinalIgnoreCase).ToList();

            IEnumerable<string> qs = (from c in string1 select c).Except(string2, StringComparer.OrdinalIgnoreCase).ToList();


            foreach(var s in qs)
            {
                Console.WriteLine(s);
            }
        }


        public void ExceptWithComlexType() {

            List<Student> allStu = new List<Student>()
            {
                new Student(){Id=101,Name="Mohammad"},
                new Student(){Id=102,Name="Abdullah"},
                new Student(){Id=103,Name="Aidah"},
                new Student(){Id=104,Name="Sareena"},
                new Student(){Id=105,Name="Zoofishan"},

            };

            List<Student> stu6th = new List<Student>()
            {
                new Student(){Id=103,Name="Aidah"},
                new Student(){Id=104,Name="Sareena"},
                new Student(){Id=105,Name="Zoofishan"},

            };


            List<string> qm = allStu.Select(s => s.Name).Except(stu6th.Select(stu=>stu.Name)).ToList();

            List<string> qs = ((from s in allStu select s.Name).Except(stu6th.Select(stu => stu.Name))).ToList();

            //List<string> qs =((from s in allStu select s.Name).Except(from stu in stu6th select stu.Name)).ToList();
            
            
            
            foreach(var s in qs)
            {
                Console.WriteLine(s);
            }




        }



    }
}
