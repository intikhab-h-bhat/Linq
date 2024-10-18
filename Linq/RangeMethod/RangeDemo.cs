using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.RangeMethod
{
    public class RangeDemo
    {
        public void RangeEcxample()
        {

            IEnumerable<int> intSeq= Enumerable.Range(1,10);
            foreach (int i in intSeq)
            {

                Console.WriteLine(i);
            }

            var qs = from i in intSeq select i;
            foreach(var i in qs){
                Console.WriteLine(i);
            }


        }

        public void RangeWithWhere() {
        
            IEnumerable<int> intSeq = Enumerable.Range(1,30).Where(x=> x%2==0).Select(s=>s);

            foreach(var i in intSeq)
            { Console.WriteLine(i); }

        }


    }
}
