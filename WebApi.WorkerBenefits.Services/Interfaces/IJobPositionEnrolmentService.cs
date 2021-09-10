using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface IJobPositionEnrolmentService
    {
        List<JobPositionEnrolment> GetAllJobPositionEnrolments();
        JobPositionEnrolment GetJobPositionEnrolmentById(int id);
        int AddNewJobPositionEnrolment(JobPositionEnrolment entity);
        void UpdateJobPositionEnrolment(JobPositionEnrolment entity);
        void DeleteJobPositionEnrolmentById(int id);
    }
}