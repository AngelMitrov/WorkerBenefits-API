using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class TechnologyTypeEntityRepository : IRepository<TechnologyTypeEntityRepository>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbContext;

        public TechnologyTypeEntityRepository(WorkerBenefitsDbContext workerBenefitsDbContext)
        {
            _workerBenefitsDbContext = workerBenefitsDbContext;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TechnologyTypeEntityRepository> GetAll()
        {
            throw new NotImplementedException();
        }

        public TechnologyTypeEntityRepository GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(TechnologyTypeEntityRepository entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TechnologyTypeEntityRepository entity)
        {
            throw new NotImplementedException();
        }
    }
}
