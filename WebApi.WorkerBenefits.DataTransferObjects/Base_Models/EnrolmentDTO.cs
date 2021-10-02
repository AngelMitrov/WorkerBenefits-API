using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.WorkerBenefits.DataTransferObjects.Base_Models
{
    public class EnrolmentDTO : BaseEntityDTO
    {
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
        public int BenefitId { get; set; }
        public Benefit Benefit { get; set; }
    }
}
