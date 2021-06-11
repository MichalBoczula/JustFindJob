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
            CreateMap<JobOffer, JobOfferListDto>().ReverseMap();
            CreateMap<JobOffer, JobOfferDetailsVm>().ReverseMap();
        }
    }
}
