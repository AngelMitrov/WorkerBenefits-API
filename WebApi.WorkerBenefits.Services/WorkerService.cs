using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Services
{
    public class WorkerService : IWorkerService
    {
        private IRepository<Worker> _workerRepository;
        public WorkerService(IRepository<Worker> workerRepository)
        {
            _workerRepository = workerRepository;
        }
        public int AddNewWorker(Worker entity)
        {
            _workerRepository.Insert(entity);
            return entity.Id;
        }

        public void DeleteWorkerById(int id)
        {
            _workerRepository.DeleteById(id);
        }

        public List<Worker> GetAllWorkers()
        {
            return _workerRepository.GetAll();
        }

        public Worker GetWorkerById(int id)
        {
            return _workerRepository.GetById(id);
        }

        public void UpdateWorker(Worker entity)
        {
            _workerRepository.Update(entity);
        }
    }
}
