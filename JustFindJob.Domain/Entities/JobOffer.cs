using JustFindJob.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Domain.Entities
{
    public class JobOffer : AuditableEntity
    {
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public Technology Technology { get; set; }
        public bool OfferStatus { get; set; }
        public string Localization { get; set; }
        public string ExperienceLevel { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
