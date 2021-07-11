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

namespace JustFindJob.Application.Features.JobOffers.Queries.FilteredList
{
    public class GetFilteredJobOfferListHandler : IRequestHandler<GetFilteredJobOfferListQuery, List<FilteredJobOfferListVm>>
    {
        private readonly IJustFindJobDbContext _context;
        private readonly IMapper _mapper;

        public GetFilteredJobOfferListHandler(IJustFindJobDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<FilteredJobOfferListVm>> Handle(GetFilteredJobOfferListQuery request, CancellationToken cancellationToken)
        {
            var query = from job in _context.JobOffers
                        join comp in _context.Companies
                            on job.CompanyId equals comp.Id
                        join lang in _context.ProgrammingLanguages
                            on job.ProgrammingLanguageId equals lang.Id
                        where (request.Filters.ProgrammingLanguages.Count != 0 ?
                            request.Filters.ProgrammingLanguages.Contains(lang.Name) :
                            true) &&
                            (request.Filters.ExpLevels.Count != 0 ?
                            request.Filters.ExpLevels.Contains(job.ExperienceLevel) :
                            true) &&
                            (request.Filters.Localizations.Count != 0 ?
                            request.Filters.Localizations.Contains(job.Localization) :
                            true)
                        select new
                        {
                            job,
                            comp,
                            lang
                        };

            var result = new List<FilteredJobOfferListVm>();

            foreach (var ele in await query.ToListAsync(cancellationToken))
            {
                var jobDto = _mapper.Map<JobOfferForFilteredListDto>(ele.job);
                var companyDto = _mapper.Map<CompanyForFilteredJobOfferDto>(ele.comp);
                var progLangDto = _mapper.Map<ProgrammingLanguageForFilteredListDto>(ele.lang);

                var item = new FilteredJobOfferListVm()
                {
                    JobOfferDto = jobDto,
                    CompanyDto = companyDto,
                    ProgrammingLanguageDto = progLangDto
                };

                result.Add(item);
            }

            return result;
        }
    }
}
