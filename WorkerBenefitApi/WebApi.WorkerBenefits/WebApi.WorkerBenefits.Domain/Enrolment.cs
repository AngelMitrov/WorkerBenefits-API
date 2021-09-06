using System;

namespace WebApi.WorkerBenefits.Domain
{
    public class Enrolment : BaseEntity
    {
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
    }
}
