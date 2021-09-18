using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferModels;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess
{
    public interface IWorkerEntityRepository : IRepository<Worker>
    {
        BenefitsForWorker GetAllBenefitsForWorkerById(int id);
    }
}
