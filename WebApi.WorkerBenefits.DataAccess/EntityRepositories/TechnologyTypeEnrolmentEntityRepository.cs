using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public List<TechnologyTypeEnrolment> GetAll()
        {
            throw new NotImplementedException();
        }

        public TechnologyTypeEnrolment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(TechnologyTypeEnrolment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TechnologyTypeEnrolment entity)
        {
            throw new NotImplementedException();
        }
    }
}
