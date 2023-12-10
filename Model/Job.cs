namespace FullTrailning.Model;

public class Job
{
    public int Id { get; set; }
    public string JobId { get; set; }
    public string JobName { get; set; }
    public string JobDescription { get; set; }

    public ICollection<PersonJob> PersonJobs { get; set; }
}
