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
            if(jobPosition != null)
            {
                _workerBenefitsDbContext.JobPositions.Remove(jobPosition);
            }
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<JobPosition> GetAll()
        {
            return _workerBenefitsDbContext.JobPositions.ToList();
        }

        public JobPosition GetById(int id)
        {
            return _workerBenefitsDbContext.JobPositions.FirstOrDefault(x => x.Id.Equals(id));
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
            if(jobPos != null)
            {
                jobPos.Name = entity.Name;
                jobPos.CreatedOn = entity.CreatedOn;
                jobPos.UpdatedOn = DateTime.UtcNow;
            }
            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
