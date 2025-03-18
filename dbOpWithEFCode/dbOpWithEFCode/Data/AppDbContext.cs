using Microsoft.EntityFrameworkCore;

namespace dbOpWithEFCode.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
        }
    }
}
