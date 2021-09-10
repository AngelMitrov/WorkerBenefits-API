using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface ITechnologyTypeEnrolmentService
    {
        List<TechnologyTypeEnrolment> GetAllTechnologyTypeEnrolments();
        TechnologyTypeEnrolment GetTechnologyTypeEnrolmentById(int id);
        int AddNewTechnologyTypeEnrolment(TechnologyTypeEnrolment entity);
        void UpdateTechnologyTypeEnrolment(TechnologyTypeEnrolment entity);
        void DeleteTechnologyTypeEnrolmentById(int id);
    }
}
