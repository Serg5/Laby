using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Torg.DomainObjects.Ports
{
    public interface IReadOnlyLocationRepository
    {
        Task<Location> GetLocation(long id);

        Task<IEnumerable<Location>> GetAllLocations();

        Task<IEnumerable<Location>> QueryLocations(ICriteria<Location> criteria);
    }

    public interface ILocationRepository
    {
        Task AddLocation(Location location);

        Task UpdateLocation(Location location);

        Task RemoveLocation(Location location);
    }
}
