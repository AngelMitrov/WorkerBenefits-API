using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataTransferObjects

{
    public class BenefitsForWorkerDTO
    {
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public List<Benefit> Benefits { get; set; }
    }
}

