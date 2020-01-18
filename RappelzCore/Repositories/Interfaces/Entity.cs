using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RappelzCore.Repositories.Interfaces
{
    //public abstract class Entity<TEntity> : IEntity<int> where TEntity : class, IEntity<int>
    public abstract class Entity : IEntity<int>
    {
        public int EntityId { get; }
    }
}
