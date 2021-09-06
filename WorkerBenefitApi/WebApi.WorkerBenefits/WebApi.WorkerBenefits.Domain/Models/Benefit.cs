using WebApi.WorkerBenefits.Domain.Enums;

namespace WebApi.WorkerBenefits.Domain.Models
{
    public class Benefit : BaseEntity
    {
        public string Name { get; set; }
        public int BenefitTypeId { get; set; }
        public BenefitType BenefitType { get; set; }
    }
}
