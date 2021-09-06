using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class JobPositionEnrolmentEntityRepository : IRepository<JobPositionEnrolment>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbConctext;

        public JobPositionEnrolmentEntityRepository(WorkerBenefitsDbContext workerBenefitsDbConctext)
        {
            _workerBenefitsDbConctext = workerBenefitsDbConctext;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<JobPositionEnrolment> GetAll()
        {
            throw new NotImplementedException();
        }

        public JobPositionEnrolment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(JobPositionEnrolment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(JobPositionEnrolment entity)
        {
            throw new NotImplementedException();
        }
    }
}
