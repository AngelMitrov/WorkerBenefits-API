using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface IJobPositionEnrolmentService
    {
        public List<JobPositionEnrolment> GetAllJobPositionEnrolments();
        public JobPositionEnrolment GetJobPositionEnrolmentById(int id);
        public int AddNewJobPositionEnrolment(JobPositionEnrolment entity);
        public void UpdateJobPositionEnrolment(JobPositionEnrolment entity);
        public void DeleteJobPositionEnrolmentById(int id);
    }
}
