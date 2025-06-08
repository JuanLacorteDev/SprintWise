using Microsoft.EntityFrameworkCore;
using SprintWise.Dal.Models;

namespace SprintWise.Dal;

public class SWDbContext : DbContext
{
    public SWDbContext(DbContextOptions<SWDbContext> options)
           : base(options)
    {
    }
    public DbSet<USER> USERS { get; set; }
}
