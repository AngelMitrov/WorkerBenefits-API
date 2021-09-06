using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class JobPositionEntityRepository : IRepository<JobPosition>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbConctext;

        public JobPositionEntityRepository(WorkerBenefitsDbContext workerBenefitsDbConctext)
        {
            _workerBenefitsDbConctext = workerBenefitsDbConctext;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<JobPosition> GetAll()
        {
            throw new NotImplementedException();
        }

        public JobPosition GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(JobPosition entity)
        {
            throw new NotImplementedException();
        }

        public void Update(JobPosition entity)
        {
            throw new NotImplementedException();
        }
    }
}
