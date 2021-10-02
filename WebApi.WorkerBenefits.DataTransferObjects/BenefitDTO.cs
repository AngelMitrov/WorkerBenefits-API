using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects.Base_Models;
using WebApi.WorkerBenefits.Domain.Enums;

namespace WebApi.WorkerBenefits.DataTransferObjects
{
    public class BenefitDTO : BaseEntityDTO
    {
        public string Name { get; set; }
        public int BenefitTypeId { get; set; }
        public BenefitType BenefitType { get; set; }
    }
}
