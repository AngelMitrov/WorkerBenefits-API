using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface ITechnologyTypeService
    {
        public List<TechnologyType> GetAllTechnologyTypes();
        public TechnologyType GetTechnologyTypeById(int id);
        public int AddNewTechnologyType(TechnologyType entity);
        public void UpdateTechnologyType(TechnologyType entity);
        public void DeleteTechnologyTypeById(int id);
    }
}
