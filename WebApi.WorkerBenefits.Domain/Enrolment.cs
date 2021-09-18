using System;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Domain
{
    public class Enrolment : BaseEntity
    {
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
        public int BenefitId { get; set; }
        public Benefit Benefit { get; set; }
    }
}
