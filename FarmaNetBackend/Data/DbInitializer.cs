using FarmaNetBackend.Models;
using System.Linq;

namespace FarmaNetBackend.Data
{
    public class DbInitializer
    {
        public static void Initialize(PharmacyDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Manufacturers.Any())
            {
                return;
            }

            var manufacturers = new Manufacturer[]
            {
                new Manufacturer{Name="Ромашка", Address="Красноармейская, 110"}
            };

            foreach (Manufacturer m in manufacturers)
            {
                context.Manufacturers.Add(m);
            }
            context.SaveChanges();
        }
    }
}
