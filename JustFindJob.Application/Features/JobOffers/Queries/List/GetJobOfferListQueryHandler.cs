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

namespace JustFindJob.Application.Features.JobOffers.Queries.List
{
    public class GetJobOfferListQueryHandler : IRequestHandler<GetJobOfferListQuery, JobOfferListVm>
    {
        private readonly IJobOfferDbContext _context;
        private readonly IMapper _mapper;

        public GetJobOfferListQueryHandler(IJobOfferDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<JobOfferListVm> Handle(GetJobOfferListQuery request, CancellationToken cancellationToken)
        {
            var result = from jo in _context.JobOffers
                         select jo;
            return _mapper.Map<JobOfferListVm>(await result.ToListAsync(cancellationToken));
        }
    }
}
