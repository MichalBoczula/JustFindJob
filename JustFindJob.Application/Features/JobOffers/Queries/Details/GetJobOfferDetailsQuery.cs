using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.JobOffers.Queries.Details
{
    public class GetJobOfferDetailsQuery : IRequest<JobOfferDetailsVm>
    {
        public int JobOfferId { get; set; }
    }
}
