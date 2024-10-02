using JobBoardApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace JobBoardApplication;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Job> Jobs { get; set; }
}