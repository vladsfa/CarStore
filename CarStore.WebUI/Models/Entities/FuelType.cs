using System;
using System.Collections.Generic;

namespace CarStore.WebUI.Models.Entities
{
    public partial class FuelType
    {
        public FuelType()
        {
            Cars = new HashSet<Car>();
        }

        public string FuelType1 { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
