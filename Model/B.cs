using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullTrailning.Model;

public class B
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public string AID { get; set; }

    public ICollection<B> Bs { get; set;}
}
