using Microsoft.EntityFrameworkCore;
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
            if (jobPositionEnrolment == null)
            {
                throw new Exception($"Job position enrolment with ID: {id} not found!");
            }
            _workerBenefitsDbContext.JobPositionEnrolments.Remove(jobPositionEnrolment);
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<JobPositionEnrolment> GetAll()
        {
            List<JobPositionEnrolment> jobPositionEnrolments = _workerBenefitsDbContext.JobPositionEnrolments.Include(x => x.Benefit).Include(x => x.JobPosition).ToList();
            if (jobPositionEnrolments.Count() == 0)
            {
                throw new Exception($"You dont have any available job position enrolments!");
            }
            return jobPositionEnrolments;
        }

        public JobPositionEnrolment GetById(int id)
        {
            JobPositionEnrolment jobPositionEnrolment = _workerBenefitsDbContext.JobPositionEnrolments.FirstOrDefault(x => x.Id.Equals(id));

            if (jobPositionEnrolment == null)
            {
                throw new Exception($"A job position enrolment with ID: {id} does not exist!");
            }
            return jobPositionEnrolment;
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

            if (jobPositionEnrolment == null)
            {
                throw new Exception($"Job position enrolment with ID: {entity.Id} not found!");
            }
            jobPositionEnrolment.JobPositionId = entity.JobPositionId;
            jobPositionEnrolment.BenefitId = entity.BenefitId;
            jobPositionEnrolment.EffectiveFrom = entity.EffectiveFrom;
            jobPositionEnrolment.EffectiveTo = entity.EffectiveTo;
            jobPositionEnrolment.CreatedOn = entity.CreatedOn;
            jobPositionEnrolment.UpdatedOn = DateTime.UtcNow;

            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
