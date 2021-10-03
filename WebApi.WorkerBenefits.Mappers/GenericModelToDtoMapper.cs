using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.WorkerBenefits.Mappers
{
    public static class GenericModelToDtoMapper
    {
        public static MapTo MapFromModelToDTO<MapFrom, MapTo>(this MapFrom domainModel)
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<MapFrom, MapTo>();
            });

            IMapper iMapper = config.CreateMapper();
            MapFrom model = domainModel;
            return iMapper.Map<MapTo>(model);
        }
    }
}
