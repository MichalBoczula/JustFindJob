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

namespace JustFindJob.Application.Features.JobOffers.Queries.Details
{
    public class GetJobOfferDetailsQueryHandler : IRequestHandler<GetJobOfferDetailsQuery, JobOfferDetailsVm>
    {
        private readonly IJustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetJobOfferDetailsQueryHandler(IJustFindJobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<JobOfferDetailsVm> Handle(GetJobOfferDetailsQuery request, CancellationToken cancellationToken)
        {
            var result = from job in _context.JobOffers
                         where job.Id == request.JobOfferId
                         join tech in _context.Technologies
                            on job.Id equals tech.JobOfferId
                         join company in _context.Companies
                            on job.CompanyId equals company.Id
                         select job;
            return _mapper.Map<JobOfferDetailsVm>(
                    await result.FirstOrDefaultAsync(cancellationToken));
        }
    }
}
