using System.Diagnostics;
using AutoMapper;

namespace RappelzCore.Helpers
{
    public interface IMap<TSource, TDestination>
    {
        TSource Map2<TSource>(TDestination destination);
        //TDestination Map<TDestination>(TSource source);
        //TDestination Map<TDestination>(object source);
        TDestination MapEntity<TSource, TDestination>(TSource source);
        //TDestination Map<TSource, TDestination>(TSource source, TDestination destination);


        /*

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
}
