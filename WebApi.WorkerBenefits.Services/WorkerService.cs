using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Mappers;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Services
{
    public class WorkerService : IWorkerService
    {
        private IWorkerEntityRepository _workerRepository;
        public WorkerService(IWorkerEntityRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }
        public int AddNewWorker(Worker entity)
        {
            entity.Password = entity.Password.GenerateMD5();
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

        public BenefitsForWorkerDTO GetAllBenefitsForWorkerById(int id)
        {
            return _workerRepository.GetAllBenefitsForWorkerById(id);
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
