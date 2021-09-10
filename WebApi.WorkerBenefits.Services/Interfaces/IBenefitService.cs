using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services
{
    public interface IBenefitService
    {
        List<Benefit> GetAllBenefits();
        Benefit GetBenefitById(int id);
        int AddNewBenefit(Benefit entity);
        void UpdateBenefit(Benefit entity);
        void DeleteBenefitById(int id);
    }
}
