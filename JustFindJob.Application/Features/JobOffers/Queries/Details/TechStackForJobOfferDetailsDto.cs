using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.JobOffers.Queries.Details
{
    public class TechStackForJobOfferDetailsDto
    {
        public TechnologyElementForJobOfferDetailsDto TechnologyElementDto { get; set; }
        public TechnologyLevelForJobOfferDetailsDto TechnologyLevelDto { get; set; }
    }
}
