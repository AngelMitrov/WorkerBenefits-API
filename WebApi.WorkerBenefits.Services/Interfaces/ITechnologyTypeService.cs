using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface ITechnologyTypeService
    {
        List<TechnologyType> GetAllTechnologyTypes();
        TechnologyType GetTechnologyTypeById(int id);
        int AddNewTechnologyType(TechnologyType entity);
        void UpdateTechnologyType(TechnologyType entity);
        void DeleteTechnologyTypeById(int id);
    }
}
