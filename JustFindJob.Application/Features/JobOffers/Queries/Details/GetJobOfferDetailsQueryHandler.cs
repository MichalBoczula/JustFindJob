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
    public class GetJobOfferDetailsQueryHandler  /* : IRequestHandler<GetJobOfferDetailsQuery, JobOfferDetailsVm>*/
    {
        //private readonly IMapper _mapper;
        //private readonly IJobOfferRepository _jobOfferRepository;
        //private readonly ICompanyRepository _companyRepository;
        //private readonly ITechnologyRepository _technologyRepository;

        //public GetJobOfferDetailsQueryHandler(IMapper mapper,
        //                                      IJobOfferRepository jobOfferRepository,
        //                                      ICompanyRepository companyRepository,
        //                                      ITechnologyRepository technologyRepository)
        //{
        //    _mapper = mapper;
        //    _jobOfferRepository = jobOfferRepository;
        //    _companyRepository = companyRepository;
        //    _technologyRepository = technologyRepository;
        //}

        //public async Task<JobOfferDetailsVm> Handle(GetJobOfferDetailsQuery request, CancellationToken cancellationToken)
        //{
        //    var result = await _jobOfferRepository.GetList();
        //    return _mapper.Map<JobOfferDetailsVm>(result.ToList().FirstOrDefaultAsync(x => x.Id == request.JobOfferId)); 
        //}
    }
}
