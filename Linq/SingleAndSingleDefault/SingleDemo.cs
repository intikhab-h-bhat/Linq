using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.SingleAndSingleDefault
{
    public class SingleDemo
    {


        public void SingleExample()
        {
            int[] array1 = {11};

            int qm = array1.Single();
            int qs = (from i in array1 select i).Single(); 

            Console.WriteLine(qm);

        }

        public void SingleWithEmtyDatasource()
        {
            //Empty Data source
            List<int> list = new List<int>();

            //fetching element gives InavlidOperationException
            int qm= list.Single();
            int qs = (from i in list select i).Single(); 

            // this will not give error
            int qmsd=list.SingleOrDefault();

            Console.WriteLine(qmsd);
        }

        public void SingleWithMoreThanOneElement()
        {
            //array with more than one element
            int[] array1 = { 1, 2, 3, 4, };

            // InavlidOperationException 
            //int qm = array1.Single();
            //int qs = (from i in array1 select i).Single();

            // this will give result 12 if element is present otherwise it 
            // will throw InavlidOperationException 
           // int qms = array1.Single(x => x == 3);
            
            //this will not give error it will return default value 0
            int qmsd = array1.SingleOrDefault(x => x > 4);

            Console.WriteLine(qmsd);

        }
    }
}
