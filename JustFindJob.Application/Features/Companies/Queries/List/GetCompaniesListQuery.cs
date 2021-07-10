using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.Companies.Queries.List
{
    public class GetCompaniesListQuery : IRequest<List<CompanyVm>>
    {
    }
}
