using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.WorkerBenefits.Domain.Enums;

namespace WebApi.WorkerBenefits.Domain.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public int EnrolmentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }
        public WorkerPosition Position { get; set; }
    }

}
