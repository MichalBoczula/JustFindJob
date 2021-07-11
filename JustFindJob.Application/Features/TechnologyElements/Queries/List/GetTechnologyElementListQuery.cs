using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.TechnologyElements.Queries.List
{
    public class GetTechnologyElementListQuery : IRequest<List<TechStackVm>>
    {
    }
}
