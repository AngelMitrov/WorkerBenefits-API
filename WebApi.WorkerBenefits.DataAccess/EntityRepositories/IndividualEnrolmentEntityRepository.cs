using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class IndividualEnrolmentEntityRepository : IRepository<IndivudualEnrolment>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbConctext;

        public IndividualEnrolmentEntityRepository(WorkerBenefitsDbContext workerBenefitsDbConctext)
        {
            _workerBenefitsDbConctext = workerBenefitsDbConctext;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<IndivudualEnrolment> GetAll()
        {
            throw new NotImplementedException();
        }

        public IndivudualEnrolment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(IndivudualEnrolment entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IndivudualEnrolment entity)
        {
            throw new NotImplementedException();
        }
    }
}
