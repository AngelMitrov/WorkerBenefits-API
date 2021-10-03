using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects.Base_Models;

namespace WebApi.WorkerBenefits.DataTransferObjects
{
    public class TechnologyTypeEnrolmentDTO : EnrolmentDTO
    {
        public int TechnologyTypeId { get; set; }
        public TechnologyTypeDTO TechnologyType { get; set; }
    }
}
