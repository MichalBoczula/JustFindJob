using JustFindJob.Domain.Common;

namespace JustFindJob.Domain.Entities
{
    public class TechnologyElement : AuditableEntity
    {
        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }
        public string ElementName { get; set; }
        public int ElementLevel { get; set; }
    }
}