using JustFindJob.Domain.Entities;

namespace JustFindJob.Application.Features.JobOffers.Queries.Details
{
    public class JobOfferDetailsVm
    {
        public CompanyForJobOfferDetailsDto CompanyDto { get; set; }
        public TechnologyForJobOfferDto TechnologyDto{ get; set; }
        public JobOfferForJobOfferDetailsDto JobOfferDto { get; set; }
    }
}