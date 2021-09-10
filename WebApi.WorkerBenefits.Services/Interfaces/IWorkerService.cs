using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface IWorkerService
    {
        List<Worker> GetAllWorkers();
        Worker GetWorkerById(int id);
        int AddNewWorker(Worker entity);
        void UpdateWorker(Worker entity);
        void DeleteWorkerById(int id);
    }
}
