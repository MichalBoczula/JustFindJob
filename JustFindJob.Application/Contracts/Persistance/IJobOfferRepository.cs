using JustFindJob.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustFindJob.Application.Contracts.Persistance
{
    public interface IJobOfferRepository
    {
        Task<ICollection<JobOffer>> GetList(CancellationToken cancellationToken);
    }
}
