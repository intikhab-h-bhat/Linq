

//using System.Linq;

//int[] age = new int[6]
using System.Reflection.Metadata;

List<int> age=new List<int>()
{ 12, 10, 15, 9, 22, 7 };
//string[] names = {"Adil","Ali","Intikhab","Ahmad","Mohammad","Abdullah" };
var querySyntex = from obj in age where obj > 9 orderby obj ascending select obj;
var queryMethod= age.Where(i => i > 9).ToList();
var queryMixSyntex = (from obj in querySyntex select obj).Sum();

//var a=from name in names where name.Contains("l") select name;
//var a = from name in names where name.StartsWith("A") select name;

foreach (int item in querySyntex)
{
    Console.WriteLine($"Linq Query Syntex type: {item}");
}
foreach (int item in queryMethod)
{
    Console.WriteLine($"Linq Query Method type: {item}");
}
Console.WriteLine($"Linq Query Mix Syntex type: {queryMixSyntex}");