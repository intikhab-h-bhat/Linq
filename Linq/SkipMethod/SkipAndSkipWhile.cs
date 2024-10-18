using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.SkipMethod
{
    public class SkipAndSkipWhile
    {
        public void SkipExample() {
        
            List<int> list = new List<int>()
            {
              1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            };

            //Using Skip
           // var qm = list.Skip(4);
            //var qs = (from i in list select i).Skip(4);
            
            //using skipWhile
           var qm = list.SkipWhile(x => x > 1).ToList();

            foreach(var i in qm)
            {
                Console.WriteLine(i);
            }

        
        }



    }
}
