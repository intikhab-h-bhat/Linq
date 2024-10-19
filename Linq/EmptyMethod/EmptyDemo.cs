using Linq.IenumIqura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.EmptyMethod
{
    public class EmptyDemo
    {

        public void Example1()
        {
            IEnumerable<string> list = Enumerable.Empty<string>();
            IEnumerable<Student> students = Enumerable.Empty<Student>();

            Console.WriteLine($"Count: {list.Count()}");
            Console.WriteLine($"Student Count: {students.Count()}");

        }

        public void Example2()
        {
            IEnumerable<string> strTest = GetData();
            if( strTest !=null) {
            
                foreach( string s in strTest )
                {
                    Console.WriteLine(s);
                }
            
            }

            IEnumerable<string> strEmty=GetData()?? Enumerable.Empty<string>(); 

            foreach( string s in strEmty)
            {
                Console.WriteLine(s);
            }



        }

        public static IEnumerable<string> GetData()
        {
            return null;
        }


    }
}
