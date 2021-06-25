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
            var elements = from job in _context.JobOffers
                           join com in _context.Companies
                             on job.CompanyId equals com.Id
                           join prog in _context.ProgrammingLanguages
                             on job.ProgrammingLanguageId equals prog.Id
                           select new
                           {
                               job,
                               com,
                               prog
                           };

            List<JobOfferListVm> result = new List<JobOfferListVm>();

            foreach (var ele in await elements.ToListAsync(cancellationToken))
            {
                var companyDto = _mapper.Map<CompanyForJobOfferListDto>(ele.com);
                var jobOfferDto = _mapper.Map<JobOfferForJobOfferListDto>(ele.job);
                var languageDto = _mapper.Map<ProgrammingLanguageForJobOfferListDto>(ele.prog);

                var jobOfferVm = new JobOfferListVm()
                {
                    JobOfferDto = jobOfferDto,
                    CompanyDto = companyDto,
                    ProgrammingLanguageDto = languageDto
                };
                result.Add(jobOfferVm);
            }

            return result;
        }
    }
}