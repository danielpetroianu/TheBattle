using System.Linq;
using TheBattle.Model.Entities;

namespace TheBattle.Model.Repositories
{
    public interface ISoldierRepository : IRepository<Soldier>
    {
        IQueryable<Soldier> GetAllFromArmy(Army army);
    }
}
