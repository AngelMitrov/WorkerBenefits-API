using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataTransferModels
{
    public class BenefitsForWorker
    {
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public List<Benefit> Benefits { get; set; }
    }
}
