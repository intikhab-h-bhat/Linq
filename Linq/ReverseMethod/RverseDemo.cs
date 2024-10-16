using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ReverseMethod
{
    public class ReverseDemo
    {

        public void Example()
        {
            int[] array1= { 1, 2, 3,4,5,6 };

            //var qm = array1.Reverse();
           
            IEnumerable<int> arayInts=array1.Reverse();
            foreach(var i in arayInts)
            {
                Console.WriteLine(i);
            }
                
        }

        public void WithString() { 
        
        List<string> stringList=new List<string>()
        {
            "Hello","World"
        };
            Console.WriteLine("Before Reverse");
            foreach (var i in stringList)
            {
                Console.WriteLine(i);
            }


            stringList.Reverse();

            Console.WriteLine("After Reverse");

            foreach (var i in stringList)
            {
                Console.WriteLine(i);
            }

        }

        public void IenumerableOnCollection() {

            List<string> stringList = new List<string>()
        {
            "Hello","World"
        };
            //we have to use AsEnumerable if we want to use system.linq reverse in list collection
            IEnumerable<string> strCollection=stringList.AsEnumerable().Reverse();

            foreach(var str in strCollection)
            {
                Console.WriteLine(str);
            }

        }

    }
}
