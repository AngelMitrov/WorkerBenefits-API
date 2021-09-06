namespace WebApi.WorkerBenefits.Domain.Models
{
    public class JobPositionEnrolment : Enrolment
    {
        public int JobPositionId { get; set; }
        public JobPosition JobPosition { get; set; }
    }
}
