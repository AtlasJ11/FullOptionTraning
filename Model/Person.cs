namespace FullTrailning.Model;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string? PhoneNumber { get; set; }
    public ICollection<PersonJob> PersonJobs { get; set; }
}
