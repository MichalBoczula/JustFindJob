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
        private readonly IJobOfferDbContext _context;
        private readonly IMapper _mapper;

        public GetJobOfferDetailsQueryHandler(IJobOfferDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<JobOfferDetailsVm> Handle(GetJobOfferDetailsQuery request, CancellationToken cancellationToken)
        {
            var result = from jo in _context.JobOffers 
                         where jo.Id == request.JobOfferId 
                         select jo;
            return _mapper.Map<JobOfferDetailsVm>(await result.FirstOrDefaultAsync(cancellationToken)); 
        }
    }
}
