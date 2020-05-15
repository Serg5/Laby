using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Torg.DomainObjects.Ports
{
    public interface IReadOnlyTorgRepository
    {
        Task<Torg> GetTorg(long id);

        Task<IEnumerable<Torg>> GetAllTorgs();

        Task<IEnumerable<Torg>> QueryTorgs(ICriteria<Torg> criteria);

    }

    public interface ITorgRepository
    {
        Task AddTorg(Torg torg);

        Task RemoveTorg(Torg torg);

        Task UpdateTorg(Torg torg);
    }
}
