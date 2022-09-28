using System;
using System.Collections.Generic;

namespace CarStore.WebUI.Models.Entities
{
    public partial class Brand
    {
        public Brand()
        {
            Cars = new HashSet<Car>();
        }

        public string BrandName { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
