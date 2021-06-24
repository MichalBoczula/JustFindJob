using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.JobOffers.Queries.Details
{
    public class TechStackForJobOfferDetailsDto
    {
        public TechnologyElementForJobOfferDetailsDto TechnologyElementForJobOfferDetailsDto { get; set; }
        public TechnologyLevelForJobOfferDetailsDto TechnologyLevelForJobOfferDetailsDto { get; set; }
    }
}
