using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class ClientModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }

    }
}
