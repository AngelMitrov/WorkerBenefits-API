using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects;

namespace WebApi.WorkerBenefits.Services
{
    public interface IJobPositionService
    {
        List<JobPositionDTO> GetAllJobPositions();
        JobPositionDTO GetJobPositionById(int id);
        int AddNewJobPosition(JobPositionDTO entity);
        void UpdateJobPosition(JobPositionDTO entity);
        void DeleteJobPositionById(int id);
    }
}
