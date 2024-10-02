using JobBoardApplication.DAOs;
using JobBoardApplication.Models;

namespace JobBoardApplication.Services;

public class JobService
{
    private readonly JobDao _jobDao;

    public JobService(JobDao jobDao)
    {
        _jobDao = jobDao;
    }

    public async Task<Job> GetJobById(int id)
    {
        return await _jobDao.GetJobById(id);
    }

    public async Task<List<Job>> GetAllJobs()
    {
        return await _jobDao.GetAllJobs();
    }

    public async Task CreateJob(Job job)
    {
        await _jobDao.CreateJob(job);
    }

    public async Task UpdateJob(Job job)
    {
        await _jobDao.UpdateJob(job);
    }

    public async Task DeleteJob(int id)
    {
        await _jobDao.DeleteJob(id);
    }
}