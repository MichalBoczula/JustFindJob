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

namespace JustFindJob.Application.Features.Companies.Queries.List
{
    public class GetCompaniesListQueryHandler : IRequestHandler<GetCompaniesListQuery, List<CompanyVm>>
    {
        private readonly IJustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetCompaniesListQueryHandler(IJustFindJobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CompanyVm>> Handle(GetCompaniesListQuery request, CancellationToken cancellationToken)
        {
            var query = from c in _context.Companies
                        select c;
            List<CompanyVm> result = new List<CompanyVm>();
            foreach (var ele in await query.ToListAsync(cancellationToken))
            {
                result.Add(
                    _mapper.Map<CompanyVm>(ele));
            }
            return result;
        }
    }
}
