using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mappings
{
    internal class SuperPowerMapping : IEntityTypeConfiguration<SuperPowerEntity>
    {
        public void Configure(EntityTypeBuilder<SuperPowerEntity> entityBuilder)
        {
            entityBuilder.ToTable("SuperPowers");
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Deleted)
                .HasDefaultValue(false)
                .IsRequired();

            entityBuilder.HasIndex(t => t.Deleted)
                .IsClustered(false);

            entityBuilder.Property(t => t.SuperPower)
                .HasMaxLength(50)
                .IsRequired();

            entityBuilder.Property(t => t.Description)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
