using CarStore.WebUI.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CarStore.WebUI.Models.Entities
{
    public class CarContext : ICarContext
    {
        private readonly EFCarContext context;
        public CarContext(EFCarContext _context)
        {
            context = _context;
        }

        public IEnumerable<BodyType> BodyTypes { get => context.BodyTypes; }
        public IEnumerable<Brand> Brands { get => context.Brands; }
        public IEnumerable<Car> Cars { get => context.Cars; }
        public IEnumerable<Customer> Customers { get => context.Customers; }
        public IEnumerable<FuelType> FuelTypes { get => context.FuelTypes; }
        public IEnumerable<Order> Orders { get => context.Orders; }
        public IEnumerable<TransmissionType> TransmissionTypes { get => context.TransmissionTypes; }
    }
}
