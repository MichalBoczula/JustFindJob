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
            var elements = await (from job in _context.JobOffers
                                  join com in _context.Companies
                                    on job.CompanyId equals com.Id
                                  join tech in _context.TechStacks
                                    on job.Id equals tech.JobOfferId
                                  select new
                                  {
                                      job,
                                      com,
                                      tech
                                  }).ToListAsync(cancellationToken);

            List<JobOfferListVm> result = new List<JobOfferListVm>();

            foreach (var ele in elements)
            {
                var companyDto = _mapper.Map<CompanyDtoForJobOfferList>(ele.com);
                var jobOfferDto = _mapper.Map<JobOfferDtoForJobOfferList>(ele.job);
                var technologyDto = _mapper.Map<TechnologyDtoForJobOfferList>(ele.tech);

                var jobOfferVm = new JobOfferListVm()
                {
                    JobOfferDto = jobOfferDto,
                    CompanyDto = companyDto,
                    TechnologyDto = technologyDto
                };
                result.Add(jobOfferVm);
            }

            return result;
        }
    }
}