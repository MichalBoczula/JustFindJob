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

namespace JustFindJob.Application.Features.Companies.Queries.Details
{
    public class GetCompanyDetailsQueryHandler : IRequestHandler<GetCompanyDetailsQuery, CompanyDetailsVm>
    {
        private readonly IJustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetCompanyDetailsQueryHandler(IJustFindJobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CompanyDetailsVm> Handle(GetCompanyDetailsQuery request, CancellationToken cancellationToken)
        {
            var query = await (from c in _context.Companies
                        where c.Id == request.CompanyId
                        join cd in _context.CompanyDetails
                            on c.Id equals cd.CompanyId
                        select new
                        {
                            Company = c,
                            CompnayDetails = cd
                        }).FirstOrDefaultAsync(cancellationToken: cancellationToken);

            return new CompanyDetailsVm
            {
                CompanyBasicInfo = _mapper.Map<CompanyBasicInformationDto>(query.Company),
                CompanyExtendedInfo = _mapper.Map<CompanyExtendedInformationDto>(query.CompnayDetails)
            };
        }
    }
}
