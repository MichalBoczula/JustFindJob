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

namespace JustFindJob.Application.Features.ProgrammingLanguages.Queries.List
{
    public class GetProgrammingLanguageListQueryHandler : IRequestHandler<GetProgrammingLanguageListQuery, List<ProgrammingLanguagesVm>>
    {
        private readonly IJustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetProgrammingLanguageListQueryHandler(IJustFindJobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ProgrammingLanguagesVm>> Handle(GetProgrammingLanguageListQuery request, CancellationToken cancellationToken)
        {
            var query = from pl in _context.ProgrammingLanguages
                        select pl;
            var result = new List<ProgrammingLanguagesVm>();
            foreach(var ele in await query.ToListAsync(cancellationToken))
            {
                result.Add(
                    _mapper.Map<ProgrammingLanguagesVm>(ele));
            }
            return result;
        }
    }
}
