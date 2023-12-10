namespace FullTrailning.Model;

public class PersonJob
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }
}
