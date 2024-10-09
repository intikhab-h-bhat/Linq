using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.DistinctDemo
{
    public class DistinctDemo
    {

        public void IntDistinctDemo()
        {
            //List<int> intList = new List<int>()
            //{
            //   12,11,4,5,4,3,6,7,8, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
            //};

            List<string> strList = new List<string>()
            {
                "Ahamed","Mohammad","Abdullah","Abdullah","ahamed","mohammad"
            };

            IEnumerable<string> ditList= strList.Distinct(StringComparer.OrdinalIgnoreCase);

            foreach(var i in ditList)
            {
                Console.WriteLine(i);
            }



        }

        public void DistinctTest()
        {
            List<string> qm = StudenSubjects.GetStuSub().SelectMany(s => s.Subjects).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
            
            IEnumerable<string> qs = (from st in StudenSubjects.GetStuSub()
                                     from su in st.Subjects
                                     select su).Distinct(StringComparer.OrdinalIgnoreCase).ToList();

            foreach(var sub in qs)
            {
                Console.WriteLine(sub);
            }



        }



    }

    public class StudenSubjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Subjects { get; set; }


        public static List<StudenSubjects> GetStuSub()
        {
            List<StudenSubjects> studenSubjects = new List<StudenSubjects>()
            {
                new StudenSubjects(){ Id=1,Name="Ahmad",Subjects=new List<string>{"Maths","English","Urdu","Computer" } },
                new StudenSubjects(){ Id=2,Name="Abdullah",Subjects=new List<string>{"maths","English","urdu" } },
            };

            return studenSubjects;


        }

    }

}
