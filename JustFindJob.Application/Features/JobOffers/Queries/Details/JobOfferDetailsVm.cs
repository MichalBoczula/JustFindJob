using JustFindJob.Domain.Entities;
using System.Collections.Generic;

namespace JustFindJob.Application.Features.JobOffers.Queries.Details
{
    public class JobOfferDetailsVm
    {
        public CompanyForJobOfferDetailsDto CompanyDto { get; set; }
        public JobOfferForJobOfferDetailsDto JobOfferDto { get; set; }
        public ProgrammingLanguageForJobOfferDetailsDto ProgrammingLanguageForJobOfferDetailsDto { get; set; }
        public ICollection<TechStackForJobOfferDetailsDto> TechStackForJobOfferDetailsDtos { get; set; }
    }
}