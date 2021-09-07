namespace WebApi.WorkerBenefits.Domain.Models
{
    public class IndividualEnrolment : Enrolment
    {
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
