using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ElementAt
{
    public class ElementAtMethod
    {
        public void ElementAtExamle() {

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };

            int ms = intArray.ElementAt(4);
            int qs= (from i in intArray select i).ElementAt(5);

            Console.WriteLine(qs);
            Console.WriteLine(ms);
                }

        public void ElementAtOuOfRange()
        {

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };

            // ArgumentOutofrange exception
            int ms = intArray.ElementAt(16);
            int qs = (from i in intArray select i).ElementAt(16);

            Console.WriteLine(qs); 
            Console.WriteLine(ms);
        }

        public void ElementAtEmptyDatasource()
        {

            List<int> intList = new List<int>();

            // ArgumentOutofrange exception
            int ms = intList.ElementAt(16);
            int qs = (from i in intList select i).ElementAt(16);

            Console.WriteLine(qs);
            Console.WriteLine(ms);
        }

        public void ElementAtNullDatasource()
        {

            List<int> intList = null;

            // ArgumentNulException value cannot be Null exception
            int ms = intList.ElementAt(16);
            int qs = (from i in intList select i).ElementAt(16);

            Console.WriteLine(qs);
            Console.WriteLine(ms);
        }

        /// <summary>
        /// ElementAtOrDefault Method
        /// </summary>
        public void ElementAtOrDefaultMethod()
        {

            // int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            List<int> intArray = null;


            // if index is out f range it will return 0
            // but if the datasource is null it will give ArgumentNulException
            int ms = intArray.ElementAtOrDefault(16);
            int qs = (from i in intArray select i).ElementAtOrDefault(16);

            Console.WriteLine(qs);
            Console.WriteLine(ms);
        }
    }
}
