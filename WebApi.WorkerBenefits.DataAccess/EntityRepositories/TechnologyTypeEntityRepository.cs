using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.DataAccess.EntityRepositories
{
    public class TechnologyTypeEntityRepository : IRepository<TechnologyType>
    {
        private WorkerBenefitsDbContext _workerBenefitsDbContext;

        public TechnologyTypeEntityRepository(WorkerBenefitsDbContext workerBenefitsDbContext)
        {
            _workerBenefitsDbContext = workerBenefitsDbContext;
        }

        public void DeleteById(int id)
        {
            TechnologyType techType = _workerBenefitsDbContext.TechnologyTypes.FirstOrDefault(x => x.Id.Equals(id));
            if (techType != null)
            {
                _workerBenefitsDbContext.TechnologyTypes.Remove(techType);
            }
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<TechnologyType> GetAll()
        {
            return _workerBenefitsDbContext.TechnologyTypes.ToList();
        }

        public TechnologyType GetById(int id)
        {
            return _workerBenefitsDbContext.TechnologyTypes.FirstOrDefault(x => x.Id.Equals(id));
        }

        public int Insert(TechnologyType entity)
        {
            _workerBenefitsDbContext.TechnologyTypes.Add(entity);
            _workerBenefitsDbContext.SaveChanges();
            return entity.Id;
        }

        public void Update(TechnologyType entity)
        {
            TechnologyType technologyType = _workerBenefitsDbContext.TechnologyTypes.FirstOrDefault(x => x.Id.Equals(entity.Id));
            if (technologyType != null)
            {
                technologyType.Name = entity.Name;
                technologyType.CreatedOn = entity.CreatedOn;
                technologyType.UpdatedOn = DateTime.UtcNow;
            }
            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
