using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Mappers;

namespace WebApi.WorkerBenefits.Services
{
    public class JobPositionService : IJobPositionService
    {
        private IRepository<JobPosition> _jobPositionRepository;

        public JobPositionService(IRepository<JobPosition> jobPositionRepository)
        {
            _jobPositionRepository = jobPositionRepository;
        }

        public int AddNewJobPosition(JobPositionDTO entity)
        {
            _jobPositionRepository.Insert(entity.MapFromModelToDTO<JobPositionDTO, JobPosition>());
            return entity.Id;
        }

        public void DeleteJobPositionById(int id)
        {
            _jobPositionRepository.DeleteById(id);
        }

        public List<JobPositionDTO> GetAllJobPositions()
        {
            List<JobPosition> jobPositions = _jobPositionRepository.GetAll();
            List<JobPositionDTO> jobPositionDtos = new List<JobPositionDTO>();
            foreach (JobPosition jobPosition in jobPositions)
            {
                jobPositionDtos.Add(jobPosition.MapFromModelToDTO<JobPosition, JobPositionDTO>());
            }
            return jobPositionDtos;
        }

        public JobPositionDTO GetJobPositionById(int id)
        {
            return _jobPositionRepository.GetById(id).MapFromModelToDTO<JobPosition, JobPositionDTO>();
        }


        public void UpdateJobPosition(JobPositionDTO entity)
        {
            _jobPositionRepository.Update(entity.MapFromModelToDTO<JobPositionDTO, JobPosition>());
        }
    }
}
