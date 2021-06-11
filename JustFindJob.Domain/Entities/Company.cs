using JustFindJob.Domain.Common;
using System.Collections.Generic;

namespace JustFindJob.Domain.Entities
{
    public class Company : AuditableEntity
    {
        public ICollection<JobOffer> JobOffers { get; set; }
        public CompanyDetails CompanyDetails { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string EstablishedDate { get; set; }
        public string Image { get; set; }

    }
}