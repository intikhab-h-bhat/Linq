using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.AppendMethod
{
    public  class AppendDemo
    {
        public void Example()
        {

            int[] intArray = { 1, 2, 3, 4 };

            var qm = intArray.Append(1);
            var qs = (from i in intArray select i).Append(2);
           
            Console.WriteLine(string.Join(" , ",intArray.Append(1).ToList()));
            Console.WriteLine(intArray);
            Console.WriteLine(string.Join(" , ", intArray));
            Console.WriteLine(qm.Count());
            Console.WriteLine(qs.Count());
        }

    }
}
