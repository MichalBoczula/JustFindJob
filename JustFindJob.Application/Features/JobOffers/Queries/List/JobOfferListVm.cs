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
        public JobOfferForJobOfferListDto JobOfferDto { get; set; }
        public CompanyForJobOfferListDto CompanyDto { get; set; }
        public ProgrammingLanguageForJobOfferListDto ProgrammingLanguageDto { get; set; }

    }
}
