using FullTrailning.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullTrailning.Prestence.Mapping;

public class PersonJobMapping : IEntityTypeConfiguration<PersonJob>
{
    public void Configure(EntityTypeBuilder<PersonJob> builder)
    {
        builder.HasOne(i => i.Person)
            .WithMany(i => i.PersonJobs)
            .HasForeignKey(i => i.PersonId);

        builder.HasOne(i=> i.Job)
            .WithMany(i=> i.PersonJobs)
            .HasForeignKey(i=> i.JobId);
    }
}
