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

            entityBuilder.HasOne(hsp => hsp.Hero)
                .WithMany(h => h.HeroSuperPowers)
                .HasForeignKey(hsp => hsp.HeroId)
                .OnDelete(DeleteBehavior.Cascade);

            entityBuilder.HasOne(hsp => hsp.SuperPower)
                .WithMany(sp => sp.HeroSuperPowers)
                .HasForeignKey(hsp => hsp.SuperPowerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
