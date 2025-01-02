using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration.Mapping;
public class DirectDistanceDialingDbMap : IEntityTypeConfiguration<DirectDistanceDialing>
{
    public void Configure(EntityTypeBuilder<DirectDistanceDialing> builder)
    {
        builder.ToTable("DirectDistanceDialing");

        builder.HasKey(d => d.Id);
        
        builder.Property(d => d.CreatedOn)
            .IsRequired()
            .HasColumnType("DATETIME");
        
        builder.Property(d => d.Region)
            .IsRequired()
            .HasMaxLength(50);
    }
}
