using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services
{
    public class JobPositionService : IJobPositionService
    {
        private IRepository<JobPosition> _jobPositionRepository;

        public JobPositionService(IRepository<JobPosition> jobPositionRepository)
        {
            _jobPositionRepository = jobPositionRepository;
        }

        public int AddNewJobPosition(JobPosition entity)
        {
            _jobPositionRepository.Insert(entity);
            return entity.Id;
        }

        public void DeleteJobPositionById(int id)
        {
            _jobPositionRepository.DeleteById(id);
        }

        public List<JobPosition> GetAllJobPositions()
        {
            return _jobPositionRepository.GetAll();
        }

        public JobPosition GetJobPositionById(int id)
        {
            return _jobPositionRepository.GetById(id);
        }

        public void UpdateJobPosition(JobPosition entity)
        {
            _jobPositionRepository.Update(entity);
        }
    }
}
