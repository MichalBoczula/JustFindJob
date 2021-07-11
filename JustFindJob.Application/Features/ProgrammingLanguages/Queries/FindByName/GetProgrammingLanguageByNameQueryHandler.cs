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

namespace JustFindJob.Application.Features.ProgrammingLanguages.Queries.FindByName
{
    public class GetProgrammingLanguageByNameQueryHandler : IRequestHandler<GetProgrammingLanguageByNameQuery, ProgrammingLanguagesVm>
    {
        private readonly IJustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetProgrammingLanguageByNameQueryHandler(IJustFindJobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ProgrammingLanguagesVm> Handle(GetProgrammingLanguageByNameQuery request, CancellationToken cancellationToken)
        {
            var query = from pl in _context.ProgrammingLanguages
                        where pl.Name == request.ProgrammingLangaugeName
                        select pl;
            return _mapper.Map<ProgrammingLanguagesVm>(await query.FirstOrDefaultAsync(cancellationToken));
        }
    }
}
