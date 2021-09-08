using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Services
{
    public class TechnologyTypeEnrolmentService : ITechnologyTypeEnrolmentService
    {
        private IRepository<TechnologyTypeEnrolment> _technologyTypeEnrolmentRepository;

        public TechnologyTypeEnrolmentService(IRepository<TechnologyTypeEnrolment> technologyTypeEnrolmentRepository)
        {
            _technologyTypeEnrolmentRepository = technologyTypeEnrolmentRepository;
        }

        public int AddNewTechnologyTypeEnrolment(TechnologyTypeEnrolment entity)
        {
            _technologyTypeEnrolmentRepository.Insert(entity);
            return entity.Id;
        }

        public void DeleteTechnologyTypeEnrolmentById(int id)
        {
            _technologyTypeEnrolmentRepository.DeleteById(id);
        }

        public List<TechnologyTypeEnrolment> GetAllTechnologyTypeEnrolments()
        {
            return _technologyTypeEnrolmentRepository.GetAll();
        }

        public TechnologyTypeEnrolment GetTechnologyTypeEnrolmentById(int id)
        {
            return _technologyTypeEnrolmentRepository.GetById(id);
        }

        public void UpdateTechnologyTypeEnrolment(TechnologyTypeEnrolment entity)
        {
            _technologyTypeEnrolmentRepository.Update(entity);
        }
    }
}
