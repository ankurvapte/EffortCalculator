using Microsoft.EntityFrameworkCore;

namespace EffortCalculator;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}
