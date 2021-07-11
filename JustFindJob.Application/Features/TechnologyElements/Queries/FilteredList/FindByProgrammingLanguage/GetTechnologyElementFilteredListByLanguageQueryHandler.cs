using AutoMapper;
using JustFindJob.Application.Contracts.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.TechnologyElements.Queries.FilteredList.FindByProgrammingLanguage
{
    public class GetTechnologyElementFilteredListByLanguageQueryHandler : IRequestHandler<GetTechnologyElementFilteredListByLanguageQuery, List<FilteredTechnologyElementVm>>
    {
        private readonly IJustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetTechnologyElementFilteredListByLanguageQueryHandler(IJustFindJobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<FilteredTechnologyElementVm>> Handle(GetTechnologyElementFilteredListByLanguageQuery request, CancellationToken cancellationToken)
        {
            var query = from te in _context.TechnologyElements
                        join pl in _context.ProgrammingLanguages
                            on te.ProgrammingLanguageId equals pl.Id
                                into ele
                        from pl in ele.DefaultIfEmpty()
                        where
                           (request.Filters.ProgrammingLanguages.Count != 0 ?
                           request.Filters.ProgrammingLanguages.Contains(pl.Name) :
                           true)
                        select new
                        {
                            TechnologyElement = te,
                            ProgrammingLanguage = pl
                        };
            var result = new List<FilteredTechnologyElementVm>();
            foreach (var ele in await query.ToListAsync(cancellationToken))
            {
                result.Add(
                    new FilteredTechnologyElementVm
                    {
                        ProgrammingLanguageDto = _mapper.Map<ProgrammingLanguageForTechnologyElementFilteredListDto>(ele.ProgrammingLanguage),
                        TechnologyElementDto = _mapper.Map<TechnologyElementForTechnologyElementFilteredListDto>(ele.TechnologyElement),
                    });
            }
            return result;
        }
    }
}
