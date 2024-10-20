using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.SequenceEqualMethod
{
    public class SequenceEqualDemo
    {

        public void Example1()
        { 
            int[] intArray = {1, 2, 3, 4};
            int[] intArray2 = {1,2,3,4};
            int[] intArray3= {1,2,3,4,5,6,};

            int[] intArray4 = { 4, 2, 1, 3 };

            var qm= intArray.SequenceEqual(intArray2);
            var qm1 = intArray.SequenceEqual(intArray3);

            var qs= (from i in  intArray select i).SequenceEqual(intArray2);
            var qs1 = (from i in intArray select i).SequenceEqual(intArray4);
            // this will be True
            Console.WriteLine(qs);

            //This will be False
            Console.WriteLine(qm1);
            Console.WriteLine(qs1);
        }

        public void Example2()
        {
            List<string> list1 = new List<string>() { "China","Rusia","Turkey"};
            List<string> list2 = new List<string>() { "China", "Rusia", "Turkey" };

            List<string> list3 = new List<string>() { "China", "rusia", "Turkey" };

            var qm = list1.SequenceEqual(list2);
            var qm1 = list1.SequenceEqual(list3);

            var qs = (from i in list1 select i).SequenceEqual(list2);
            var qs1 = (from i in list1 select i).SequenceEqual(list3);
            var qs2 = (from i in list1 select i).SequenceEqual(list3,StringComparer.OrdinalIgnoreCase);
            // this will be True
            Console.WriteLine(qs);
            Console.WriteLine(qs2); // here the case is ignored

            //This will be False because in list3 r in Russia is small(Case is not same)  
            Console.WriteLine(qm1);
            Console.WriteLine(qs1);

        }

        //Solve the Different Order problem
        public void Example3()
        {
            List<string> strCity = new List<string>()
            {
                "Delhi","Jammu","Srinagar"
            };

            List<string> strCity1 = new List<string>()
            {
                "Delhi","srinagar","Jammu"
            };

            //var cityClass = CityList.GetCityList().ToList();

            var qm=strCity1.OrderBy(x=> x).SequenceEqual(strCity.OrderBy(x=>x),StringComparer.OrdinalIgnoreCase);
                

            Console.WriteLine(qm);

          


        }

    }
    public class CityList
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public static List<CityList> GetCityList()
        {
            List<CityList> cityList = new List<CityList>()
            {
                new CityList(){Id = 1,Name="Delhi"},
                new CityList(){Id = 2,Name="Srinagar"},
                new CityList(){Id = 3,Name="Jammu"},
            };
            return cityList;

        }
            
    }
}
