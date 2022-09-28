using System;
using System.Collections.Generic;

namespace CarStore.WebUI.Models.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerSurname { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string FacebookLink { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
