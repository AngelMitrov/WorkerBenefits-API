using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface ITechnologyTypeEnrolmentService
    {
        public List<TechnologyTypeEnrolment> GetAllTechnologyTypeEnrolments();
        public TechnologyTypeEnrolment GetTechnologyTypeEnrolmentById(int id);
        public int AddNewTechnologyTypeEnrolment(TechnologyTypeEnrolment entity);
        public void UpdateTechnologyTypeEnrolment(TechnologyTypeEnrolment entity);
        public void DeleteTechnologyTypeEnrolmentById(int id);
    }
}
