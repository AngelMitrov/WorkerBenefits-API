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
            if (techType == null)
            {
                throw new Exception($"Technology type with ID: {id} not found!");
            }
            _workerBenefitsDbContext.TechnologyTypes.Remove(techType);
            _workerBenefitsDbContext.SaveChanges();
        }

        public List<TechnologyType> GetAll()
        {
            List<TechnologyType> technologyTypes = _workerBenefitsDbContext.TechnologyTypes.ToList();
            if (technologyTypes.Count() == 0)
            {
                throw new Exception($"You dont have any available technology types!");
            }
            return technologyTypes;
        }

        public TechnologyType GetById(int id)
        {
            TechnologyType technologyType = _workerBenefitsDbContext.TechnologyTypes.FirstOrDefault(x => x.Id.Equals(id));

            if (technologyType == null)
            {
                throw new Exception($"A technology types with ID: {id} does not exist!");
            }
            return technologyType;
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
            if (technologyType == null)
            {
                throw new Exception($"Technology type with ID: {entity.Id} not found!");
            }
            technologyType.Name = entity.Name;
            technologyType.CreatedOn = entity.CreatedOn;
            technologyType.UpdatedOn = DateTime.UtcNow;

            _workerBenefitsDbContext.SaveChanges();
        }
    }
}
