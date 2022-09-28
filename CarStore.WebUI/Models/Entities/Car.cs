using System;
using System.Collections.Generic;

namespace CarStore.WebUI.Models.Entities
{
    public partial class Car
    {
        public Car()
        {
            Orders = new HashSet<Order>();
        }

        public string ModelName { get; set; } = null!;
        public string BrandName { get; set; } = null!;
        public string BodyType { get; set; } = null!;
        public string TransmissionType { get; set; } = null!;
        public string FuelType { get; set; } = null!;

        public virtual BodyType BodyTypeNavigation { get; set; } = null!;
        public virtual Brand BrandNameNavigation { get; set; } = null!;
        public virtual FuelType FuelTypeNavigation { get; set; } = null!;
        public virtual TransmissionType TransmissionTypeNavigation { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
