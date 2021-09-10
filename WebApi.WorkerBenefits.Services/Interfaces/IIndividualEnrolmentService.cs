using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface IIndividualEnrolmentService
    {
        List<IndividualEnrolment> GetAllIndividualEnrolments();
        IndividualEnrolment GetIndividualEnrolmentById(int id);
        int AddNewIndividualEnrolment(IndividualEnrolment entity);
        void UpdateIndividualEnrolment(IndividualEnrolment entity);
        void DeleteIndividualEnrolmentById(int id);
    }
}
