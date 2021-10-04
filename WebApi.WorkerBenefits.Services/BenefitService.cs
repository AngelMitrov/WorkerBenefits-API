using System.Collections.Generic;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Mappers;

namespace WebApi.WorkerBenefits.Services
{
    public class BenefitService : IBenefitService
    {

        private IRepository<Benefit> _benefitRepository;

        public BenefitService(IRepository<Benefit> benefitRepository)
        {
            _benefitRepository = benefitRepository;
        }

        public int AddNewBenefit(BenefitDTO entity)
        {
            _benefitRepository.Insert(entity.ToDomain());
            return entity.Id;
        }

        public void DeleteBenefitById(int id)
        {
            _benefitRepository.DeleteById(id);
        }

        public List<BenefitDTO> GetAllBenefits()
        {
            List<BenefitDTO> benefitDtos = new List<BenefitDTO>();
            List<Benefit> benefitDomain = _benefitRepository.GetAll();
            foreach (Benefit benefit in benefitDomain)
            {
                benefitDtos.Add(benefit.ToDto());
            }
            return benefitDtos;
        }

        public BenefitDTO GetBenefitById(int id)
        {
            return _benefitRepository.GetById(id).ToDto();
        }

        public void UpdateBenefit(BenefitDTO entity)
        {
            _benefitRepository.Update(entity.ToDomain());
        }
    }
}