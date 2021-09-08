using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services
{
    public interface IBenefitService
    {
        public List<Benefit> GetAllBenefits();
        public Benefit GetBenefitById(int id);
        public int AddNewBenefit(Benefit entity);
        public void UpdateBenefit(Benefit entity);
        public void DeleteBenefitById(int id);
    }
}
