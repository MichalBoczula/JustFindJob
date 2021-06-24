using JustFindJob.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.JobOffers.Queries.List
{
    public class JobOfferDtoForJobOfferList
    {
        public int Id { get; set; }
        public string Localization { get; set; }
        public string ExperienceLevel { get; set; }
        public string ShortDescription { get; set; }
    }
}
