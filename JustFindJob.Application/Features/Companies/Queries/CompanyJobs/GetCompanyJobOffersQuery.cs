using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.Companies.Queries.CompanyJobs
{
    public class GetCompanyJobOffersQuery : IRequest<List<CompanyJobOfferVm>>
    {
        public int CompanyId { get; set; }
    }
}
