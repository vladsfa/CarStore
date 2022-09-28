using System;
using System.Collections.Generic;

namespace CarStore.WebUI.Models.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string ModelName { get; set; } = null!;
        public int CustomerId { get; set; }
        public string DeliveryAddress { get; set; } = null!;
        public string? AdditInfo { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Car ModelNameNavigation { get; set; } = null!;
    }
}
