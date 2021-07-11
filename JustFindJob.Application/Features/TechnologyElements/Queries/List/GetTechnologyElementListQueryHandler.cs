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

namespace JustFindJob.Application.Features.TechnologyElements.Queries.List
{
    public class GetTechnologyElementListQueryHandler : IRequestHandler<GetTechnologyElementListQuery, List<TechnologyElementVm>>
    {
        private readonly IJustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetTechnologyElementListQueryHandler(IJustFindJobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<TechnologyElementVm>> Handle(GetTechnologyElementListQuery request, CancellationToken cancellationToken)
        {
            var query = await (from te in _context.TechnologyElements
                               join pl in _context.ProgrammingLanguages
                                   on te.ProgrammingLanguageId equals pl.Id
                                       into ele
                               from pl in ele.DefaultIfEmpty()
                               select new
                               {
                                   TechnologyElement = te,
                                   ProgrammingLanguage = pl
                               }).ToListAsync(cancellationToken);
            List<TechnologyElementVm> result = new List<TechnologyElementVm>();
            foreach (var ele in query)
            {
                result.Add(
                    new TechnologyElementVm
                    {
                        TechnologyElementDto = _mapper.Map<TechnologyElementForTechnologyElementListDto>(ele.TechnologyElement),
                        ProgrammingLanguageDto = _mapper.Map<ProgrammingLanguageForTechnologyElementListDto>(ele.ProgrammingLanguage)
                    });
            }
            return result;
        }
    }
}
