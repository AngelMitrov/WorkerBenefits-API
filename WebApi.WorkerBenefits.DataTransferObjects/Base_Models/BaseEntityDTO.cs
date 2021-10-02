using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.WorkerBenefits.DataTransferObjects.Base_Models
{
    public class BaseEntityDTO
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
