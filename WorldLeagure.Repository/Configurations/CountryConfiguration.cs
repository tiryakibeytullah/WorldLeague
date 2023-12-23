using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldLeagure.Core.Entities;
using WorldLeagure.Repository.Consts;

namespace WorldLeagure.Repository.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
            builder.Property(b => b.Name).IsRequired().HasMaxLength(CountryConst.NameMaxLength);
            builder.ToTable(CountryConst.TableName);
        }
    }
}
