using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Mappers;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Services
{
    public class IndividualEnrolmentService : IIndividualEnrolmentService
    {
        private IRepository<IndividualEnrolment> _individualEnrolmentRepository;
        public IndividualEnrolmentService(IRepository<IndividualEnrolment> individualEnrolmentRepository)
        {
            _individualEnrolmentRepository = individualEnrolmentRepository;
        }
        public int AddNewIndividualEnrolment(IndividualEnrolmentDTO entity)
        {
            _individualEnrolmentRepository.Insert(entity.ToDomain());

            return entity.Id;
        }

        public void DeleteIndividualEnrolmentById(int id)
        {
            _individualEnrolmentRepository.DeleteById(id);
        }

        public List<IndividualEnrolmentDTO> GetAllIndividualEnrolments()
        {
            List<IndividualEnrolmentDTO> indEnrolmentDtos = new List<IndividualEnrolmentDTO>();
            List<IndividualEnrolment> indEnrolments = _individualEnrolmentRepository.GetAll();

            foreach (IndividualEnrolment indEnrolment in indEnrolments)
            {
                indEnrolmentDtos.Add(indEnrolment.ToDto());
            }
            return indEnrolmentDtos;

        }

        public IndividualEnrolmentDTO GetIndividualEnrolmentById(int id)
        {
            return _individualEnrolmentRepository.GetById(id).ToDto();
        }

        public void UpdateIndividualEnrolment(IndividualEnrolmentDTO entity)
        {
            _individualEnrolmentRepository.Update(entity.ToDomain());
        }
    }
}
