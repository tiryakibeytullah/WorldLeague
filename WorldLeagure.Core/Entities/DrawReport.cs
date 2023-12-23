using System.ComponentModel.DataAnnotations.Schema;
using WorldLeagure.Core.Entities.Common;

namespace WorldLeagure.Core.Entities
{
    public class DrawReport : BaseEntity
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }

        [ForeignKey("GroupId")]
        public Guid GroupId { get; set; }

        public virtual Group Group { get; set; }

        [ForeignKey("TeamId")]
        public Guid TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
