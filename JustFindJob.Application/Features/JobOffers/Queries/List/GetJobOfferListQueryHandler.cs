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
        private readonly IJobOfferRepository _repository;
        private readonly IMapper _mapper;

        public GetJobOfferListQueryHandler(IJobOfferRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<JobOfferListVm>> Handle(GetJobOfferListQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetList();
            return _mapper.Map<List<JobOfferListVm>>(result);
        }

    }
}
