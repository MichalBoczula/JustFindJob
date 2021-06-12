using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Domain.Entities
{
    public class Customer
    {
        public string FirstName{ get; set; }
        public string  LastName { get; set; }
        public string  MainTechnologyName { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
    }
}
