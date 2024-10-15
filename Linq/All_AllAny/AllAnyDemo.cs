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
            var qm=list.All(x=>x>25);

            Console.WriteLine(qm);

          }
    }
}
