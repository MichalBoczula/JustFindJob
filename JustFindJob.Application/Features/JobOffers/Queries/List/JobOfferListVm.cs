using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.JobOffers.Queries.List
{
    public class JobOfferListVm
    {
        public string CompanyName { get; set; }
        public string Localization { get; set; }
        public string ExperienceLevel { get; set; }
        public string MainTechnologyName { get; set; }
        public string MainTechnologyImage { get; set; }
    }
}
