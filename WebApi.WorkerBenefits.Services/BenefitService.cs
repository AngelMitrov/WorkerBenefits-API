using System.Collections.Generic;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services
{
    public class BenefitService : IBenefitService
    {

        private IRepository<Benefit> _benefitRepository;

        public BenefitService(IRepository<Benefit> benefitRepository)
        {
            _benefitRepository = benefitRepository;
        }

        public int AddNewBenefit(Benefit entity)
        {
            _benefitRepository.Insert(entity);
            return entity.Id;
        }

        public void DeleteBenefitById(int id)
        {
            _benefitRepository.DeleteById(id);
        }

        public List<Benefit> GetAllBenefits()
        {
            return _benefitRepository.GetAll();
        }

        public Benefit GetBenefitById(int id)
        {
            return _benefitRepository.GetById(id);
        }

        public void UpdateBenefit(Benefit entity)
        {
            _benefitRepository.Update(entity);
        }
    }
}