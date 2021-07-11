using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList
{
    public class GetTechnologyElementFilteredListQuery : IRequest<List<FilteredTechnologyElementVm>>
    {
        public ListFiltersTechnologyElement Filters { get; set; }
    }
}
