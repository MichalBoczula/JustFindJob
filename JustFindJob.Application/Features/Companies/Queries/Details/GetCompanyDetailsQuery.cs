using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.Companies.Queries.Details
{
    public class GetCompanyDetailsQuery : IRequest<CompanyDetailsVm>
    {
        public int CompanyId { get; set; }
    }
}
