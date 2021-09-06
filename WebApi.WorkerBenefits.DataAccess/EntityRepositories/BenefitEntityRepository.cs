using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class BenefitEntityRepository : IRepository<Benefit>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbConctext;

        public BenefitEntityRepository(WorkerBenefitsDbContext workerBenefitsDbConctext)
        {
            _workerBenefitsDbConctext = workerBenefitsDbConctext;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Benefit> GetAll()
        {
            throw new NotImplementedException();
        }

        public Benefit GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Benefit entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Benefit entity)
        {
            throw new NotImplementedException();
        }
    }
}
