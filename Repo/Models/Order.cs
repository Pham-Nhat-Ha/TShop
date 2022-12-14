using System;
using System.Collections.Generic;

#nullable disable

namespace Repo.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public double? Price { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
