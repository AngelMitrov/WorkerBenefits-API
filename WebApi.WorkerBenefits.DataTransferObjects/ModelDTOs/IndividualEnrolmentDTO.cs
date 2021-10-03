using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects.Base_Models;

namespace WebApi.WorkerBenefits.DataTransferObjects
{
    public class IndividualEnrolmentDTO : EnrolmentDTO
    {
        public int WorkerId { get; set; }
        public WorkerDTO Worker { get; set; }
    }
}
