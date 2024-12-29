using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration.Mapping;
public class DddDbMap : IEntityTypeConfiguration<Ddd>
{
    public void Configure(EntityTypeBuilder<Ddd> builder)
    {
        builder.ToTable("DDD");

        builder.HasKey(d => d.Id);
        builder.Property(d => d.Id)
            .IsRequired()
            .HasColumnType("UNIQUEIDENTIFIER");

        builder.Property(d => d.CreatedOn)
            .IsRequired()
            .HasColumnType("DATETIME");

        builder.Property(d => d.Code)
            .IsRequired()
            .HasMaxLength(99);

        builder.Property(d => d.Region)
            .IsRequired()
            .HasMaxLength(50);
    }
}
