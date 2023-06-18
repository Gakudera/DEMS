using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp2.Domain.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime DateOfSale { get; set; }
        public string Status { get; set; }
        public int PointId { get; set; }
        public int Code { get; set; }

        public virtual Point Point { get; set; }
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
