using CarStore.WebUI.Models.Entities;

namespace CarStore.WebUI.Models.Abstract
{
    public interface ICarContext
    {

        public IEnumerable<BodyType> BodyTypes { get; }
        public IEnumerable<Brand> Brands { get; }
        public IEnumerable<Car> Cars { get; } 
        public IEnumerable<Customer> Customers { get; } 
        public IEnumerable<FuelType> FuelTypes { get; }
        public IEnumerable<Order> Orders { get; } 
        public IEnumerable<TransmissionType> TransmissionTypes { get; }
    }
}
