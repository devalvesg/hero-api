using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Mappings
{
    internal class HeroSuperPowerMapping : IEntityTypeConfiguration<HeroSuperPowerEntity>
    {
        public void Configure(EntityTypeBuilder<HeroSuperPowerEntity> entityBuilder)
        {
            entityBuilder.ToTable("HeroSuperPowers");
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Deleted)
                .HasDefaultValue(false)
                .IsRequired();

            entityBuilder.HasIndex(t => t.Deleted)
                .IsClustered(false);

            entityBuilder.Property(t => t.HeroId)
                .IsRequired();

            entityBuilder.HasIndex(t => t.HeroId)
                .IsClustered(false);


            entityBuilder.Property(t => t.SuperPowerId)
                .IsRequired();

            entityBuilder.HasIndex(t => t.SuperPowerId)
                .IsClustered(false);
        }
    }
}
