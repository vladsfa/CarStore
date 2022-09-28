using System;
using System.Collections.Generic;

namespace CarStore.WebUI.Models.Entities
{
    public partial class TransmissionType
    {
        public TransmissionType()
        {
            Cars = new HashSet<Car>();
        }

        public string TransmissionType1 { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
