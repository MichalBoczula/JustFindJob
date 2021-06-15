using JustFindJob.Domain.Common;

namespace JustFindJob.Domain.Entities
{
    public class CompanyDetails : AuditableEntity
    {
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string CompanyDescription { get; set; }
#nullable enable
        public string? CompanyInformation1 { get; set; }
        public string? CompanyInformation2 { get; set; }
        public string? CompanyInformation3 { get; set; }
        public string? CompanyImage1 { get; set; }
        public string? CompanyImage2 { get; set; }
        public string? CompanyImage3 { get; set; }
#nullable disable
    }
}