using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.JobOffers.Queries.List
{
    public class JobOfferListVm
    {
        public ICollection<JobOfferListDto> JobOfferListDtos { get; set; }
    }
}
