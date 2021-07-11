using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.ProgrammingLanguages.Queries.List
{
    public class GetProgrammingLanguageListQuery : IRequest<List<ProgrammingLanguagesVm>>
    {
    }
}
