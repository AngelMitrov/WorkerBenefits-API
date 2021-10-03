using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface ITechnologyTypeService
    {
        List<TechnologyTypeDTO> GetAllTechnologyTypes();
        TechnologyTypeDTO GetTechnologyTypeById(int id);
        int AddNewTechnologyType(TechnologyTypeDTO entity);
        void UpdateTechnologyType(TechnologyTypeDTO entity);
        void DeleteTechnologyTypeById(int id);
    }
}
