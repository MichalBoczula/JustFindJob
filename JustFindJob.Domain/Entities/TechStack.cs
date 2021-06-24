using JustFindJob.Domain.Common;
using System.Collections.Generic;

namespace JustFindJob.Domain.Entities
{
    public class TechStack : AuditableEntity
    {
        public int JobOfferId { get; set; }
        public JobOffer JobOffer { get; set; }
        public int TechnologyLevelId { get; set; }
        public TechnologyLevel TechnologyLevel { get; set; }
        public int TechnologyElementId { get; set; }
        public TechnologyElement TechnologyElement { get; set; }
    }
}