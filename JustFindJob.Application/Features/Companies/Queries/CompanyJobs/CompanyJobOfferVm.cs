using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.Companies.Queries.CompanyJobs
{
    public class CompanyJobOfferVm
    {
        public JobOfferForCompanyJobOfferDto JobOfferDto { get; set; }
        public CompanyForCompanyJobOfferListDto CompanyDto { get; set; }
        public ProgrammingLanguageForCompanyJobOfferListDto ProgrammingLanguageDto { get; set; }
    }
}
