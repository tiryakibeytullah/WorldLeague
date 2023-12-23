using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldLeagure.Core.Entities;
using WorldLeagure.Repository.Consts;

namespace WorldLeagure.Repository.Configurations
{
    public class DrawReportConfiguration : IEntityTypeConfiguration<DrawReport>
    {
        public void Configure(EntityTypeBuilder<DrawReport> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
            builder.Property(b => b.Firstname).IsRequired().HasMaxLength(DrawReportConst.FirstnameMaxLength);
            builder.Property(b => b.Surname).IsRequired().HasMaxLength(DrawReportConst.SurnameMaxLength);
            builder.ToTable(DrawReportConst.TableName);
        }
    }
}
