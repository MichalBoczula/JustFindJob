using JustFindJob.Domain.Entities;

namespace JustFindJob.Application.Features.JobOffers.Queries.Details
{
    public class JobOfferDetailsVm
    {
        public CompanyForJobOfferDto CompanyDto { get; set; }
        public TechnologyForJobOfferDto TechnologyDto{ get; set; }
        public string Localization { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string LongDescription { get; set; }
    }
}