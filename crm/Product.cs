using System;
using System.Collections.Generic;
using System.Text;

namespace crm
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ProductId { get; set; }


        public Product()
        { 
            var value = string.Format("{0:0.##}", new Random().NextDouble() * 100);
            Price = value;
        }

        
    }
}
