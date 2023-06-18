using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp2.Domain.Entities
{
    public partial class Product
    {
        public Product()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public int Discount { get; set; }
        public int CountInStock { get; set; }
        public int Cost { get; set; }

      

        public virtual ICollection<Order> Order { get; set; }


        [NotMapped]
        public string GetPhoto
        {
            get => "C:\\Users\\Jenkins\\source\\repos\\WpfApp2\\WpfApp2\\Resources\\s-l500.png";
        }
    }
}
