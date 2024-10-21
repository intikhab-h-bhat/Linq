using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq.DictoneryMethod
{
    public class DictoneryDemo
    {

        public void Example1()
        {
            List<Product> products = new List<Product>()
            {

                new Product() { Id = 1, Name = "Hard Disk", Price = 2000 },
                new Product() { Id = 2, Name = "Flash Drive", Price = 400 },
                new Product() { Id = 3, Name = "Head Phone", Price = 1000 }


            };
            Dictionary<int, Product> productDic = products.ToDictionary(x => x.Id);


            //foreach(Product product in products)
            // {
            //     Console.WriteLine(product.Id);
            // }

            foreach (KeyValuePair<int, Product> kvp in productDic)
            {

                Console.WriteLine($" {kvp.Key},{kvp.Value.Name}, {kvp.Value.Price} ");


            }

           



        }
        public void Example2()
        {

            List<Product> products = new List<Product>()
            {

                new Product() { Id = 1, Name = "Hard Disk", Price = 2000 },
                new Product() { Id = 2, Name = "Flash Drive", Price = 400 },
                new Product() { Id = 3, Name = "Head Phone", Price = 1000 }


            };

            Dictionary<int,string> dict1=products.ToDictionary(x => x.Id,x=>x.Name);

            foreach(KeyValuePair<int,string> kvp in dict1) 
            {
                Console.WriteLine($"Key = {kvp.Key} , Value = {kvp.Value}");
            }


         
        }
        
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
