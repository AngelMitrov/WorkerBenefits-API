using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services.Interfaces;
using WebApi.WorkerBenefits.Mappers;
using WebApi.WorkerBenefits.DataTransferObjects;

namespace WebApi.WorkerBenefits.Services
{
    public class TechnologyTypeEnrolmentService : ITechnologyTypeEnrolmentService
    {
        private IRepository<TechnologyTypeEnrolment> _technologyTypeEnrolmentRepository;

        public TechnologyTypeEnrolmentService(IRepository<TechnologyTypeEnrolment> technologyTypeEnrolmentRepository)
        {
            _technologyTypeEnrolmentRepository = technologyTypeEnrolmentRepository;
        }

        public int AddNewTechnologyTypeEnrolment(TechnologyTypeEnrolmentDTO entity)
        {
            _technologyTypeEnrolmentRepository.Insert(entity.ToDomain());
            return entity.Id;
        }

        public void DeleteTechnologyTypeEnrolmentById(int id)
        {
            _technologyTypeEnrolmentRepository.DeleteById(id);
        }

        public List<TechnologyTypeEnrolmentDTO> GetAllTechnologyTypeEnrolments()
        {
            List<TechnologyTypeEnrolment> techTypeEnrolments = _technologyTypeEnrolmentRepository.GetAll();
            List<TechnologyTypeEnrolmentDTO> techTypeEnrolmentsDto = new List<TechnologyTypeEnrolmentDTO>();

            foreach (TechnologyTypeEnrolment techTypeEnrolment in techTypeEnrolments)
            {
                techTypeEnrolmentsDto.Add(techTypeEnrolment.ToDto());
            }

            return techTypeEnrolmentsDto;
        }

        public TechnologyTypeEnrolmentDTO GetTechnologyTypeEnrolmentById(int id)
        {
            return _technologyTypeEnrolmentRepository.GetById(id).ToDto();
        }

        public void UpdateTechnologyTypeEnrolment(TechnologyTypeEnrolmentDTO entity)
        {
            _technologyTypeEnrolmentRepository.Update(entity.ToDomain());
        }
    }
}
