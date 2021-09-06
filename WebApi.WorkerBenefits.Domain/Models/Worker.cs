namespace WebApi.WorkerBenefits.Domain.Models
{
    public class Worker : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int JobPositionId { get; set; }
        public JobPosition JobPosition { get; set; }
        public int TechnologyTypeId { get; set; }
        public TechnologyType TechnologyType { get; set; }
    }
}
