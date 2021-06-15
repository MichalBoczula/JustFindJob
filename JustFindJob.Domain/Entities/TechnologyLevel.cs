using JustFindJob.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Domain.Entities
{
    public class TechnologyLevel : AuditableEntity
    {
        public string Level { get; set; }
    }
}
