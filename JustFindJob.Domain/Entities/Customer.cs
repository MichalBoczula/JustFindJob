using JustFindJob.Domain.Common;
using System;
using System.Collections.Generic;

namespace JustFindJob.Domain.Entities
{
    public class Customer : AuditableEntity
    {
        public Guid CustomerUniqueCode { get; set; }
        public PersonalData PersonalData { get; set; }
        public ICollection<JobOffer> Applied { get; set; }
    }
}