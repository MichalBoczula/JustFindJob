using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList.FindByProgrammingLanguage
{
    public class GetTechnologyElementFilteredListByLanguageQuery : IRequest<List<FilteredTechnologyElementVm>>
    {
        public ListFiltersTechnologyElement Filters { get; set; }
    }
}
