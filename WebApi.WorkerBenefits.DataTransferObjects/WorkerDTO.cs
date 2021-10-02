using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects.Base_Models;

namespace WebApi.WorkerBenefits.DataTransferObjects
{
    public class WorkerDTO : BaseEntityDTO
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public int JobPositionId { get; set; }
        public JobPositionDTO JobPosition { get; set; }
        public int? TechnologyTypeId { get; set; }
        public TechnologyTypeDTO TechnologyType { get; set; }
    }
}
