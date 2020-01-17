using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RappelzCore.Repositories.Interfaces;
namespace RappelzCore.Helpers
{
    public static class MapHelper
    {
        public static TDestination MapFrom<TDestination>(object source, TDestination dest)
        {
            var _source = source.GetType();
            var _dest = dest.GetType();
            var _mapperCfg = new MapperConfiguration(cfg => cfg.CreateMap(_source,  _dest));
            var _mapper = _mapperCfg.CreateMapper();
            var ret = _mapper.Map<object, TDestination>(source, dest);
            return ret;
        }
    }
}