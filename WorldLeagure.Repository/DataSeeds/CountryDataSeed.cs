using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldLeagure.Core.Entities;

namespace WorldLeagure.Repository.DataSeeds
{
    public class CountryDataSeed : IEntityTypeConfiguration<Country>
    {
        private readonly Guid[] _id;

        public CountryDataSeed(Guid[] id)
        {
            _id = id;
        }

        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(new Country() { Id = _id[0], Name = "Türkiye" });
            builder.HasData(new Country() { Id = _id[1], Name = "Almanya" });
            builder.HasData(new Country() { Id = _id[2], Name = "Fransa" });
            builder.HasData(new Country() { Id = _id[3], Name = "Hollanda" });
            builder.HasData(new Country() { Id = _id[4], Name = "Portekiz" });
            builder.HasData(new Country() { Id = _id[5], Name = "İtalya" });
            builder.HasData(new Country() { Id = _id[6], Name = "İspanya" });
            builder.HasData(new Country() { Id = _id[7], Name = "Belçika" });
        }
    }
}
