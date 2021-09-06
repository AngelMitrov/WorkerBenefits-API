namespace WebApi.WorkerBenefits.Domain.Models
{
    public class IndivudualEnrolment : Enrolment
    {
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
