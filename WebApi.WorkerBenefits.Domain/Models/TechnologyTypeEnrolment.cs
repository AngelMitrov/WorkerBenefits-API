namespace WebApi.WorkerBenefits.Domain.Models
{
    public class TechnologyTypeEnrolment : Enrolment
    {
        public int TechnologyTypeId { get; set; }
        public TechnologyType TechnologyType { get; set; }
    }
}
