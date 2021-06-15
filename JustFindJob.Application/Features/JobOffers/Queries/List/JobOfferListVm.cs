using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.JobOffers.Queries.List
{
    public class JobOfferListVm
    {
        public CompanyDtoForJobOfferList CompanyDto { get; set; }
        public JobOfferDtoForJobOfferList JobOfferDto { get; set; }
        public TechnologyDtoForJobOfferList TechnologyDto { get; set; }
    }
}
