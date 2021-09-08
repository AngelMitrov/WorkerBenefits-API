using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Services
{
    public class TechnologyTypeService : ITechnologyTypeService
    {
        private IRepository<TechnologyType> _technologyTypeRepository;

        public TechnologyTypeService(IRepository<TechnologyType> technologyTypeRepository)
        {
            _technologyTypeRepository = technologyTypeRepository;
        }

        public int AddNewTechnologyType(TechnologyType entity)
        {
            _technologyTypeRepository.Insert(entity);
            return entity.Id;
        }

        public void DeleteTechnologyTypeById(int id)
        {
            _technologyTypeRepository.DeleteById(id);
        }

        public List<TechnologyType> GetAllTechnologyTypes()
        {
            return _technologyTypeRepository.GetAll();
        }

        public TechnologyType GetTechnologyTypeById(int id)
        {
            return _technologyTypeRepository.GetById(id);
        }

        public void UpdateTechnologyType(TechnologyType entity)
        {
            _technologyTypeRepository.Update(entity);
        }
    }
}
