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

            var techStacks = await (from tech in _context.TechStacks
                             where tech.JobOfferId == request.JobOfferId
                             join techEle in _context.TechnologyElements
                                on tech.TechnologyElementId equals techEle.Id
                             join techLevel in _context.TechnologyLevels
                                on tech.TechnologyLevelId equals techLevel.Id
                             select new { 
                                 techEle, 
                                 techLevel })
                            .ToListAsync(cancellationToken);

            var result = await (
                         from job in _context.JobOffers
                         where job.Id == request.JobOfferId
                         join comp in _context.Companies
                            on job.CompanyId equals comp.Id
                         join progLan in _context.ProgrammingLanguages
                             on job.ProgrammingLanguageId equals progLan.Id
                         select new
                         {
                             job,
                             comp,
                             progLan,
                         })
                         .FirstOrDefaultAsync(cancellationToken);

            var jobOffer = _mapper.Map<JobOfferForJobOfferDetailsDto>(result.job);
            var company = _mapper.Map<CompanyForJobOfferDetailsDto>(result.comp);
            var language = _mapper.Map<ProgrammingLanguageForJobOfferDetailsDto>(result.progLan);
            var techStackList = new List<TechStackForJobOfferDetailsDto>();

            foreach(var ele in techStacks)
            {
                var techLevel = _mapper.Map<TechnologyLevelForJobOfferDetailsDto>(ele.techLevel);
                var techElement = _mapper.Map<TechnologyElementForJobOfferDetailsDto>(ele.techEle);

                var techStack = new TechStackForJobOfferDetailsDto()
                {
                    TechnologyElementDto = techElement,
                    TechnologyLevelDto = techLevel
                };

                techStackList.Add(techStack);
            }

            return new JobOfferDetailsVm()
            {
                JobOfferDto = jobOffer,
                CompanyDto = company,
                ProgrammingLanguageDto = language,
                TechStackDtos = techStackList
            };
        }
    }
}
