using System.Linq;
using TheBattle.Model.Entities;
using TheBattle.Model.Repositories.Base;

namespace TheBattle.Model.Repositories
{
    public interface ISoldierRepository : IRepository<Soldier>
    {
        IQueryable<Soldier> GetAllFromArmy(Army army);
    }
}
