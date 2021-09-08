using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services
{
    public interface IJobPositionService
    {
        public List<JobPosition> GetAllJobPositions();
        public JobPosition GetJobPositionById(int id);
        public int AddNewJobPosition(JobPosition entity);
        public void UpdateJobPosition(JobPosition entity);
        public void DeleteJobPositionById(int id);

    }
}
