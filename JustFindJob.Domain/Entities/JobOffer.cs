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
        public ICollection<TechStack> TechStacks { get; set; }
        public int ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
        public string Localization { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}
