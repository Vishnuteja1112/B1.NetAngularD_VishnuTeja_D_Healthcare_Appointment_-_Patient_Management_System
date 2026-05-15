using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PatientService.Data
{
    public class PatientDbContextFactory : IDesignTimeDbContextFactory<PatientDbContext>
    {
        public PatientDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PatientDbContext>();

            optionsBuilder.UseSqlServer(
    "Server=192.168.1.5,1433;Database=PatientDB;User Id=sa;Password=2003;TrustServerCertificate=True;"
);

            return new PatientDbContext(optionsBuilder.Options);
        }
    }
}