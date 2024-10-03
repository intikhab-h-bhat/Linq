

//using System.Linq;

//int[] age = new int[6]
//List<int> age=new List<int>()
//{ 12, 10, 15, 9, 22, 7 };
string[] names = {"Adil","Ali","Intikhab","Ahmad","Mohammad","Abdullah" };
//var a = from i in age where i > 9 orderby i ascending select i;
//var a=from name in names where name.Contains("l") select name;
var a = from name in names where name.StartsWith("A") select name;

foreach (string item in a)
{
    Console.WriteLine(item);
}
