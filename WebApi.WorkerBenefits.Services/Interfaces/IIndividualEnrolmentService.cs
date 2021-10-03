using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface IIndividualEnrolmentService
    {
        List<IndividualEnrolmentDTO> GetAllIndividualEnrolments();
        IndividualEnrolmentDTO GetIndividualEnrolmentById(int id);
        int AddNewIndividualEnrolment(IndividualEnrolmentDTO entity);
        void UpdateIndividualEnrolment(IndividualEnrolmentDTO entity);
        void DeleteIndividualEnrolmentById(int id);
    }
}
