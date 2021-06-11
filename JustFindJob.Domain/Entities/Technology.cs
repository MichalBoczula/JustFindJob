﻿using JustFindJob.Domain.Common;
using System.Collections.Generic;

namespace JustFindJob.Domain.Entities
{
    public class Technology : AuditableEntity
    {
        public int JobOfferId { get; set; }
        public JobOffer JobOffer { get; set; }
        public string MainTechnologyName { get; set; }
        public string MainTechnologyImage { get; set; }
        public ICollection<TechnologyElement> TechnologyElements { get; set; }
    }
}