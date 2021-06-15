using JustFindJob.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Domain.Entities
{
    public class ProgrammingLanguage : AuditableEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
