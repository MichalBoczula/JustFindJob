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

namespace JustFindJob.Application.Features.Companies.Queries.CompanyJobs
{
    public class GetCompanyJobOffersQueryHandler : IRequestHandler<GetCompanyJobOffersQuery, List<CompanyJobOfferVm>>
    {
        private readonly IJustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetCompanyJobOffersQueryHandler(IJustFindJobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CompanyJobOfferVm>> Handle(GetCompanyJobOffersQuery request, CancellationToken cancellationToken)
        {
            var query = await (from jo in _context.JobOffers
                               join c in _context.Companies
                                   on jo.CompanyId equals c.Id
                               join pl in _context.ProgrammingLanguages
                                   on jo.ProgrammingLanguageId equals pl.Id
                               where c.Id == request.CompanyId
                               select new
                               {
                                   Job = jo,
                                   Company = c,
                                   ProgrammingLanguage = pl
                               }).ToListAsync(cancellationToken);
            var result = new List<CompanyJobOfferVm>();
            foreach (var ele in query)
            {
                result.Add(
                        new CompanyJobOfferVm
                        {
                            JobOfferDto = _mapper.Map<JobOfferForCompanyJobOfferDto>(ele.Job),
                            CompanyDto = _mapper.Map<CompanyForCompanyJobOfferListDto>(ele.Company),
                            ProgrammingLanguageDto = _mapper.Map<ProgrammingLanguageForCompanyJobOfferListDto>(ele.ProgrammingLanguage)
                        });
            }
            return result;
        }
    }
}
