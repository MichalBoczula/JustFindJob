using AutoMapper;
using JustFindJob.Application.Features.JobOffers.Queries.Details;
using JustFindJob.Application.Features.JobOffers.Queries.List;
using JustFindJob.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            #region JobOffer Queries;

            CreateJobOfferListMapping();
            CreateJobOfferDetailsMapping();
            #endregion

        }


        private void CreateJobOfferListMapping()
        {
            CreateMap<ProgrammingLanguage, ProgrammingLanguageDtoForJobOfferList>().ReverseMap();
            CreateMap<Company, CompanyDtoForJobOfferList>().ReverseMap();
            CreateMap<JobOffer, JobOfferDtoForJobOfferList>()
                .ForMember(j => j.ExperienceLevel, opt => opt.MapFrom(x => x.ExperienceLevel.ToString()))
                .ReverseMap();

        }

        private void CreateJobOfferDetailsMapping()
        {
            CreateMap<Company, CompanyForJobOfferDetailsDto>().ReverseMap();
            CreateMap<JobOffer, JobOfferForJobOfferDetailsDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, ProgrammingLanguageForJobOfferDetailsDto>().ReverseMap();
            CreateMap<TechnologyElement, TechnologyElementForJobOfferDetailsDto>().ReverseMap();
            CreateMap<TechnologyLevel, TechnologyLevelForJobOfferDetailsDto>().ReverseMap();
            CreateMap<TechStack, TechStackForJobOfferDetailsDto>().ReverseMap();
        }
    }
}
