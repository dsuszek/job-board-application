namespace JobBoardApplication.Models;

public class Job
{
    public int JobId { get; private set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Salary { get; set; }
    public string InternalNotes { get; set; }
    public DateTime CreatedAt { get; private set; }
    
    public Job()
    {
        CreatedAt = DateTime.UtcNow;  // Automatically set current time when a job is created
    }
}