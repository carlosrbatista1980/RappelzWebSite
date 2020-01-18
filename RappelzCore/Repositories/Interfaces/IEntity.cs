using Microsoft.EntityFrameworkCore;

namespace RappelzCore.Repositories.Interfaces
{
    public interface IEntity<TPrimaryKey> where TPrimaryKey : struct
    {
        TPrimaryKey EntityId { get; }
    }
}