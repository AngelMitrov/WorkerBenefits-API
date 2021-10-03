using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects.Base_Models;

namespace WebApi.WorkerBenefits.DataTransferObjects
{
    public class JobPositionEnrolmentDTO : EnrolmentDTO
    {
        public int JobPositionId { get; set; }
        public JobPositionDTO JobPosition { get; set; }
    }
}
