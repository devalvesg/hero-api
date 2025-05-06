using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mappings
{
    internal class HeroMapping : IEntityTypeConfiguration<HeroEntity>
    {
        public void Configure(EntityTypeBuilder<HeroEntity> entityBuilder)
        {
            entityBuilder.ToTable("Heroes");
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Deleted)
                .HasDefaultValue(false)
                .IsRequired();

            entityBuilder.HasIndex(t => t.Deleted)
                .IsClustered(false);

            entityBuilder.Property(t => t.Height)
                .HasPrecision(3, 2)
                .IsRequired();
            
            entityBuilder.Property(t => t.Weight)
                .HasPrecision(6, 2)
                .IsRequired();
            
            entityBuilder.Property(t => t.Name)
                .HasMaxLength(120)
                .IsRequired();
            
            entityBuilder.Property(t => t.HeroName)
                .HasMaxLength(120)
                .IsRequired();

            entityBuilder.Property(t => t.Birthday);
        }
    }
}
