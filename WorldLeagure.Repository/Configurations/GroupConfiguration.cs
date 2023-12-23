using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldLeagure.Core.Entities;
using WorldLeagure.Repository.Consts;

namespace WorldLeagure.Repository.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
            builder.Property(b => b.Name).IsRequired().HasMaxLength(GroupConst.NameMaxLength);
            builder.ToTable(GroupConst.TableName);
        }
    }
}
