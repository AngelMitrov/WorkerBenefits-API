using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Mappers;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Services
{
    public class WorkerService : IWorkerService
    {
        private IWorkerEntityRepository _workerRepository;
        private IRepository<TechnologyTypeEnrolment> _technologyTypeEnrolmentRepository;
        private IRepository<JobPositionEnrolment> _jobPositionEnrolmentRepository;
        private IRepository<IndividualEnrolment> _individualEnrolmentRepository;
        public WorkerService(IWorkerEntityRepository workerRepository, 
                             IRepository<TechnologyTypeEnrolment> technologyTypeEnrolmentRepository,
                             IRepository<JobPositionEnrolment> jobPositionEnrolmentRepository, 
                             IRepository<IndividualEnrolment> individualEnrolmentRepository)
        {
            _workerRepository = workerRepository;
            _technologyTypeEnrolmentRepository = technologyTypeEnrolmentRepository;
            _jobPositionEnrolmentRepository = jobPositionEnrolmentRepository;
            _individualEnrolmentRepository = individualEnrolmentRepository;
        }
        public int AddNewWorker(WorkerDTO entity)
        {
            entity.Password = entity.Password.GenerateMD5();
            _workerRepository.Insert(entity.ToDomain());
            return entity.Id;
        }

        public void DeleteWorkerById(int id)
        {
            _workerRepository.DeleteById(id);
        }

        public List<WorkerDTO> GetAllWorkers()
        {
            List<WorkerDTO> workersDto = new List<WorkerDTO>();
            List<Worker> workersDomain = _workerRepository.GetAll();

            foreach (Worker worker in workersDomain)
            {
                WorkerDTO mappedWorker = worker.ToDto();
                workersDto.Add(mappedWorker);
            }

            return workersDto;
        }

        public BenefitsForWorkerDTO GetAllBenefitsForWorkerById(int id)
        {
            return _workerRepository.GetAllBenefitsForWorkerById(id);
        }

        public WorkerDTO GetWorkerById(int id)
        {
            WorkerDTO worker = _workerRepository.GetById(id).ToDto();

            return worker;
        }

        public void UpdateWorker(WorkerDTO entity)
        {
            _workerRepository.Update(entity.ToDomain());
        }

        public BenefitsForWorkerDTO GetAllBenefitsForWorkerByIdNew(int id)
        {
            BenefitsForWorkerDTO workerDto = new BenefitsForWorkerDTO();
            Worker worker = _workerRepository.GetById(id);

            //var jobPositionBenefit = _technologyTypeEnrolmentRepository.

            //    Benefit technologyTypeBenefit = _workerBenefitsDbContext.TechnologyTypeEnrolments
            //                                                            .Include(x => x.Benefit)
            //                                                            .Include(x => x.TechnologyType)
            //                                                            .FirstOrDefault(x => x.TechnologyTypeId.Equals(worker.TechnologyTypeId))
            //                                                            .Benefit;

            //    Benefit individualBenefit = _workerBenefitsDbContext.IndividualEnrolments
            //                                                        .Include(x => x.Worker)
            //                                                        .FirstOrDefault(x => x.WorkerId.Equals(worker.Id))
            //                                                        .Benefit;


                //List <Benefit> benefits = new List<Benefit>() {};

                //BenefitsForWorkerDTO workerBenefits = new BenefitsForWorkerDTO()
                //{
                //    WorkerId = worker.Id,
                //    Worker = worker,
                //    Benefits = benefits,
                //};
            return workerDto;
        }

        public string GetLoginToken(LoginDTO loginDto)
        {
            Worker loggedWorker = _workerRepository.GetWorkerByUsernameAndPass(loginDto.Username, loginDto.Password.GenerateMD5());
            if(loggedWorker == null)
            {
                return string.Empty;
            }
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes("v9pU6HkfcZst3ksP");

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new[]
                    {
                        new Claim(ClaimTypes.Name, loggedWorker.Username),
                        new Claim(ClaimTypes.NameIdentifier, loggedWorker.Id.ToString())
                    }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
