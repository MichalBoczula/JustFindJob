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
    public class GetJobOfferListQueryHandler : IRequestHandler<GetJobOfferListQuery, List<JobOfferListVm>>
    {
        private readonly IJustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetJobOfferListQueryHandler(IJustFindJobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<JobOfferListVm>> Handle(GetJobOfferListQuery request, CancellationToken cancellationToken)
        {
            var result = from jobs in _context.JobOffers
                         select jobs;
            return  _mapper.Map<List<JobOfferListVm>>(
                    await result.ToListAsync(cancellationToken));
        }

    }
}
