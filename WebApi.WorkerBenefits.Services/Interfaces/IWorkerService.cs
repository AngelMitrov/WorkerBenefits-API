using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Services.Interfaces
{
    public interface IWorkerService
    {
        public List<Worker> GetAllWorkers();
        public Worker GetWorkerById(int id);
        public int AddNewWorker(Worker entity);
        public void UpdateWorker(Worker entity);
        public void DeleteWorkerById(int id);
    }
}
