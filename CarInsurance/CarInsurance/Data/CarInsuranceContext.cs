using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Data
{
    public class CarInsuranceContext: DbContext
    {

        public CarInsuranceContext()
        {
            
        }

        public CarInsuranceContext(DbContextOptions<CarInsuranceContext> options) : base(options)
        {
        }

        public DbSet<CarInsurance.Models.Insuree> Insuree { get; set; }
    }

}
