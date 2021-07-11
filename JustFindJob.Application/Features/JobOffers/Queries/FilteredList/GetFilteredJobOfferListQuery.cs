using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.JobOffers.Queries.FilteredList
{
    public class GetFilteredJobOfferListQuery : IRequest<List<FilteredJobOfferListVm>>
    {
        public ListFiltersJobOffer Filters{ get; set; }
    }
}
