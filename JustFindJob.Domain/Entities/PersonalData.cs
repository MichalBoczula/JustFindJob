using JustFindJob.Domain.Common;

namespace JustFindJob.Domain.Entities
{
    public class PersonalData : AuditableEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string ProficiencyLevel { get; set; }
        public string MainTechnology { get; set; }
    }
}
