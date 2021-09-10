using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class JobPositionEntityRepository : IRepository<JobPosition>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbContext;

        public JobPositionEntityRepository(WorkerBenefitsDbContext workerBenefitsDbConctext)
        {
            _workerBenefitsDbContext = workerBenefitsDbConctext;
        }

        public void DeleteById(int id)
        {
            JobPosition jobPosition = _workerBenefitsDbContext.JobPositions.FirstOrDefault(x => x.Id.Equals(id));
            if(jobPosition == null)
            {
                throw new Exception($"Job position with ID: {id} not found!");
            }
            _workerBenefitsDbContext.JobPositions.Remove(jobPosition);
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<JobPosition> GetAll()
        {
            List<JobPosition> jobPositions = _workerBenefitsDbContext.JobPositions.ToList();
            if (jobPositions.Count() == 0)
            {
                throw new Exception($"You dont have any available job positions!");
            }
            return jobPositions;
        }

        public JobPosition GetById(int id)
        {
            JobPosition jobPosition = _workerBenefitsDbContext.JobPositions.FirstOrDefault(x => x.Id.Equals(id));

            if (jobPosition == null)
            {
                throw new Exception($"A job position with ID: {id} does not exist!");
            }
            return jobPosition;
        }

        public int Insert(JobPosition entity)
        {
            _workerBenefitsDbContext.JobPositions.Add(entity);
            _workerBenefitsDbContext.SaveChanges();
            return entity.Id;
        }

        public void Update(JobPosition entity)
        {
            JobPosition jobPos = _workerBenefitsDbContext.JobPositions.FirstOrDefault(x => x.Id.Equals(entity.Id));
            if(jobPos == null)
            {
                throw new Exception($"Job position with ID: {entity.Id} not found!");
            }
            jobPos.Name = entity.Name;
            jobPos.CreatedOn = entity.CreatedOn;
            jobPos.UpdatedOn = DateTime.UtcNow;

            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
