using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class WorkerEntityRepository : IWorkerEntityRepository
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
            List<Worker> workers = _workerBenefitsDbContext.Workers.Include(x => x.JobPosition).Include(x => x.TechnologyType).ToList();
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
            worker.Age = entity.Age;
            worker.JobPosition = entity.JobPosition;
            worker.JobPositionId = entity.JobPositionId;
            worker.TechnologyType = entity.TechnologyType;
            worker.TechnologyTypeId = entity.TechnologyTypeId;
            worker.CreatedOn = entity.CreatedOn;
            worker.UpdatedOn = DateTime.UtcNow;

            _workerBenefitsDbContext.SaveChanges();
        }
        public BenefitsForWorkerDTO GetAllBenefitsForWorkerById(int id)
        {
            Worker worker = _workerBenefitsDbContext.Workers
                                                    .Include(q => q.JobPosition)
                                                    .Include(q => q.TechnologyType)
                                                    .FirstOrDefault(x => x.Id.Equals(id));

            Benefit jobPositionBenefit = _workerBenefitsDbContext.JobPositionEnrolments
                                                                 .Include(x => x.Benefit)
                                                                 .Include(x => x.JobPosition)
                                                                 .FirstOrDefault(x => x.JobPositionId.Equals(worker.JobPositionId))
                                                                 .Benefit;

            Benefit technologyTypeBenefit = _workerBenefitsDbContext.TechnologyTypeEnrolments
                                                                    .Include(x => x.Benefit)
                                                                    .Include(x => x.TechnologyType)
                                                                    .FirstOrDefault(x => x.TechnologyTypeId.Equals(worker.TechnologyTypeId))
                                                                    .Benefit;

            Benefit individualBenefit = _workerBenefitsDbContext.IndividualEnrolments
                                                                .Include(x => x.Worker)
                                                                .FirstOrDefault(x => x.WorkerId.Equals(worker.Id))
                                                                .Benefit;
            List<Benefit> benefits = new List<Benefit>() { jobPositionBenefit, technologyTypeBenefit, individualBenefit };

            BenefitsForWorkerDTO workerBenefits = new BenefitsForWorkerDTO()
            {
                WorkerId = worker.Id,
                Worker = worker,
                Benefits = benefits,
            };

            return workerBenefits;
        }
    }
}
