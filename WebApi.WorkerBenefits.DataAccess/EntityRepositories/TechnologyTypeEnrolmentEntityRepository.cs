using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class TechnologyTypeEnrolmentEntityRepository : IRepository<TechnologyTypeEnrolment>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbContext;

        public TechnologyTypeEnrolmentEntityRepository(WorkerBenefitsDbContext workerBenefitsDbContext)
        {
            _workerBenefitsDbContext = workerBenefitsDbContext;
        }

        public void DeleteById(int id)
        {
            TechnologyTypeEnrolment techTypeEnrolment = _workerBenefitsDbContext.TechnologyTypeEnrolments.FirstOrDefault(x => x.Id.Equals(id));
            if (techTypeEnrolment == null)
            {
                throw new Exception($"Technology type enrolment with ID: {id} not found!");
            }
            _workerBenefitsDbContext.TechnologyTypeEnrolments.Remove(techTypeEnrolment);
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<TechnologyTypeEnrolment> GetAll()
        {
            List<TechnologyTypeEnrolment> technologyTypeEnrolments = _workerBenefitsDbContext.TechnologyTypeEnrolments.ToList();
            if (technologyTypeEnrolments.Count() == 0)
            {
                throw new Exception($"You dont have any available technology type enrolments!");
            }
            return technologyTypeEnrolments;
        }

        public TechnologyTypeEnrolment GetById(int id)
        {
            TechnologyTypeEnrolment technologyTypeEnrolment = _workerBenefitsDbContext.TechnologyTypeEnrolments.FirstOrDefault(x => x.Id.Equals(id));

            if (technologyTypeEnrolment == null)
            {
                throw new Exception($"A technology type enrolment with ID: {id} does not exist!");
            }
            return technologyTypeEnrolment;
        }

        public int Insert(TechnologyTypeEnrolment entity)
        {
            _workerBenefitsDbContext.TechnologyTypeEnrolments.Add(entity);
            _workerBenefitsDbContext.SaveChanges();
            return entity.Id;
        }

        public void Update(TechnologyTypeEnrolment entity)
        {
            TechnologyTypeEnrolment technologyTypeEnrolment = _workerBenefitsDbContext.TechnologyTypeEnrolments.FirstOrDefault(x => x.Id.Equals(entity.Id));
            if (technologyTypeEnrolment == null)
            {
                throw new Exception($"Technology type enrolment with ID: {entity.Id} not found!");
            }
            technologyTypeEnrolment.TechnologyType = entity.TechnologyType;
            technologyTypeEnrolment.TechnologyTypeId = entity.TechnologyTypeId;
            technologyTypeEnrolment.EffectiveFrom = entity.EffectiveFrom;
            technologyTypeEnrolment.EffectiveTo = entity.EffectiveTo;
            technologyTypeEnrolment.CreatedOn = entity.CreatedOn;
            technologyTypeEnrolment.UpdatedOn = DateTime.UtcNow;

            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
