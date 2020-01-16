using Microsoft.EntityFrameworkCore;

namespace RappelzCore.Repositories.Interfaces
{
    public interface IEntity
    {
        int Id { get; }
    }
}