using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int Active { get; set; }

        public Product(int Id, string Name, double Price, int Stock, int Active) 
        {
            
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Stock = Stock;
            this.Active = Active;

        }

        public Product() { }

    }
}
