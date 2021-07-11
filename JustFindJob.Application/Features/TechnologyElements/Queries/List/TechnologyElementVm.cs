using JustFindJob.Domain.Entities;

namespace JustFindJob.Application.Features.TechnologyElements.Queries.List
{
    public class TechnologyElementVm
    {
        public TechnologyElementForTechnologyElementListDto TechnologyElementDto { get; set; }
        public ProgrammingLanguageForTechnologyElementListDto ProgrammingLanguageDto { get; set; }
    }
}