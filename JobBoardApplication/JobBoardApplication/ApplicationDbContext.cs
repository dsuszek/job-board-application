using JobBoardApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace JobBoardApplication;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Job> Employers { get; set; }
    public DbSet<Job> JobApplications { get; set; }
    public DbSet<Job> JobCategories { get; set; }
    public DbSet<Job> Users { get; set; }
}