using WorldLeagure.Core.Entities.Common;

namespace WorldLeagure.Core.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
