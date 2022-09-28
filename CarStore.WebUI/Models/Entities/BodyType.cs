using System;
using System.Collections.Generic;

namespace CarStore.WebUI.Models.Entities
{
    public partial class BodyType
    {
        public BodyType()
        {
            Cars = new HashSet<Car>();
        }

        public string BodyType1 { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
