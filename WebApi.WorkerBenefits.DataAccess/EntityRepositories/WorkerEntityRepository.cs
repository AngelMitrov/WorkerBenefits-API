using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class WorkerEntityRepository : IRepository<Worker>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbContext;

        public WorkerEntityRepository(WorkerBenefitsDbContext workerBenefitsDbContext)
        {
            _workerBenefitsDbContext = workerBenefitsDbContext;
        }

        public void DeleteById(int id)
        {
            Worker worker = _workerBenefitsDbContext.Workers.FirstOrDefault(x => x.Id.Equals(id));
            if(worker == null)
            {
                throw new Exception($"Worker with ID: {id} not found!");
            }
            _workerBenefitsDbContext.Workers.Remove(worker);
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<Worker> GetAll()
        {
            List<Worker> workers = _workerBenefitsDbContext.Workers.ToList();
            if (workers.Count() == 0)
            {
                throw new Exception($"You dont have any available workers!");
            }
            return workers;
        }

        public Worker GetById(int id)
        {
            Worker worker = _workerBenefitsDbContext.Workers.FirstOrDefault(x => x.Id.Equals(id));

            if (worker == null)
            {
                throw new Exception($"A worker with ID: {id} does not exist!");
            }
            return worker;
        }

        public int Insert(Worker entity)
        {
            _workerBenefitsDbContext.Workers.Add(entity);
            _workerBenefitsDbContext.SaveChanges();
            return entity.Id;
        }

        public void Update(Worker entity)
        {
            Worker worker = _workerBenefitsDbContext.Workers.FirstOrDefault(x => x.Id.Equals(entity.Id));
            if(worker == null)
            {
                throw new Exception($"Worker with ID: {entity.Id} not found!");
            }
            worker.Firstname = entity.Firstname;
            worker.Lastname = entity.Lastname;
            worker.JobPosition = entity.JobPosition;
            worker.JobPositionId = entity.JobPositionId;
            worker.TechnologyType = entity.TechnologyType;
            worker.TechnologyTypeId = entity.TechnologyTypeId;
            worker.CreatedOn = entity.CreatedOn;
            worker.UpdatedOn = DateTime.UtcNow;

            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
