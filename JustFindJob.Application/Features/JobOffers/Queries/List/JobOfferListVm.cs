using JustFindJob.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.JobOffers.Queries.List
{
    public class JobOfferListVm
    {
        public JobOfferDtoForJobOfferList JobOfferDto { get; set; }
        public CompanyDtoForJobOfferList CompanyDto { get; set; }
        public ProgrammingLanguageDtoForJobOfferList ProgrammingLanguageDto { get; set; }

    }
}
