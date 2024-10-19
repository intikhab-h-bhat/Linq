using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.RepeatMethod
{
    public class RepeatDemo
    {

        public void RepratExample()
        {

            IEnumerable<string> strinList = Enumerable.Repeat("Hello C#", 10).ToList();

            // This will give error as there is negative number
           // IEnumerable<string> strinList = Enumerable.Repeat("Hello C#", -5).ToList();


            foreach (string str in strinList)
            {
                Console.WriteLine(str);
            }


        }

    }
}
