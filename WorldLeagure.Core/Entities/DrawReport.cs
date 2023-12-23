using WorldLeagure.Core.Entities.Common;

namespace WorldLeagure.Core.Entities
{
    public class DrawReport : BaseEntity
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public Guid GroupId { get; set; }
        public Guid TeamId { get; set; }
    }
}
