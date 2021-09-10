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
            if(benefit == null)
            {
                throw new Exception($"Benefit with ID: {id} not found!");
            }
            _workerBenefitsDbContext.Benefits.Remove(benefit);
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<Benefit> GetAll()
        {
            List<Benefit> benefits = _workerBenefitsDbContext.Benefits.ToList();
            if(benefits.Count() == 0)
            {
                throw new Exception($"You dont have any available benefits!");
            }

            return benefits;
        }

        public Benefit GetById(int id)
        {
            Benefit benefit = _workerBenefitsDbContext.Benefits.FirstOrDefault(x => x.Id.Equals(id));

            if (benefit == null)
            {
                throw new Exception($"A benefit with ID: {id} does not exist!");
            }
            return benefit;
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

            if (benefit == null)
            {
                throw new Exception($"Benefit with ID: {entity.Id} not found!");
            }
            benefit.Name = entity.Name;
            benefit.BenefitType = entity.BenefitType;
            benefit.BenefitTypeId = entity.BenefitTypeId;
            benefit.CreatedOn = entity.CreatedOn;
            benefit.UpdatedOn = DateTime.UtcNow;

            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
