using Microsoft.AspNetCore.Mvc;
using JobBoardApplication.Services;
using JobBoardApplication.DTOs;

namespace JobBoardApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobController : ControllerBase
{
    private readonly JobService _jobService;

    public JobController(JobService jobService)
    {
        _jobService = jobService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobDTO>>> GetAllJobs()
    {
        var jobs = await _jobService.GetAllJobs();
        return Ok(jobs.Select(j => new JobDTO
        {
            Title = j.Title,
            Description = j.Description,
            Salary = j.Salary
        }));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<JobDTO>> GetJobById(int id)
    {
        var job = await _jobService.GetJobById(id);
        if (job == null)
        {
            return NotFound();
        }

        return Ok(new JobDTO
        {
            Title = job.Title,
            Description = job.Description,
            Salary = job.Salary
        });
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateJob(int id, JobDTO jobDto)
    {
        var job = await _jobService.GetJobById(id);
        if (job == null)
        {
            return NotFound();
        }

        job.Title = jobDto.Title;
        job.Description = jobDto.Description;
        job.Salary = jobDto.Salary;
        await _jobService.UpdateJob(job);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteJob(int id)
    {
        await _jobService.DeleteJob(id);
        return NoContent();
    }
}