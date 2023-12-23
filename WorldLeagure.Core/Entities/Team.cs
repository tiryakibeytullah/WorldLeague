using System.ComponentModel.DataAnnotations.Schema;
using WorldLeagure.Core.Entities.Common;

namespace WorldLeagure.Core.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }

        [ForeignKey("GroupId")]
        public Guid GroupId { get; set; }

        public virtual Group Group { get; set; }

        [ForeignKey("CountryId")]
        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
