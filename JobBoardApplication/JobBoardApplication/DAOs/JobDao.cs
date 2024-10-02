using JobBoardApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace JobBoardApplication.DAOs;

public class JobDao
{
    private readonly ApplicationDbContext _context;

    public JobDao(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Job> GetJobById(int id)
    {
        return await _context.Jobs.FindAsync(id);
    }

    public async Task<List<Job>> GetAllJobs()
    {
        return await _context.Jobs.ToListAsync();
    }

    public async Task CreateJob(Job job)
    {
        _context.Jobs.Add(job);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateJob(Job job)
    {
        _context.Jobs.Update(job);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteJob(int id)
    {
        var job = await _context.Jobs.FindAsync(id);

        if (job == null)
        {
            return;
        }

        _context.Jobs.Remove(job);
        await _context.SaveChangesAsync();
    }
}