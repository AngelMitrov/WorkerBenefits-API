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
            if(worker != null)
            {
                _workerBenefitsDbContext.Workers.Remove(worker);
            }
        }

        public List<Worker> GetAll()
        {
            return _workerBenefitsDbContext.Workers.ToList();
        }

        public Worker GetById(int id)
        {
            return _workerBenefitsDbContext.Workers.FirstOrDefault(x => x.Id.Equals(id));
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
            if(worker != null)
            {
                worker.Firstname = entity.Firstname;
                worker.Lastname = entity.Lastname;
                worker.JobPosition = entity.JobPosition;
                worker.JobPositionId = entity.JobPositionId;
                worker.TechnologyType = entity.TechnologyType;
                worker.TechnologyTypeId = entity.TechnologyTypeId;
                worker.CreatedOn = entity.CreatedOn;
                worker.UpdatedOn = DateTime.UtcNow;
            }
            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
