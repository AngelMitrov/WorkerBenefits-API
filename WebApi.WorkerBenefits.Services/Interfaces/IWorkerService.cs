using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface IWorkerService
    {
        List<WorkerDTO> GetAllWorkers();
        WorkerDTO GetWorkerById(int id);
        int AddNewWorker(WorkerDTO entity);
        void UpdateWorker(WorkerDTO entity);
        void DeleteWorkerById(int id);
        string GetLoginToken(LoginDTO loginDto);
        BenefitsForWorkerDTO GetAllBenefitsForWorkerById(int id);
        BenefitsForWorkerDTO GetAllBenefitsForWorkerByIdNew(int id);
    }
}
