using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFindJob.Application.Features.ProgrammingLanguages.Queries.FindByName
{
    public class GetProgrammingLanguageByNameQuery : IRequest<ProgrammingLanguagesVm>
    {
        public string ProgrammingLangaugeName { get; set; }
    }
}
