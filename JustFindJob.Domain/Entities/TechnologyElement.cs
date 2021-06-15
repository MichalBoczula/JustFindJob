using JustFindJob.Domain.Common;

namespace JustFindJob.Domain.Entities
{
    public class TechnologyElement : AuditableEntity
    {
        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }
        public string ElementName { get; set; }
        public string ElementLevel { get; set; }
        public string Image { get; set; }
    }
}