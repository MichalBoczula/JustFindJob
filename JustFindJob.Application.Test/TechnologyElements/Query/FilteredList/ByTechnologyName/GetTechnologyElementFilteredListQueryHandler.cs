using AutoMapper;
using JustFindJob.Persistance;

namespace JustFindJob.Application.Test.TechnologyElements.Query.FilteredList.ByTechnologyName
{
    internal class GetTechnologyElementFilteredListQueryHandler
    {
        private JustFindJobDbContext context;
        private IMapper mapper;

        public GetTechnologyElementFilteredListQueryHandler(JustFindJobDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
    }
}