using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace crm
{
    class Program
    {

        static void Main(string[] args)
        {
            var product = new List<Product>();

            string[] productid = new string[1000];
            var i = 0;

            var fileStream = new FileStream(@"C:\products.csv", FileMode.Open, FileAccess.Read); //reading file values
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line; //by line
                while ((line = streamReader.ReadLine()) != null) //checking for null input
                {
                    var newproduct = new Product();  //creation of object product
                    var value = line.Split(';');  

                    if (IsNotEmpty(value[0], productid))
                    {
                        newproduct.ProductId = productid[i] = value[0];
                        newproduct.Name = value[1];
                        newproduct.Description = value[2];

                        product.Add(newproduct);
                        i++;
                    }
                }
            }

            var j = 0;
            foreach (var prod in product)
            {
                Console.WriteLine($"Product {j} id: {prod.ProductId}");
                Console.WriteLine($"Product {j} name: {prod.Name}");
                Console.WriteLine($"Product {j} Description: {prod.Description}");
                Console.WriteLine($"Product {j} Price: {prod.Price}\n");

                j++;
            }
        }

        public static bool IsNotEmpty(string id, string[] values) //checking null or empty or double values
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                Console.WriteLine("Id is missing from product\n");
                return true;
            }
            for (var j = 0; j < values.Length; j++)
            {
                if (id == values[j])
                {
                    Console.WriteLine($"Double product ID located \n ");
                    return false;
                }
            }
            return true;
        }
    }

}