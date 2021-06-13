using System.Collections.Generic;

namespace JustFindJob.Application.Features.JobOffers.Queries.Details
{
    public class TechnologyForJobOfferDto
    {
        public string MainTechnologyName { get; set; }
        public string MainTechnologyImage { get; set; }
        public ICollection<TechnologyElementDto> TechnologyElementDtos { get; set; }
    }
}