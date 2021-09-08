using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Services
{
    public class IndividualEnrolmentService : IIndividualEnrolmentService
    {
        public IRepository<IndividualEnrolment> _individualEnrolmentRepository;
        public IndividualEnrolmentService(IRepository<IndividualEnrolment> individualEnrolmentRepository)
        {
            _individualEnrolmentRepository = individualEnrolmentRepository;
        }
        public int AddNewIndividualEnrolment(IndividualEnrolment entity)
        {
            _individualEnrolmentRepository.Insert(entity);
            return entity.Id;
        }

        public void DeleteIndividualEnrolmentById(int id)
        {
            _individualEnrolmentRepository.DeleteById(id);
        }

        public List<IndividualEnrolment> GetAllIndividualEnrolments()
        {
            return _individualEnrolmentRepository.GetAll();
        }

        public IndividualEnrolment GetIndividualEnrolmentById(int id)
        {
            return _individualEnrolmentRepository.GetById(id);
        }

        public void UpdateIndividualEnrolment(IndividualEnrolment entity)
        {
            _individualEnrolmentRepository.Update(entity);
        }
    }
}
