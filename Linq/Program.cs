
using Linq.DistinctDemo;
using Linq.IenumIqura;
using Linq.Select_SelectMany;
using Linq.WhereFilter;




DistinctDemo distinctDemo = new DistinctDemo();
//distinctDemo.DistinctTest();
distinctDemo.IntDistinctDemo();

//WherFilter wherFilter = new WherFilter();
//wherFilter.WhereFilterDemo();


//Select_SelectMany selectDemo=new Select_SelectMany();
//selectDemo.SelectMultipleProperties();
//selectDemo.SelectAnonymousObj();
//selectDemo.RemoveDuplicacy();
//selectDemo.SelectMethod();

//selectDemo.SelectSingleProperty();




////using System.Linq;

////int[] age = new int[6]
//using System.Reflection.Metadata;

//List<int> age=new List<int>()
//{ 12, 10, 15, 9, 22, 7 };
////string[] names = {"Adil","Ali","Intikhab","Ahmad","Mohammad","Abdullah" };
//var querySyntex = from obj in age where obj > 9 orderby obj ascending select obj;
//var queryMethod= age.Where(i => i > 9).ToList();
//var queryMixSyntex = (from obj in querySyntex select obj).Sum();

////var a=from name in names where name.Contains("l") select name;
////var a = from name in names where name.StartsWith("A") select name;

//foreach (int item in querySyntex)
//{
//    Console.WriteLine($"Linq Query Syntex type: {item}");
//}
//foreach (int item in queryMethod)
//{
//    Console.WriteLine($"Linq Query Method type: {item}");
//}
//Console.WriteLine($"Linq Query Mix Syntex type: {queryMixSyntex}");



//EnumerableExample enumerableExample = new EnumerableExample();
//enumerableExample.EnumerableMethod();

//QurableExample qurableExample = new QurableExample();
//qurableExample.Example();