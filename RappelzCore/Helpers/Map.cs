using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RappelzCore.Repositories.Interfaces;


namespace RappelzCore.Helpers
{
    public class Map<TSource, TDestination> : IMap<TSource, TDestination> where TDestination : class, IEntity<int>
    {
        protected IMapper m;
        protected TDestination dest;
        protected TSource src;

        public Map(TSource source, TDestination destination)
        {
            src = source;
            dest = destination;
            var mapCfg = new MapperConfiguration(cfg => cfg.CreateMap<TSource, TDestination>());
            this.m = mapCfg.CreateMapper();
            //var g = m.Map(source, destination);
        }

        //TDestination Map<TSource>(TDestination destination);

        public TSource Map2<TSource>(TDestination destination)
        {
            var ret = m.Map<TSource>(destination);
            return ret;
        }

        public TDestination MapFromViewModelToRepository(TSource source, TDestination destination)
        {
            return m.Map(source, destination);
        }

        public TDestination MapEntity<TSource, TDestination>(TSource source)
        {
            var ret = m.Map<TDestination>(source);
            return ret;
        }
    }

    


    /*

        TDestination Map<TSource>(TDestination destination);
        TDestination Map<TDestination>(TSource source);
        TDestination Map<TDestination>(object source);
        TDestination Map<TSource, TDestination>(TSource source);
        TDestination Map<TSource, TDestination>(TSource source, TDestination destination);

    var ftm = new FormTestModel();
        var mapConfig = new MapperConfiguration(cfg => cfg.CreateMap<FormTestViewModel, FormTestModel>());
        var _formTestViewModel = formTestViewModel;
        var maper = mapConfig.CreateMapper();

        maper.Map(_formTestViewModel, ftm);

        ValuesController vcController = new ValuesController();
        vcController.InsertResult(ftm);

        mapConfig = new MapperConfiguration(cfg => cfg.CreateMap<FormTestModel, FormTestViewModel>());
        maper = mapConfig.CreateMapper();

        maper.Map(ftm, _formTestViewModel);

        formTestViewModel = _formTestViewModel;





    /// <summary>
    /// Execute a mapping from the source object to a new destination object.
    /// The source type is inferred from the source object.
    /// </summary>
    /// <typeparam name="TDestination">Destination type to create</typeparam>
    /// <param name="source">Source object to map from</param>
    /// <returns>Mapped destination object</returns>
    TDestination Map<TDestination>(object source);

    /// <summary>
    /// Execute a mapping from the source object to a new destination object.
    /// </summary>
    /// <typeparam name="TSource">Source type to use, regardless of the runtime type</typeparam>
    /// <typeparam name="TDestination">Destination type to create</typeparam>
    /// <param name="source">Source object to map from</param>
    /// <returns>Mapped destination object</returns>
    TDestination Map<TSource, TDestination>(TSource source);


    /// <summary>
    /// Execute a mapping from the source object to the existing destination object.
    /// </summary>
    /// <typeparam name="TSource">Source type to use</typeparam>
    /// <typeparam name="TDestination">Destination type</typeparam>
    /// <param name="source">Source object to map from</param>
    /// <param name="destination">Destination object to map into</param>
    /// <returns>The mapped destination object, same instance as the <paramref name="destination"/> object</returns>
    TDestination Map<TSource, TDestination>(TSource source, TDestination destination);

    /// <summary>
    /// Configuration provider for performing maps
    /// </summary>
    IConfigurationProvider ConfigurationProvider { get; }
    */
    
}
