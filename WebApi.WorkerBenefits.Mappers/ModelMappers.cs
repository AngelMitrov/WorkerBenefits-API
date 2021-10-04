using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Mappers
{
    public static class ModelMappers
    {

        // BENEFIT ========================================================
        public static BenefitDTO ToDto(this Benefit domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Benefit, BenefitDTO>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<BenefitDTO>(domainModel);
        }

        public static Benefit ToDomain(this BenefitDTO domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<BenefitDTO, Benefit>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<Benefit>(domainModel);
        }
        // INDIVIDUAL ENROLMENT ========================================================

        public static IndividualEnrolmentDTO ToDto(this IndividualEnrolment domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<IndividualEnrolment, IndividualEnrolmentDTO>();
                cfg.CreateMap<Benefit, BenefitDTO>();
                cfg.CreateMap<Worker, WorkerDTO>();
                cfg.CreateMap<JobPosition, JobPositionDTO>();
                cfg.CreateMap<TechnologyType, TechnologyTypeDTO>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<IndividualEnrolmentDTO>(domainModel);
        }

        public static IndividualEnrolment ToDomain(this IndividualEnrolmentDTO domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<IndividualEnrolmentDTO, IndividualEnrolment>();
                cfg.CreateMap<BenefitDTO, Benefit>();
                cfg.CreateMap<WorkerDTO, Worker>();
                cfg.CreateMap<JobPositionDTO, JobPosition>();
                cfg.CreateMap<TechnologyTypeDTO, TechnologyType>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<IndividualEnrolment>(domainModel);
        }
        // JOB POSITION ========================================================

        public static JobPositionDTO ToDto(this JobPosition domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<JobPosition, JobPositionDTO>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<JobPositionDTO>(domainModel);
        }

        public static JobPosition ToDomain(this JobPositionDTO domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<JobPositionDTO, JobPosition>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<JobPosition>(domainModel);
        }
        // JOB POSITION ENROLMENT ========================================================

        public static JobPositionEnrolmentDTO ToDto(this JobPositionEnrolment domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<JobPositionEnrolment, JobPositionEnrolmentDTO>();
                cfg.CreateMap<Benefit, BenefitDTO>();
                cfg.CreateMap<JobPosition, JobPositionDTO>();

            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<JobPositionEnrolmentDTO>(domainModel);
        }

        public static JobPositionEnrolment ToDomain(this JobPositionEnrolmentDTO domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<JobPositionEnrolmentDTO, JobPositionEnrolment>();
                cfg.CreateMap<BenefitDTO, Benefit>();
                cfg.CreateMap<JobPositionDTO, JobPosition>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<JobPositionEnrolment>(domainModel);
        }
        // TECHNOLOGY TYPE ========================================================

        public static TechnologyTypeDTO ToDto(this TechnologyType domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TechnologyType, TechnologyTypeDTO>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<TechnologyTypeDTO>(domainModel);
        }

        public static TechnologyType ToDomain(this TechnologyTypeDTO domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TechnologyTypeDTO, TechnologyType>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<TechnologyType>(domainModel);
        }
        // TECHNOLOGY TYPE ENROLMENT ========================================================
        public static TechnologyTypeEnrolmentDTO ToDto(this TechnologyTypeEnrolment domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TechnologyTypeEnrolment, TechnologyTypeEnrolmentDTO>();
                cfg.CreateMap<Benefit, BenefitDTO>();
                cfg.CreateMap<TechnologyType, TechnologyTypeDTO>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<TechnologyTypeEnrolmentDTO>(domainModel);
        }

        public static TechnologyTypeEnrolment ToDomain(this TechnologyTypeEnrolmentDTO domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TechnologyTypeEnrolmentDTO, TechnologyTypeEnrolment>();
                cfg.CreateMap<BenefitDTO, Benefit>();
                cfg.CreateMap<TechnologyTypeDTO, TechnologyType>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<TechnologyTypeEnrolment>(domainModel);
        }
        // WORKER ========================================================

        public static WorkerDTO ToDto(this Worker domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Worker, WorkerDTO>();
                cfg.CreateMap<TechnologyType, TechnologyTypeDTO>();
                cfg.CreateMap<JobPosition, JobPositionDTO>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<WorkerDTO>(domainModel);
            
        }

        public static Worker ToDomain(this WorkerDTO domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<WorkerDTO, Worker>();
                cfg.CreateMap<TechnologyTypeDTO, TechnologyType>();
                cfg.CreateMap<JobPositionDTO, JobPosition>();
            });

            IMapper iMapper = config.CreateMapper();
            return iMapper.Map<Worker>(domainModel);
        }
    }
}
