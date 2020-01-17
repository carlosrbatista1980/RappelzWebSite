using Microsoft.EntityFrameworkCore;

namespace RappelzCore.Repositories.Interfaces
{
    public interface IEntity<TPrimaryKey>
    {
        int Id { get; }
    }
}