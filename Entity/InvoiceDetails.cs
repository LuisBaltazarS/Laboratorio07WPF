using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InvoiceDetails
    {

        public int Id { get; set; }
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Subtotal { get; set; }
        public int Active { get; set; }

        public InvoiceDetails(int Id, Invoice Invoice, Product Product, int Quantity, double Price, double Subtotal, int Active) 
        {
            
            this.Id = Id;
            this.Invoice = Invoice;
            this.Product = Product;
            this.Quantity = Quantity;
            this.Price = Price;
            this.Subtotal = Subtotal;
            this.Active = Active;

        }

        public InvoiceDetails() { }

    }
}
