using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface IJobPositionEnrolmentService
    {
        List<JobPositionEnrolmentDTO> GetAllJobPositionEnrolments();
        JobPositionEnrolmentDTO GetJobPositionEnrolmentById(int id);
        int AddNewJobPositionEnrolment(JobPositionEnrolmentDTO entity);
        void UpdateJobPositionEnrolment(JobPositionEnrolmentDTO entity);
        void DeleteJobPositionEnrolmentById(int id);
    }
}