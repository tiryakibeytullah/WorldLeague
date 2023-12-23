using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldLeagure.Core.Entities;

namespace WorldLeagure.Repository.DataSeeds
{
    public class TeamDataSeed : IEntityTypeConfiguration<Team>
    {
        private readonly Guid[] _countryIds;

        public TeamDataSeed(Guid[] countryIds)
        {
            _countryIds = countryIds;
        }

        public void Configure(EntityTypeBuilder<Team> builder)
        {
            #region Team for Türkiye
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso İstanbul", CountryId = _countryIds[0] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Ankara", CountryId = _countryIds[0] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso İzmir", CountryId = _countryIds[0] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Antalya", CountryId = _countryIds[0] });
            #endregion

            #region Team for Almanya
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Berlin", CountryId = _countryIds[1] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Frankfurt", CountryId = _countryIds[1] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Münih", CountryId = _countryIds[1] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Dortmund", CountryId = _countryIds[1] });
            #endregion

            #region Team for Fransa
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Paris", CountryId = _countryIds[2] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Marsilya", CountryId = _countryIds[2] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Nice", CountryId = _countryIds[2] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Lyon", CountryId = _countryIds[2] });
            #endregion

            #region Team for Hollanda
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Amsterdam", CountryId = _countryIds[3] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Rotterdam", CountryId = _countryIds[3] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Lahey", CountryId = _countryIds[3] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Eindhoven", CountryId = _countryIds[3] });
            #endregion

            #region Team for Portekiz
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Lisbon", CountryId = _countryIds[4] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Porto", CountryId = _countryIds[4] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Braga", CountryId = _countryIds[4] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Coimbra", CountryId = _countryIds[4] });
            #endregion

            #region Team for İtalya
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Roma", CountryId = _countryIds[5] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Milano", CountryId = _countryIds[5] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Venedik", CountryId = _countryIds[5] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Napoli", CountryId = _countryIds[5] });
            #endregion

            #region Team for İspanya
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Sevilla", CountryId = _countryIds[6] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Madrid", CountryId = _countryIds[6] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Barselona", CountryId = _countryIds[6] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Granada", CountryId = _countryIds[6] });
            #endregion

            #region Team for Belçika
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Brüksel", CountryId = _countryIds[7] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Brugge", CountryId = _countryIds[7] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Gent", CountryId = _countryIds[7] });
            builder.HasData(new Team() { Id = Guid.NewGuid(), Name = "Adesso Anvers", CountryId = _countryIds[7] });
            #endregion

        }
    }
}
