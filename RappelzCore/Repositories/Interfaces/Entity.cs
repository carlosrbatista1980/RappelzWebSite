using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace RappelzCore.Repositories.Interfaces
{
    //public abstract class Entity<TEntity> : IEntity<int> where TEntity : class, IEntity<int>
    public abstract class Entity : IEntity<int>
    {
        [Key]
        public int EntityId { get; }
    }
}
