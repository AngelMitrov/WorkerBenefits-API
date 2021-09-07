using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.Domain.Enums;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class BenefitEntityRepository : IRepository<Benefit>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbContext;

        public BenefitEntityRepository(WorkerBenefitsDbContext workerBenefitsDbConctext)
        {
            _workerBenefitsDbContext = workerBenefitsDbConctext;
        }

        public void DeleteById(int id)
        {
            Benefit benefit = _workerBenefitsDbContext.Benefits.FirstOrDefault(q => q.Id.Equals(id));
            if(benefit != null)
            {
                _workerBenefitsDbContext.Benefits.Remove(benefit);
            }
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<Benefit> GetAll()
        {
            return _workerBenefitsDbContext.Benefits.ToList();
        }

        public Benefit GetById(int id)
        {
            return _workerBenefitsDbContext.Benefits.FirstOrDefault(x => x.Id.Equals(id));
        }

        public int Insert(Benefit entity)
        {
            _workerBenefitsDbContext.Benefits.Add(entity);
            _workerBenefitsDbContext.SaveChanges();
            return entity.Id;
        }

        public void Update(Benefit entity)
        {
            Benefit benefit = _workerBenefitsDbContext.Benefits.FirstOrDefault(x => x.Id.Equals(entity.Id));

            if (benefit != null)
            {
                benefit.Name = entity.Name;
                benefit.BenefitType = entity.BenefitType;
                benefit.BenefitTypeId = entity.BenefitTypeId;
                benefit.CreatedOn = entity.CreatedOn;
                benefit.UpdatedOn = DateTime.UtcNow;

            }

            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
