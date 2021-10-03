using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects;

namespace WebApi.WorkerBenefits.Services
{
    public interface IBenefitService
    {
        List<BenefitDTO> GetAllBenefits();
        BenefitDTO GetBenefitById(int id);
        int AddNewBenefit(BenefitDTO entity);
        void UpdateBenefit(BenefitDTO entity);
        void DeleteBenefitById(int id);
    }
}
