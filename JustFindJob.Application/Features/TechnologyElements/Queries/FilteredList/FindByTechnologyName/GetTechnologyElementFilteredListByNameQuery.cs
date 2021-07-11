using JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList.FindByProgrammingLanguage;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList.FindByTechnologyName
{
    public class GetTechnologyElementFilteredListByNameQuery : IRequest<List<FilteredTechnologyElementVm>>
    {
        public ListFiltersTechnologyElement Filters { get; set; }
    }
}
