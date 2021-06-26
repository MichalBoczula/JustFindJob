using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Contracts.Identity
{
    public interface ICurrentUserService
    {
        string Email { get; set; }
        bool IsAuthenticated { get; set; }
    }
}
