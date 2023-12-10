using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullTrailning.Model;

public class A
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string BID { get; set; }

    public ICollection<A> As { get; set; }
}