using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.WorkerBenefits.Domain.Enums;

namespace WebApi.WorkerBenefits.Domain.Models
{
    public class Enrolment
    {
        public Enrolment()
        {
            if (DevelopingTechnologies.Count() < 4)
            {
                EnrolledPosition = WorkerPosition.Intern;
            }
            else if (DevelopingTechnologies.Count() > 4 && DevelopingTechnologies.Count() < 7)
            {
                EnrolledPosition = WorkerPosition.Junior;
            }
            else
            {
                EnrolledPosition = WorkerPosition.Senior;
            }
        }
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }
        public DateTime EnrolledDateAndTime { get; set; }
        public List<Technologies> DevelopingTechnologies { get; set; }
        private WorkerPosition EnrolledPosition { get; set; } 
    }
}
