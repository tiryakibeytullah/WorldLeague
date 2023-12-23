using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldLeagure.Core.Entities;

namespace WorldLeagure.Repository.DataSeeds
{
    public class GroupDataSeed : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasData(new Group() { Id = Guid.NewGuid(), Name = "A Grubu" });
            builder.HasData(new Group() { Id = Guid.NewGuid(), Name = "B Grubu" });
            builder.HasData(new Group() { Id = Guid.NewGuid(), Name = "C Grubu" });
            builder.HasData(new Group() { Id = Guid.NewGuid(), Name = "D Grubu" });
            builder.HasData(new Group() { Id = Guid.NewGuid(), Name = "E Grubu" });
            builder.HasData(new Group() { Id = Guid.NewGuid(), Name = "F Grubu" });
            builder.HasData(new Group() { Id = Guid.NewGuid(), Name = "G Grubu" });
            builder.HasData(new Group() { Id = Guid.NewGuid(), Name = "H Grubu" });
        }
    }
}
