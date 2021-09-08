using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Services
{
    public class JobPositionEnrolmentService : IJobPositionEnrolmentService
    {
        private IRepository<JobPositionEnrolment> _jobPositionEnrolmentRepository;

        public JobPositionEnrolmentService(IRepository<JobPositionEnrolment> jobPositionEnrolmentRepository)
        {
            _jobPositionEnrolmentRepository = jobPositionEnrolmentRepository;
        }

        public int AddNewJobPositionEnrolment(JobPositionEnrolment entity)
        {
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
