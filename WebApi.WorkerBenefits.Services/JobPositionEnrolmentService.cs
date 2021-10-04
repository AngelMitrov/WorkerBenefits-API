using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services.Interfaces;
using WebApi.WorkerBenefits.Mappers;

namespace WebApi.WorkerBenefits.Services
{
    public class JobPositionEnrolmentService : IJobPositionEnrolmentService
    {
        private IRepository<JobPositionEnrolment> _jobPositionEnrolmentRepository;


        public JobPositionEnrolmentService(IRepository<JobPositionEnrolment> jobPositionEnrolmentRepository, IRepository<JobPosition> jobPositionRepository)
        {
            _jobPositionEnrolmentRepository = jobPositionEnrolmentRepository;
        }

        public int AddNewJobPositionEnrolment(JobPositionEnrolmentDTO entity)
        {
            _jobPositionEnrolmentRepository.Insert(entity.ToDomain());
            return entity.Id;
        }

        public void DeleteJobPositionEnrolmentById(int id)
        {
            _jobPositionEnrolmentRepository.DeleteById(id);
        }

        public List<JobPositionEnrolmentDTO> GetAllJobPositionEnrolments()
        {
            List<JobPositionEnrolment> jobPosEnrolments = _jobPositionEnrolmentRepository.GetAll();
            List<JobPositionEnrolmentDTO> jobPosEnrolmentsDto = new List<JobPositionEnrolmentDTO>();

            foreach (JobPositionEnrolment jobPositionEnrolment in jobPosEnrolments)
            {
                jobPosEnrolmentsDto.Add(jobPositionEnrolment.ToDto());
            }
            return jobPosEnrolmentsDto;
        }

        public JobPositionEnrolmentDTO GetJobPositionEnrolmentById(int id)
        {
            return _jobPositionEnrolmentRepository.GetById(id).ToDto();
        }

        public void UpdateJobPositionEnrolment(JobPositionEnrolmentDTO entity)
        {
            _jobPositionEnrolmentRepository.Update(entity.ToDomain());
        }
    }
}
