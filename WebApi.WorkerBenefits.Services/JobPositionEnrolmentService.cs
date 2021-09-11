using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Services
{
    public class JobPositionEnrolmentService : IJobPositionEnrolmentService
    {
        private IRepository<JobPositionEnrolment> _jobPositionEnrolmentRepository;
        private IRepository<JobPosition> _jobPositionRepository;

        public JobPositionEnrolmentService(IRepository<JobPositionEnrolment> jobPositionEnrolmentRepository, IRepository<JobPosition> jobPositionRepository)
        {
            _jobPositionEnrolmentRepository = jobPositionEnrolmentRepository;
            _jobPositionRepository = jobPositionRepository;
        }

        public int AddNewJobPositionEnrolment(JobPositionEnrolment entity)
        {
            JobPosition jobPos = _jobPositionRepository.GetAll().FirstOrDefault(x => x.Id.Equals(entity.JobPositionId));
            entity.JobPosition = jobPos;
            _jobPositionEnrolmentRepository.Insert(entity);
            return entity.Id;
        }

        public void DeleteJobPositionEnrolmentById(int id)
        {
            _jobPositionEnrolmentRepository.DeleteById(id);
        }

        public List<JobPositionEnrolment> GetAllJobPositionEnrolments()
        {
            return _jobPositionEnrolmentRepository.GetAll();
        }

        public JobPositionEnrolment GetJobPositionEnrolmentById(int id)
        {
            return _jobPositionEnrolmentRepository.GetById(id);
        }

        public void UpdateJobPositionEnrolment(JobPositionEnrolment entity)
        {
            _jobPositionEnrolmentRepository.Update(entity);
        }
    }
}
