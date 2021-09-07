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
            if (techTypeEnrolment != null)
            {
                _workerBenefitsDbContext.TechnologyTypeEnrolments.Remove(techTypeEnrolment);
            }
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<TechnologyTypeEnrolment> GetAll()
        {
            return _workerBenefitsDbContext.TechnologyTypeEnrolments.ToList();
        }

        public TechnologyTypeEnrolment GetById(int id)
        {
            return _workerBenefitsDbContext.TechnologyTypeEnrolments.FirstOrDefault(x => x.Id.Equals(id));
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
            if (technologyTypeEnrolment != null)
            {
                technologyTypeEnrolment.TechnologyType = entity.TechnologyType;
                technologyTypeEnrolment.TechnologyTypeId = entity.TechnologyTypeId;
                technologyTypeEnrolment.EffectiveFrom = entity.EffectiveFrom;
                technologyTypeEnrolment.EffectiveTo = entity.EffectiveTo;
                technologyTypeEnrolment.CreatedOn = entity.CreatedOn;
                technologyTypeEnrolment.UpdatedOn = DateTime.UtcNow;
            }
            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
