using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess
{
    public interface IWorkerEntityRepository : IRepository<Worker>
    {
        BenefitsForWorkerDTO GetAllBenefitsForWorkerById(int id);
        Worker GetWorkerByUsernameAndPass(string username, string pass);
    }
}
