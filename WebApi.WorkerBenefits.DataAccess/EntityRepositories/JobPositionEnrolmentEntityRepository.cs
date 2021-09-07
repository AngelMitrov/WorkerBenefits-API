using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class JobPositionEnrolmentEntityRepository : IRepository<JobPositionEnrolment>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbContext;

        public JobPositionEnrolmentEntityRepository(WorkerBenefitsDbContext workerBenefitsDbConctext)
        {
            _workerBenefitsDbContext = workerBenefitsDbConctext;
        }

        public void DeleteById(int id)
        {
            JobPositionEnrolment jobPositionEnrolment = _workerBenefitsDbContext.JobPositionEnrolments.FirstOrDefault(q => q.Id.Equals(id));
            if (jobPositionEnrolment != null)
            {
                _workerBenefitsDbContext.JobPositionEnrolments.Remove(jobPositionEnrolment);
            }
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<JobPositionEnrolment> GetAll()
        {
            return _workerBenefitsDbContext.JobPositionEnrolments.ToList();
        }

        public JobPositionEnrolment GetById(int id)
        {
            return _workerBenefitsDbContext.JobPositionEnrolments.FirstOrDefault(x => x.Id.Equals(id));
        }

        public int Insert(JobPositionEnrolment entity)
        {
            _workerBenefitsDbContext.JobPositionEnrolments.Add(entity);
            _workerBenefitsDbContext.SaveChanges();
            return entity.Id;
        }

        public void Update(JobPositionEnrolment entity)
        {
            JobPositionEnrolment jobPositionEnrolment = _workerBenefitsDbContext.JobPositionEnrolments.FirstOrDefault(x => x.Id.Equals(entity.Id));

            if (jobPositionEnrolment != null)
            {
                jobPositionEnrolment.JobPosition = entity.JobPosition;
                jobPositionEnrolment.JobPositionId = entity.JobPositionId;
                jobPositionEnrolment.EffectiveFrom = entity.EffectiveFrom;
                jobPositionEnrolment.EffectiveTo = entity.EffectiveTo;
                jobPositionEnrolment.CreatedOn = entity.CreatedOn;
                jobPositionEnrolment.UpdatedOn = DateTime.UtcNow;

            }

            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
