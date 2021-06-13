using JustFindJob.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Contracts.Persistance
{
    public interface ICompanyRepository
    {
        Task<Company> GetByIdAsync(int Id);
    }
}
