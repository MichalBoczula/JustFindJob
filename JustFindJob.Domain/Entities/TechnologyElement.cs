using JustFindJob.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Domain.Entities
{
    public class TechnologyElement : AuditableEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
#nullable enable
        public int? ProgrammingLanguageId { get; set; }
        public ProgrammingLanguage? ProgrammingLanguage { get; set; }
#nullable disable
    }
}
