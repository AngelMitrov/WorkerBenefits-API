using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class IndividualEnrolmentEntityRepository : IRepository<IndividualEnrolment>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbContext;

        public IndividualEnrolmentEntityRepository(WorkerBenefitsDbContext workerBenefitsDbConctext)
        {
            _workerBenefitsDbContext = workerBenefitsDbConctext;
        }

        public void DeleteById(int id)
        {
            IndividualEnrolment individualEnrolment = _workerBenefitsDbContext.IndividualEnrolments.FirstOrDefault(q => q.Id.Equals(id));
            if (individualEnrolment == null)
            {
                throw new Exception($"Individual enrolment with ID: {id} not found!");
            }
                _workerBenefitsDbContext.IndividualEnrolments.Remove(individualEnrolment);
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<IndividualEnrolment> GetAll()
        {
            List<IndividualEnrolment> individualEnrolments = _workerBenefitsDbContext.IndividualEnrolments.ToList();
            if (individualEnrolments.Count() == 0)
            {
                throw new Exception($"You dont have any available individual enrolments!");
            }
            return individualEnrolments;
        }

        public IndividualEnrolment GetById(int id)
        {
            IndividualEnrolment individualEnrolment = _workerBenefitsDbContext.IndividualEnrolments.FirstOrDefault(x => x.Id.Equals(id));

            if (individualEnrolment == null)
            {
                throw new Exception($"A individual enrolment with ID: {id} does not exist!");
            }
            return individualEnrolment;
        }

        public int Insert(IndividualEnrolment entity)
        {
            _workerBenefitsDbContext.IndividualEnrolments.Add(entity);
            _workerBenefitsDbContext.SaveChanges();
            return entity.Id;
        }

        public void Update(IndividualEnrolment entity)
        {
            IndividualEnrolment individualEnrolment = _workerBenefitsDbContext.IndividualEnrolments.FirstOrDefault(x => x.Id.Equals(entity.Id));

            if (individualEnrolment == null)
            {
                throw new Exception($"Individual enrolment with ID: {entity.Id} not found!");
            }
            individualEnrolment.Worker = entity.Worker;
            individualEnrolment.WorkerId = entity.WorkerId;
            individualEnrolment.EffectiveFrom = entity.EffectiveFrom;
            individualEnrolment.EffectiveTo = entity.EffectiveTo;
            individualEnrolment.CreatedOn = entity.CreatedOn;
            individualEnrolment.UpdatedOn = DateTime.UtcNow;

            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
