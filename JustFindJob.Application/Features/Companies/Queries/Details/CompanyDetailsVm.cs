using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.Companies.Queries.Details
{
    public class CompanyDetailsVm
    {
        public CompanyBasicInformationDto CompanyBasicInfo { get; set; }
        public CompanyExtendedInformationDto CompanyExtendedInfo { get; set; }
    }
}
