using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.WorkerBenefits.DataTransferObjects

{
    public class BenefitsForWorkerDTO
    {
        public int WorkerId { get; set; }
        public WorkerDTO Worker { get; set; }
        public List<BenefitDTO> Benefits { get; set; }
    }
}

