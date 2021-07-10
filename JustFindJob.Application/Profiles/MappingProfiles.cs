using AutoMapper;
using JustFindJob.Application.Features.Companies.Queries.CompanyJobs;
using JustFindJob.Application.Features.Companies.Queries.Details;
using JustFindJob.Application.Features.Companies.Queries.List;
using JustFindJob.Application.Features.JobOffers.Queries.Details;
using JustFindJob.Application.Features.JobOffers.Queries.FilteredList;
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
            CreateJobOfferFilteredListMapping();
            #endregion
            #region Company Queries;
            CreateCompanyListMapping();
            CreateCompanyDetailsMapping();
            CreateCompanyJobOfferMapping();
            #endregion
        }

        private void CreateJobOfferListMapping()
        {
            CreateMap<ProgrammingLanguage, ProgrammingLanguageForJobOfferListDto>().ReverseMap();
            CreateMap<Company, CompanyForJobOfferListDto>().ReverseMap();
            CreateMap<JobOffer, JobOfferForJobOfferListDto>()
                .ForMember(j => j.ExperienceLevel, opt => opt.MapFrom(x => x.ExperienceLevel.ToString()))
                .ReverseMap();
        }

        private void CreateJobOfferDetailsMapping()
        {
            CreateMap<Company, CompanyForJobOfferDetailsDto>().ReverseMap();
            CreateMap<JobOffer, JobOfferForJobOfferDetailsDto>()
                .ForMember(j => j.ExperienceLevel, opt => opt.MapFrom(x => x.ExperienceLevel.ToString()))
                .ReverseMap();
            CreateMap<ProgrammingLanguage, ProgrammingLanguageForJobOfferDetailsDto>().ReverseMap();
            CreateMap<TechnologyElement, TechnologyElementForJobOfferDetailsDto>().ReverseMap();
            CreateMap<TechnologyLevel, TechnologyLevelForJobOfferDetailsDto>().ReverseMap();
            CreateMap<TechStack, TechStackForJobOfferDetailsDto>().ReverseMap();
        }

        private void CreateJobOfferFilteredListMapping()
        {
            CreateMap<ProgrammingLanguage, ProgrammingLanguageForFilteredListDto>().ReverseMap();
            CreateMap<Company, CompanyForFilteredJobOfferDto>().ReverseMap();
            CreateMap<JobOffer, JobOfferForFilteredListDto>()
                .ForMember(j => j.ExperienceLevel, opt => opt.MapFrom(x => x.ExperienceLevel.ToString()))
                .ReverseMap();
        }

        private void CreateCompanyListMapping()
        {
            CreateMap<Company, CompanyVm>().ReverseMap();
        }

        private void CreateCompanyDetailsMapping()
        {
            CreateMap<Company, CompanyBasicInformationDto>().ReverseMap();
            CreateMap<CompanyDetails, CompanyExtendedInformationDto>().ReverseMap();
        }

        private void CreateCompanyJobOfferMapping()
        {
            CreateMap<Company, CompanyForCompanyJobOfferListDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, ProgrammingLanguageForCompanyJobOfferListDto>().ReverseMap();
            CreateMap<JobOffer, JobOfferForCompanyJobOfferDto>()
                .ForMember(j => j.ExperienceLevel, opt => opt.MapFrom(x => x.ExperienceLevel.ToString()))
                .ReverseMap();
        }
    }
}
