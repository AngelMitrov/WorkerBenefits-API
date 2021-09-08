using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface IIndividualEnrolmentService
    {
        public List<IndividualEnrolment> GetAllIndividualEnrolments();
        public IndividualEnrolment GetIndividualEnrolmentById(int id);
        public int AddNewIndividualEnrolment(IndividualEnrolment entity);
        public void UpdateIndividualEnrolment(IndividualEnrolment entity);
        public void DeleteIndividualEnrolmentById(int id);
    }
}
