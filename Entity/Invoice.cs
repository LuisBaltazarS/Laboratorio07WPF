using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Invoice
    {

        public int Id { get; set; }
        public Client Client { get; set; }
        public string Date { get; set; }
        public double Total { get; set; }
        public int Active { get; set; }

        public Invoice(int Id, Client Cliente, string Date, double Total, int Active) 
        {
            
            this.Id = Id;
            this.Client = Cliente;
            this.Date = Date;
            this.Total = Total;
            this.Active = Active;

        }

        public Invoice() { }

    }
}
