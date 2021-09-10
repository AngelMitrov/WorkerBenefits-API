using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services
{
    public interface IJobPositionService
    {
        List<JobPosition> GetAllJobPositions();
        JobPosition GetJobPositionById(int id);
        int AddNewJobPosition(JobPosition entity);
        void UpdateJobPosition(JobPosition entity);
        void DeleteJobPositionById(int id);
    }
}
