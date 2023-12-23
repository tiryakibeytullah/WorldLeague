using WorldLeagure.Core.Entities.Common;

namespace WorldLeagure.Core.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
