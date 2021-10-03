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
    public class TechnologyTypeService : ITechnologyTypeService
    {
        private IRepository<TechnologyType> _technologyTypeRepository;

        public TechnologyTypeService(IRepository<TechnologyType> technologyTypeRepository)
        {
            _technologyTypeRepository = technologyTypeRepository;
        }

        public int AddNewTechnologyType(TechnologyTypeDTO entity)
        {
            _technologyTypeRepository.Insert(entity.MapFromModelToDTO<TechnologyTypeDTO, TechnologyType>());
            return entity.Id;
        }

        public void DeleteTechnologyTypeById(int id)
        {
            _technologyTypeRepository.DeleteById(id);
        }

        public List<TechnologyTypeDTO> GetAllTechnologyTypes()
        {
            List<TechnologyType> techTypes = _technologyTypeRepository.GetAll();
            List<TechnologyTypeDTO> techTypesDto = new List<TechnologyTypeDTO>();
            foreach (TechnologyType techType in techTypes)
            {
                techTypesDto.Add(techType.MapFromModelToDTO<TechnologyType, TechnologyTypeDTO>());
            }
            return techTypesDto; 
        }

        public TechnologyTypeDTO GetTechnologyTypeById(int id)
        {
            return _technologyTypeRepository.GetById(id).MapFromModelToDTO<TechnologyType, TechnologyTypeDTO>();
        }

        public void UpdateTechnologyType(TechnologyTypeDTO entity)
        {
            _technologyTypeRepository.Update(entity.MapFromModelToDTO<TechnologyTypeDTO,TechnologyType>());
        }
    }
}
