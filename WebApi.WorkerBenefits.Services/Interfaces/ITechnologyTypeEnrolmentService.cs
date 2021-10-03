using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface ITechnologyTypeEnrolmentService
    {
        List<TechnologyTypeEnrolmentDTO> GetAllTechnologyTypeEnrolments();
        TechnologyTypeEnrolmentDTO GetTechnologyTypeEnrolmentById(int id);
        int AddNewTechnologyTypeEnrolment(TechnologyTypeEnrolmentDTO entity);
        void UpdateTechnologyTypeEnrolment(TechnologyTypeEnrolmentDTO entity);
        void DeleteTechnologyTypeEnrolmentById(int id);
    }
}
